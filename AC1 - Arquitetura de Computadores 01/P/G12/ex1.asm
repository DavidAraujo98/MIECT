	.data
	
	.eqv	id, 0
	.eqv	fn, 4
	.eqv	ln, 22
	.eqv	g, 40
	.eqv	MAX, 4
	
idi:	.asciiz "ID: "
fni:	.asciiz "First Name: "
lni:	.asciiz "Last Name: "
gi:	.asciiz "Grade: "
md:	.asciiz "\nMedia: "
	
stda:	.space	176	
	
	.text
	.globl main
	
main:	
	addiu $sp, $sp, -4
	sw $ra, 0($sp)
	
	la $a0, stda
	li $a1, MAX
	jal rd 
	
	lw $ra, 0($sp)
	addiu $sp, $sp, 4
	
	la $a0, md
	li $v0, 4
	syscall
	
	mov.s	$f12, $f0
	li	$v0, 2
	syscall
	
	jr $ra

rd:	
	move $t0, $a0
	move $t1, $a1
	li $t2, 0
	li $t4, 44
for:	
        bge $t2, $t1, end
        
	la $a0, idi
	li $v0, 4
	syscall
	li $v0, 5
	syscall
	sw $v0, id($t0)
	
	la $a0, fni
	li $v0, 4
	syscall
	li $a0, fn
	addu $a0, $t0, $a0
	li $a1, 18
	li $v0, 8
	syscall
	
	la $a0, lni
	li $v0, 4
	syscall
	li $a0, ln
	addu $a0, $t0, $a0
	li $a1, 15
	li $v0, 8
	syscall
	
	la $a0, gi
	li $v0, 4
	syscall
	li $v0, 6
	syscall
	s.s $f0, g($t0)
	
	addiu $t0, $t0, 44
	addiu $t2, $t2, 1
	j for
end:	
	jr $ra