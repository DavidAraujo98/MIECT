# ANTLR4 Commands

## Compile & Run
### 1. Grammar
``` console
$ antlr4 Grammar.g4
```

### 2.a. Visitor
``` console
$ antlr4-visitor -f Grammar <visitor class name> <type>
```

### 2.b. Listener
``` console
$ antlr4-listener -f Grammar <listener class name> <type>
```

### 3. Main
``` console
$ antlr4-main -f -v <visitor class name> | -l <listener class name>
```

### 4. Build
``` console
$ antlr4-build
```

### 5. Run
``` console
$ antlr4-run < test.txt
```

<div style="page-break-after: always;"></div>

## Testing

Same first step as [Compile & Run](#1-grammar).

### 2. Compile
``` console
$ antlr4-javac Grammar*.java
```
### 3. Feeding input
``` console
$ echo "hello compilers" | antlr4-test Grammar -tokens
```
*or*
``` console
$ cat text_file.txt | antlr4-test Grammar r -tokens
```
### 4. GUI
``` console
$ antlr4-test -gui
```
*Then write the text and press **Ctrl + D***