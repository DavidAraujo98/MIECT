/* ************************************************************
 * Xenomai - creates a periodic task
 *
 * Paulo Pedreiras
 * 	Out/2020: Upgraded from Xenomai V2.5 to V3.1
 *
 ************************************************************** */

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <signal.h>
#include <math.h>

#include <sys/mman.h> // For mlockall

// Xenomai API (former Native API)
#include <alchemy/task.h>
#include <alchemy/timer.h>

#define MS_2_NS(ms) (ms * 1000 * 1000) /* Convert ms to ns */
#define BOOT_ITER 10

/* *****************************************************
 * Define task structure for setting input arguments
 * *****************************************************/
struct taskArgsStruct
{
    RTIME taskPeriod_ns;
    int some_other_arg;
};

/* *******************
 * Task attributes
 * *******************/
#define TASK_MODE 0  // No flags
#define TASK_STKSZ 0 // Default stack size

#define TASK_A_PRIO 25 // RT priority [0..99]
#define TASK_A_PERIOD_NS MS_2_NS(1000)

RT_TASK task_a_desc; // Task decriptor
RT_TASK task_b_desc;
RT_TASK task_c_desc;

/* *********************
 * Function prototypes
 * **********************/
void catch_signal(int sig); /* Catches CTRL + C to allow a controlled termination of the application */
void wait_for_ctrl_c(void);
void Heavy_Work(void);      /* Load task */
void task_code(void *args); /* Task body */

/* ******************
 * Main function
 * *******************/
int main(int argc, char *argv[])
{
    int err, err1, err2;
    struct taskArgsStruct taskAArgs;
    struct taskArgsStruct taskBBrgs;
    struct taskArgsStruct taskCCrgs;

    /* Lock memory to prevent paging */
    mlockall(MCL_CURRENT | MCL_FUTURE);

    /* Create RT task */
    /* Args: descriptor, name, stack size, priority [0..99] and mode (flags for CPU, FPU, joinable ...) */
    err = rt_task_create(&task_a_desc, "Task A", TASK_STKSZ, 1, TASK_MODE);
    err1 = rt_task_create(&task_b_desc, "Task B", TASK_STKSZ, 50, TASK_MODE);
    err2 = rt_task_create(&task_c_desc, "Task C", TASK_STKSZ, 99, TASK_MODE);

    if (err)
    {
        printf("Error creating task A (error code = %d)\n", err);
        return err;
    }
    else if (err1)
    {
        printf("Error creating task B (error code = %d)\n", err1);
        return err;
    }
    else if (err2)
    {
        printf("Error creating task C (error code = %d)\n", err2);
        return err;
    }
    else
        printf("Task a created successfully\n");

    /* Start RT task */
    /* Args: task decriptor, address of function/implementation and argument*/
    taskAArgs.taskPeriod_ns = TASK_A_PERIOD_NS;
    taskBBrgs.taskPeriod_ns = TASK_A_PERIOD_NS;
    taskCCrgs.taskPeriod_ns = TASK_A_PERIOD_NS;

    cpu_set_t cpuset;
    CPU_ZERO(&cpuset);
    CPU_SET(0, &cpuset);
    if (rt_task_set_affinity(&task_a_desc, &cpuset) || rt_task_set_affinity(&task_b_desc, &cpuset) || rt_task_set_affinity(&task_c_desc, &cpuset))
    {
        printf("\n Lock of process to CPU0 failed!!!");
        return (1);
    }

    rt_task_start(&task_a_desc, &task_code, (void *)&taskAArgs);
    rt_task_start(&task_b_desc, &task_code, (void *)&taskBBrgs);
    rt_task_start(&task_c_desc, &task_code, (void *)&taskCCrgs);

    /* wait for termination signal */
    wait_for_ctrl_c();

    return 0;
}

/* ***********************************
 * Task body implementation
 * *************************************/
void task_code(void *args)
{
    RT_TASK *curtask;
    RT_TASK_INFO curtaskinfo;
    struct taskArgsStruct *taskArgs;

    RTIME ta, lt, maxt = 0;
    RTIME ita;
    RTIME mint = LLONG_MIN;
    unsigned long overruns;
    int err;
    int up = 0;
    int niter = 0;

    /* Get task information */
    curtask = rt_task_self();
    rt_task_inquire(curtask, &curtaskinfo);
    taskArgs = (struct taskArgsStruct *)args;
    printf("Task %s init, period: %llu\n", curtaskinfo.name, taskArgs->taskPeriod_ns);

    /* Set task as periodic */
    err = rt_task_set_periodic(NULL, TM_NOW, taskArgs->taskPeriod_ns);
    for (;;)
    {
        err = rt_task_wait_period(&overruns);
        ta = rt_timer_read();
        if (err)
        {
            printf("task %s overrun!!!\n", curtaskinfo.name);
            break;
        }
        // printf("Task %s activation at time %llu\n", curtaskinfo.name,ta);
        niter++;

        if (niter == BOOT_ITER)
        {
            maxt = ta - lt;
            mint = ta - lt;
            up = 1;
        }
        else if (niter > BOOT_ITER)
        {
            ita = ta - lt;
            if (ita > maxt)
            {
                maxt = ita;
                up = 1;
            }
            if (ita < mint)
            {
                mint = ita;
                up = 1;
            }
        }

        if (up)
        {
            printf("Time between successive jobs of %s : min: %llu / max: %llu\n\n", curtaskinfo.name, mint, maxt);
            up = 0;
        }
        /* Task "load" */
        Heavy_Work();
        lt = ta;
    }
    return;
}

/* **************************************************************************
 *  Catch control+c to allow a controlled termination
 * **************************************************************************/
void catch_signal(int sig)
{
    return;
}

void wait_for_ctrl_c(void)
{
    signal(SIGTERM, catch_signal); // catch_signal is called if SIGTERM received
    signal(SIGINT, catch_signal);  // catch_signal is called if SIGINT received

    // Wait for CTRL+C or sigterm
    pause();

    // Will terminate
    printf("Terminating ...\n");
}

/* **************************************************************************
 *  Task load implementation. In the case integrates numerically a function
 * **************************************************************************/
#define f(x) 1 / (1 + pow(x, 2)) /* Define function to integrate*/
void Heavy_Work(void)
{
    float lower, upper, integration = 0.0, stepSize, k;
    int i, subInterval;

    RTIME ts, // Function start time
        tf;   // Function finish time

    static int first = 0; // Flag to signal first execution

    /* Get start time */
    ts = rt_timer_read();

    /* Integration parameters */
    /*These values can be tunned to cause a desired load*/
    lower = 0;
    upper = 100;
    subInterval = 1000000;

    /* Calculation */
    /* Finding step size */
    stepSize = (upper - lower) / subInterval;

    /* Finding Integration Value */
    integration = f(lower) + f(upper);
    for (i = 1; i <= subInterval - 1; i++)
    {
        k = lower + i * stepSize;
        integration = integration + 2 * f(k);
    }
    integration = integration * stepSize / 2;

    /* Get finish time and show results */
    if (!first)
    {
        tf = rt_timer_read();
        tf -= ts; // Compute time difference form start to finish

        printf("Integration value is: %.3f. It took %9llu ns to compute.\n", integration, tf);

        first = 1;
    }
}
