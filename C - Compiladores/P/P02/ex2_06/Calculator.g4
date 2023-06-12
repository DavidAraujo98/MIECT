grammar Calculator;
program: stat* EOF;
stat:
	assignment							#StatAssig
	| expr								#StatExpr
	| NEWLINE							#StatNewLine;
assignment: ID '=' expr;
expr:
	op = ('+' | '-') expr				#ExprUnary
	| expr op=('*' | '/' | '%') expr	#ExprMulDivMod
	| expr op=('+' | '-') expr			#ExprAddSub
	| Integer							#ExprInteger
	| '(' expr ')'						#ExprParent
	| ID								#ExprID;
Integer: [0-9]+;
ID: [a-zA-Z_]+;
NEWLINE: '\r'? '\n';
WS: [ \t]+ -> skip;
COMMENT: '#' .*? '\n' -> skip;