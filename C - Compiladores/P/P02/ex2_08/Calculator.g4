grammar Calculator;
program: stat* EOF;
stat: expr? NEWLINE # StatExpr
    | assig? NEWLINE # StatAssig;
assig: ID '=' expr;
expr:
	op = ('!+' | '!-') expr 			# ExprUnary
	| expr op = ('*' | '/' | '%') expr	# ExprMulDivMod
	| expr op = ('+' | '-') expr	   	# ExprAddSub
	| Double							# ExprDouble
	| '(' expr ')'						# ExprParent
	| ID								# ExprId;
Double: [0-9]+ ('.' [0-9]+)?;
ID: [a-zA-Z_]+;
NEWLINE: '\r'? '\n';
WS: [ \t]+ -> skip;
COMMENT: '#' .*? '\n' -> skip;