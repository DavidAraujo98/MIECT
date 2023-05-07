	.data
	
	.eqv SIZE, 32
	
val:.word 8, 4, 15, -1987, 327, -9, 27, 16
s:	.asciiz "Result is"
	
	.eqv print_int, 1
	.eqv print_char, 11
	.eqv print_string, 5
	
	.text
	.globl main
	
main:
	li $t0, 0
	la $t1, val

do:
	sll $t2, $t0, 2
	addu $t2, $t2, $t1 
	lw	$t3, 0($t2)
	
	sll $t4, $t0, 2
	addi $t4, $t4, SIZE
	sra $t4, $t4, 1
	add $t4, $t4, $t1
	lw $t5, 0($t4)
	
	sw $t5, 0($t2)
	sw $t3, 0($t4)
	
	addi $t0, $t0, 1
	sll $t3, $t0, 2
	li $t4, SIZE
	sra $t4, $t4, 1
	
	blt $t3, $t4, do
end:

	la $a0, s
	li $v0, print_string
	syscall
	
	li $t0, 0
	la $t1, val
do1:
	li $v0, print_int
	sll $t3, $t0, 2
	add $t3, $t3, $t1
	lw $a0, 0($t3)
	syscall
	
	li $v0, print_char
	li $a0, ','
	syscall
	
	addi $t0, $t0, 1
	sll $t3, $t0, 2
	blt $t3, SIZE, do1

	jr $ra