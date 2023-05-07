	.data
	
	.eqv a1,	0
	.eqv i,		16
	.eqv a2,	20
	.eqv g,		40
	.eqv print_d,	3	
	
st:	.asciiz	"Str_1"
	.space	10
	.word	2021
	.asciiz	"Str_2"
	.space	11
	.align	3
	.double 2.718281828459045

	
	.text
	.globl f1
	
f1:
	la	$t0, st
	l.d	$f12, g($t0)
	li	$v0, print_d
	syscall
		