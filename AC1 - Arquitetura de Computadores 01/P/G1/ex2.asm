	.data
	
	.text
	.globl main
	
main:
	ori $t0, $0, 3
	ori $t1, $0, 8
	add $t0, $t0, $t0
	sub $t1, $t0, $t1
	
	jr $ra
	