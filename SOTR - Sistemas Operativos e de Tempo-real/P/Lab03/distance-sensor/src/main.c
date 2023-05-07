#include <zephyr/zephyr.h>
#include <zephyr/device.h>
#include <zephyr/devicetree.h>
#include <zephyr/sys/printk.h>
#include <zephyr/drivers/adc.h>
#include <zephyr/drivers/gpio.h>
#include <zephyr/random/rand32.h>
#include <zephyr/sys/util.h>
#include <zephyr/kernel.h>

#include <inttypes.h>
#include <stddef.h>
#include <stdint.h>

/* Thread and Shared memory */
#define STACK_SIZE 1024
#define sampler_prio 1
#define filter_prio 1
#define output_prio 1
#define SAMP_PERIOD_MS 100

K_THREAD_STACK_DEFINE(sampler_stack, STACK_SIZE);
K_THREAD_STACK_DEFINE(filter_stack, STACK_SIZE);
K_THREAD_STACK_DEFINE(output_stack, STACK_SIZE);

struct k_thread sampler_data;
struct k_thread filter_data;
struct k_thread output_data;

k_tid_t sampler_tid;
k_tid_t filter_tid;
k_tid_t output_tid;

uint32_t filtered;

struct k_sem sem_ab;
struct k_sem sem_bc;

void sampler_code(void *argA, void *argB, void *argC);
void filter_code(void *argA, void *argB, void *argC);
void output_code(void *argA, void *argB, void *argC);
/* ======================== */

/* Blinking and led control */
#define BLINK_TIME_MS 5000
#define SLEEP_TIME_MS 200

#define LED0_NODE DT_ALIAS(led0)
#define LED1_NODE DT_ALIAS(led1)
#define LED2_NODE DT_ALIAS(led2)
#define LED3_NODE DT_ALIAS(led3)
#define SW0_NODE DT_ALIAS(sw0)

static const struct gpio_dt_spec button = GPIO_DT_SPEC_GET_OR(SW0_NODE, gpios, {0});
static struct gpio_callback button_cb_data;

static const struct gpio_dt_spec led0 = GPIO_DT_SPEC_GET(LED0_NODE, gpios);
static const struct gpio_dt_spec led1 = GPIO_DT_SPEC_GET(LED1_NODE, gpios);
static const struct gpio_dt_spec led2 = GPIO_DT_SPEC_GET(LED2_NODE, gpios);
static const struct gpio_dt_spec led3 = GPIO_DT_SPEC_GET(LED3_NODE, gpios);

int blink = 0;
/* ======================== */

/* Analog input to read from P0.03 */
#define ADC_NODE DT_NODELABEL(adc)
static const struct device *adc_dev = DEVICE_DT_GET(ADC_NODE);

#define ADC_RESOLUTION 10
#define ADC_CHANNEL 0
#define ADC_PORT SAADC_CH_PSELP_PSELP_AnalogInput1 // AIN0
#define ADC_REFERENCE ADC_REF_VDD_1_4			   // 0.6V
#define ADC_GAIN ADC_GAIN_1_4					   // ADC_REFERENCE*5

struct adc_channel_cfg channel_cfg = {
	.gain = ADC_GAIN,
	.reference = ADC_REFERENCE,
	.acquisition_time = ADC_ACQ_TIME_DEFAULT,
	.channel_id = ADC_CHANNEL,
#ifdef CONFIG_ADC_NRFX_SAADC
	.input_positive = ADC_PORT
#endif
};

int16_t new_sample[1];
struct adc_sequence sequence = {
	.channels = BIT(ADC_CHANNEL),
	.buffer = new_sample,
	.buffer_size = sizeof(new_sample),
	.resolution = ADC_RESOLUTION};

/* =============================== */

void button_pressed(const struct device *dev, struct gpio_callback *cb, uint32_t pins)
{
	printk("Button pressed at %" PRIu32 "\n", k_cycle_get_32());

	gpio_pin_set_dt(&led0, 0);
	gpio_pin_set_dt(&led1, 0);
	gpio_pin_set_dt(&led2, 0);
	gpio_pin_set_dt(&led3, 0);
	blink = 1;
}

void sampler_code(void *argA, void *argB, void *argC)
{
	int64_t fin_time = 0, release_time = 0;
	release_time = k_uptime_get() + SAMP_PERIOD_MS;
	int32_t last_val = 0;
	while (1)
	{
		int64_t start_time = k_uptime_get();

		/*
		new_sample += 100;
		if (new_sample >= 4000)
			new_sample = 0;

		*/

		int err = adc_read(adc_dev, &sequence);
		if (err != 0){
			return;
		}

		int32_t mv_value = new_sample[0];
		int32_t adc_vref = adc_ref_internal(adc_dev);
		adc_raw_to_millivolts(adc_vref, ADC_GAIN, ADC_RESOLUTION, &mv_value);

		fin_time = k_uptime_get();
		printk("Sampler,%lld,%lld\n", start_time, fin_time);
		k_sem_give(&sem_ab);
		if (fin_time < release_time)
		{
			k_msleep(release_time - fin_time);
			release_time += SAMP_PERIOD_MS;
		}
	}
}

