CC =  gcc # Set the compiler
L_FLAGS = -lrt -lpthread -lm
#C_FLAGS = -g

all: A1 A2 A3
.PHONY: all

# Project compilation
A1: A1.c
	$(CC) $< -o $@ $(C_FLAGS) $(L_FLAGS)

A2: A2.c
	$(CC) $< -o $@ $(C_FLAGS) $(L_FLAGS)

A3: A3.c
	$(CC) $< -o $@ $(C_FLAGS) $(L_FLAGS)

	
.PHONY: clean 

clean:
	rm -f *.c~ 
	rm -f *.o
	rm A1 A2 A3

# Some notes
# $@ represents the left side of the ":"
# $^ represents the right side of the ":"
# $< represents the first item in the dependency list   