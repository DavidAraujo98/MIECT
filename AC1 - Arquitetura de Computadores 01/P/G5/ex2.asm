	.data

str1:	.asciiz "; "
str2:	.asciiz "\nConteudo do array:\n"
lista:	.word 8, -4, 3, 5, 124, -15, 87, 9, 27, 15

	.eqv print_string, 4
	.eqv print_int10, 1
	.eqv SIZE, 40
	
	.text
	.globl main
	
main:
	la $a0, str2
	li $v0, print_string
	syscall
	
	la $t0, lista
	li $t1, SIZE
	addu $t1, $t1, $t0
	
while:
	bge $t0, $t1, end
	
	lw, $a0, 0($t0)
	li $v0, print_int10
	syscall

	la $a0, str1
	li $v0, print_string
	syscall

	addi $t0, $t0, 4

	j while		
end:
	jr $ra
