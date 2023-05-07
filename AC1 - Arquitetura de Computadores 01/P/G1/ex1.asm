	.data
	
	.text
	.globl main
	
main:
	ori $t0, $0, 3
	ori $t1, $0, 8
	add $t0, $t0, $t0
	add $t1, $t1, $t0
	
	jr $ra
	