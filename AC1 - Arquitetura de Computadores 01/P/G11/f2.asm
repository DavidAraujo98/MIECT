	.data
	
	.eqv a1, 0
	.eqv g, 16
	.eqv a2, 24
	.eqv v, 32
	.eqv k, 36
	
uvw:	.asciiz "St1"
	.space 6
	.align 3
	.double 3.141592653589
	.word 291, 756
	.byte 'X'
	.align 2
	.float 1.983
		
	.text
	.globl main
	
main:
	la	$t0, uvw
	
	l.d	$f4, g($t0)
	
	addi	$t1, $t0, a2
	lw	$t1, 4($t1)
	
	mtc1	$t1, $f8
	cvt.d.w	$f8, $f8
	
	mul.d	$f4, $f4, $f8
	
	l.s	$f8, k($t0)
	cvt.d.s	$f8, $f8
	
	div.d	$f12, $f4, $f8
	
	li	$v0, 3
	syscall
	
	jr	$ra