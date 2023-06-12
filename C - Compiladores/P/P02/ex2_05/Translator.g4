grammar Translator;
program: stat* EOF;
stat: expr? NEWLINE;
expr: I ' - ' T;
I: [0-9]+;
T: [a-zA-Z]+;
NEWLINE: '\r'? '\n';
WS: [\t]+ -> skip;