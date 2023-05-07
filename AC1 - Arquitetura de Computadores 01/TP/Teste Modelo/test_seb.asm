	.data
	
a:	.space 140
b:	.space 140
	.eqv N, 140
	.eqv read_int, 5
	.eqv print_int, 1

	.text
	.globl main
	
main:
	li $t0, 0
	li $t1, 0
	
	la $t2, a
	li $t3, N
	addu $t3, $t3, $t2
	
for:
	bge $t2, $t3, end
	
	li $v0, read_int
	syscall
	
	sw $v0, 0($t2)
	
	addiu $t2, $t2, 4
	
	j for

end: 
	la $t2, a
	la $t4, b
	
for1:
	bge $t2, $t3, end1

	lw	$t5, 0($t2)
	
	rem $t6, $t5, 2

if:	beqz $t6, nif
	sw $t5, 0($t4)
	addiu $t4,$t4, 4
	addi $t1, $t1, 1
	
	j endif
nif:
	addi $t0, $t0, 1
endif:	
	addiu $t2, $t2, 4
	j for1	
end1:

	la $t4, b
	sll $t1, $t1, 2
	addu $t5, $t4, $t1
for3:
	bge $t4, $t5, end3
	
	li $v0, print_int
	lw $a0, 0($t4) 
	syscall
	
	li $v0, 11
	li $a0, ','
	syscall

	addiu $t4, $t4, 4
	
	j for3
end3:
	jr $ra
	
