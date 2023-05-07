	.data
	
	.text
	.globl main

main:
	ori $t0, $0, 0x5C1B
	ori $t1, $0, 0xA3E4
	
	ori $t6, $0, 0x0F1E
	
	and $t2, $t0, $t1
	or $t3, $t0, $t1
	nor $t4, $t0, $t1
	xor $t5, $t0, $t1
	
	ori $t8, $0, 0xFFFF # Mascara para inverter
	xor $t6, $t6, $t8	
	
	jr $ra