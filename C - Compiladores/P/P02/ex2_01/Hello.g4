grammar Hello;
statement: (greetings | bye)+ ;
greetings: 'hello' name ;
bye: 'bye' name ;
name: ID+ ;
ID: [a-zA-Z]+ ;
WS: [ \t\r\n]+ -> skip ;