#include <stdio.h>
#include <stdint.h>
#include <stdlib.h>
#include <sys/types.h>
#include <unistd.h>
#include <signal.h>

int main(void)
{

    uint32_t pid;
    printf("PID: ");
    scanf("%d", &pid);
    printf("Trying SIGINT\n");
    kill(pid, SIGINT);
    if (0 == kill(pid,0)){
        printf("Trying SIGTERM\n");
        kill(pid, SIGTERM);
    }
}