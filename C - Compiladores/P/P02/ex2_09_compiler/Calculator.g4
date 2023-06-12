grammar Calculator;
program: stat* EOF;
stat:
	print? ';'    						#StatPrint
	| assig? ';'  						#StatAssig;
print: 'print' expr						#PrintReduce;
assig: expr '->' ID;
expr:
	op = ('+' | '-') expr 				# ExprUnary
	| <assoc=right> expr '^' Integer	# ExprExpo
	| expr op=(':' | '*' | '%') expr	# ExprMulDivRem
	| expr op=('+' | '-') expr			# ExprAddSub
	| Frac								# ExprFrac
	| Integer							# ExprInteger
	| op = 'reduce' expr				# ExprReduce
	| ID 								# ExprId
	| '(' expr ')'						# ExprParent;
Integer: [0-9]+;
Frac: Integer '/' Integer;
ID: [a-zA-Z_]+;
WS: [ \t\n]+ -> skip;
COMMENT: '#' .*? '\n' -> skip;