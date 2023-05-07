	.data
	
	.eqv read_int, 5
	.eqv print_int, 1
	.eqv print_int16, 34
	.eqv print_intu16, 36
	
	.text
	.globl main
	
main: 
	li $v0, read_int
	syscall
	or $t0, $0, $v0
	
	ori $t1, $0, 8
	add $t0, $t0, $t0
	sub $t1, $t0, $t1
	
	or $a0, $0, $t1
	li $v0, print_int
	syscall
	
	li $v0, print_int16
	syscall
	
	li $v0, print_intu16
	syscall
	
	jr $ra
	