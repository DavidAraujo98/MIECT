#include <detpic32.h>

unsigned int voltage = 0;

void delay(int ms) {
	for(; ms > 0; ms--) {
		resetCoreTimer();
		while(readCoreTimer() < 20000);
	}
}

void send2displays(unsigned char value){
	static int dis = 0;
	int display7Scodes[] = {0x3F, 0x06, 0x5B, 0x4F, 0x66, 0x6D, 0x7D, 0x07, 0x7F, 0x6F, 0x77, 0x7C, 0x39, 0x5E, 0x79, 0x71};
	
	value = ((value / 10) << 4) + (value % 10);
	
	int dh = value >> 4;
	int dl = value & 0x0F;
	
	if(dis == 0){
		LATDbits.LATD6 = 0;
		LATDbits.LATD5 = 1;	// display low active
		LATB = (0x80FF & LATB) | (display7Scodes[dl] << 8);
		dis = 1;
	}else{
		LATDbits.LATD6 = 1;	// display high active
		LATDbits.LATD5 = 0;
		LATB = (0x80FF & LATB) | (display7Scodes[dh] << 8);
		dis = 0;
	}
}

// Interrupction Handler
void _int_(27) isr_adc(void){

    // calculate buffer average
    int* p = (int*) (&ADC1BUF0);

    int sum = 0;
    int i;
    for(i = 0; i < 8; i++){
        sum += p[i*4];
    }

    int med_voltage; // = sum/8;

    med_voltage = ADC1BUF0;

    voltage = (med_voltage*33 + 511) / 1023;
    
    IFS1bits.AD1IF = 0;             // clear/reset A/D interrupt flag   

}


int main(void){
    // Configure the A/D module and port RB4 as analog input // potenciometro
    TRISBbits.TRISB4 = 1;           // RB4 digital output disconnected
    AD1PCFGbits.PCFG4 = 0;          // RB4 configured as analog input (AN4)
    AD1CON1bits.SSRC = 7;           

    AD1CON1bits.CLRASAM = 1;

    AD1CON3bits.SAMC = 16;
    AD1CON2bits.SMPI = 7;           // 8 amostras consecutivas

    AD1CHSbits.CH0SA = 4;

    AD1CON1bits.ON = 1;             // Enable A/D converter

    // Configure interrupt system
    IPC6bits.AD1IP = 2;             // configure priority of A/D interrupts to 2

    IEC1bits.AD1IE = 1;             // enable A/D interrupts

    // Configure display
    TRISB = TRISB & 0x00FF;                     // configure RB8-RB14 as outputs         
    TRISD = TRISD & 0xFF9F;                 // configure RD5-RD6 as outputs

    IFS1bits.AD1IF = 0;                 // clear/reset A/D interrupt flag

    EnableInterrupts();

    int i = 0;

    while(1){ 
        delay(10);                  // refresh time = 10ms (100Hz)

        if(i++ >= 25){
            i = 0;

            // start A/C conversion
            AD1CON1bits.ASAM = 1;

        }
        printInt((int) voltage , 10);
        putChar('\n');
        send2displays(voltage);
    }
    
    return 0;
}
