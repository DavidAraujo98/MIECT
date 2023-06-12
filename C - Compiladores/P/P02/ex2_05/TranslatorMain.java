import java.io.File;
import java.io.IOException;
import java.util.HashMap;
import java.util.Scanner;

import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.tree.*;

public class TranslatorMain {

   public static void main(String[] args) throws IOException {
      HashMap<String, Integer> map = read();
      Scanner sc = new Scanner(System.in);
      while (true) {
         String s = sc.nextLine();
         String[] a = s.split(" ");
         for (String x : a) {
            if (x.matches("^[a-zA-Z]*")) {
               System.out.print(map.get(x) + "\s");
            } else {
               String[] y = x.split("-");
               for (String w : y) {
                  System.out.print(map.get(w) + "\s");
               }
            }
         }
         System.out.println();
      }
   }

   public static HashMap<String, Integer> read() throws IOException{
      try {
         TranslatorParser parser = new TranslatorParser(null);
         ParseTreeWalker walker = new ParseTreeWalker();
         Interpreter listener0 = new Interpreter();

         Scanner sc = new Scanner(new File("numbers.txt"));
         int numLine = 1;
         while (sc.hasNextLine()) {
            String lineText = sc.nextLine();

            CharStream input = CharStreams.fromString(lineText + "\n");
            // create a lexer that feeds off of input CharStream:
            TranslatorLexer lexer = new TranslatorLexer(input);
            lexer.setLine(numLine);
            lexer.setCharPositionInLine(0);
            // create a buffer of tokens pulled from the lexer:
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            // create a parser that feeds off the tokens buffer:
            parser.setInputStream(tokens);
            // begin parsing at program rule:
            ParseTree tree = parser.program();
            if (parser.getNumberOfSyntaxErrors() == 0) {
               // print LISP-style tree:
               // System.out.println(tree.toStringTree(parser));
               walker.walk(listener0, tree);
            }
            numLine++;
         }
         sc.close();
         return listener0.getValue();
      } catch (RecognitionException e) {
         e.printStackTrace();
         System.exit(1);
      }
      return null;
   }
}