void filter_code(void *argA, void *argB, void *argC)
{
	int samp[10] = {0};
	int i = 0;
	while (1)
	{
		k_sem_take(&sem_ab, K_FOREVER);
		int64_t start_time = k_uptime_get();
		samp[i++] = new_sample[0];
		int sum = 0;
		for (int k = 0; k < 10; k++){
			if (samp[k] < 0)
				samp[k] = 0;
			sum += samp[k];
		}
		filtered = (sum / 10)*3;	// For testing, was using a 10k potentiometer
		if (i == 10)
			i = 0;
		printk("Filter,%lld,%lld\n", start_time, k_uptime_get());
		k_sem_give(&sem_bc);
	}
}

void output_code(void *argA, void *argB, void *argC)
{
	while (1)
	{
		k_sem_take(&sem_bc, K_FOREVER);
		int64_t start_time = k_uptime_get();
		if (blink == 0)
		{
			if (filtered < 1000)
			{
				gpio_pin_set_dt(&led0, 1);
				gpio_pin_set_dt(&led1, 1);
				gpio_pin_set_dt(&led2, 1);
				gpio_pin_set_dt(&led3, 1);
			}
			else if (filtered < 2000)
			{
				gpio_pin_set_dt(&led0, 1);
				gpio_pin_set_dt(&led1, 1);
				gpio_pin_set_dt(&led2, 1);
				gpio_pin_set_dt(&led3, 0);
			}
			else if (filtered < 3000)
			{
				gpio_pin_set_dt(&led0, 1);
				gpio_pin_set_dt(&led1, 1);
				gpio_pin_set_dt(&led2, 0);
				gpio_pin_set_dt(&led3, 0);
			}
			else
			{
				gpio_pin_set_dt(&led0, 1);
				gpio_pin_set_dt(&led1, 0);
				gpio_pin_set_dt(&led2, 0);
				gpio_pin_set_dt(&led3, 0);
			}
		}
		printk("Output,%lld,%lld\n", start_time, k_uptime_get());
	}
}

void main(void)
{
	/* Create and init semaphores */
	k_sem_init(&sem_ab, 0, 1);
	k_sem_init(&sem_bc, 0, 1);

	/* Create tasks */
	sampler_tid = k_thread_create(&sampler_data, sampler_stack,
								  K_THREAD_STACK_SIZEOF(sampler_stack), sampler_code,
								  NULL, NULL, NULL, sampler_prio, 0, K_NO_WAIT);

	filter_tid = k_thread_create(&filter_data, filter_stack,
								 K_THREAD_STACK_SIZEOF(filter_stack), filter_code,
								 NULL, NULL, NULL, filter_prio, 0, K_NO_WAIT);

	output_tid = k_thread_create(&output_data, output_stack,
								 K_THREAD_STACK_SIZEOF(output_stack), output_code,
								 NULL, NULL, NULL, output_prio, 0, K_NO_WAIT);

	/* Device testing */
	int ret;
	if (!device_is_ready(led0.port))
	{
		return;
	}
	if (!device_is_ready(led1.port))
	{
		return;
	}
	if (!device_is_ready(led2.port))
	{
		return;
	}
	if (!device_is_ready(led3.port))
	{
		return;
	}
	if (!device_is_ready(button.port))
	{
		return;
	}
	if (!device_is_ready(adc_dev))
	{
		return;
	}

	ret = gpio_pin_configure_dt(&led0, GPIO_OUTPUT_ACTIVE);
	if (ret < 0)
	{
		return;
	}
	ret = gpio_pin_configure_dt(&led1, GPIO_OUTPUT_ACTIVE);
	if (ret < 0)
	{
		return;
	}
	ret = gpio_pin_configure_dt(&led2, GPIO_OUTPUT_ACTIVE);
	if (ret < 0)
	{
		return;
	}
	ret = gpio_pin_configure_dt(&led3, GPIO_OUTPUT_ACTIVE);
	if (ret < 0)
	{
		return;
	}
	ret = gpio_pin_configure_dt(&button, GPIO_INPUT);
	if (ret != 0)
	{
		return;
	}
	ret = gpio_pin_interrupt_configure_dt(&button, GPIO_INT_EDGE_TO_ACTIVE);
	if (ret != 0)
	{
		return;
	}
	ret = adc_channel_setup(adc_dev, &channel_cfg);
	if (ret != 0)
	{
		return;
	}

	gpio_init_callback(&button_cb_data, button_pressed, BIT(button.pin));
	gpio_add_callback(button.port, &button_cb_data);

	printk("Task, Start time, End time\n");
	while (1)
	{
		if (blink != 0 && blink < (BLINK_TIME_MS / SLEEP_TIME_MS) + 1)
		{
			printk("** Blinking **\n");
			gpio_pin_toggle_dt(&led0);
			gpio_pin_toggle_dt(&led1);
			gpio_pin_toggle_dt(&led2);
			gpio_pin_toggle_dt(&led3);
			blink++;
		}
		else
		{
			blink = 0;
		}

		k_msleep(SLEEP_TIME_MS);
	}
}
