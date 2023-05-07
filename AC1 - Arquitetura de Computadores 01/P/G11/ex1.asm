	.data
	
stu:	.word 72343
	.asciiz "Napoleao"
	.space 9
	.asciiz "Bonaparte"
	.space 5
	.align 2
	.double 5.1
	
st1:	.asciiz "Nº Mec: "
st2:	.asciiz "First Name: "
st3:	.asciiz "Last Name: "
	
	.text
	.globl main
	
main:
	la $t0, stu
	
	li $v0, 4
	la $a0, st1
	syscall
	
	li $v0, 1
	lw $a0, 0($t0)
	syscall
	
	li $v0, 4
	la $a0, st2
	syscall
	
	jr $ra
