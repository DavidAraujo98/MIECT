	.data
	
	.eqv a1, 0
	.eqv i, 16
	.eqv g, 40
	
xyz:	.asciiz "Str_1"
  	.space 8
  	.align 2
  	.word 2021
  	.asciiz "Str_2"
  	.space 11
  	.align 3
  	.double 2.718281828459045
		
	.text
	.globl main
	
main:
	la $t0, xyz
	l.d $f12, g($t0)
	
	li $v0, 3
	syscall
	
	jr $ra 