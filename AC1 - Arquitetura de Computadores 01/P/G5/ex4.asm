	.data
	
	.eqv SIZE, 40 
	.eqv read_int, 5
	.eqv print_string, 4
	
lista:	.space SIZE
str:	.asciiz "\nIntroduz um número: "

	.text
	.globl main
	
main:
	
	la $t0, lista
	addi $t1, $t0, SIZE
	sub $t1, $t1, 1
				
do:
	la $a0, str
	li $v0, print_string
	syscall
	
	li $v0, read_int
	syscall
	
	sw $v0, 0($t0)
	addi $t0, $t0, 4
	
	blt $t0,$t1,do
	
do1:
	li $t2, 0
	la	$t0, lista
for:
	bge $t0, $t1, end1
	
	lw	$t3, 0($t0)
	lw	$t4, 4($t0)
	
	ble $t3, $t4, inf
	sw	$t4, 0($t0)
	sw	$t3, 4($t0)
	li $t2, 1
inf:		
	addi $t0, $t0, 4
	j for
end1:
	beq $t2, 1, do1 
	
	la $t0, lista
do2:	
	lw $a0, 0($t0)
	li	$v0, 1
	syscall
	
	addi $t0, $t0, 4
	blt $t0,$t1,do2
	
	jr $ra