import java.util.HashMap;

import javax.management.RuntimeErrorException;

import org.antlr.v4.runtime.ParserRuleContext;
import org.antlr.v4.runtime.tree.ErrorNode;
import org.antlr.v4.runtime.tree.TerminalNode;

@SuppressWarnings("CheckReturnValue")

public class Interpreter extends TranslatorBaseListener {
   HashMap<String, Integer> map = new HashMap<String, Integer>();

   @Override
   public void enterProgram(TranslatorParser.ProgramContext ctx) {
      ctx.stat();
   }

   @Override
   public void exitProgram(TranslatorParser.ProgramContext ctx) {
   }

   public HashMap<String, Integer> getValue() {
      return map;
   }

   @Override
   public void enterStat(TranslatorParser.StatContext ctx) {
      ctx.expr();
   }

   @Override
   public void exitStat(TranslatorParser.StatContext ctx) {
   }

   @Override
   public void enterExpr(TranslatorParser.ExprContext ctx) {
      if (!map.containsKey(ctx.T().getText())){
         map.put(ctx.T().getText(), Integer.parseInt(ctx.I().getText()));
      } else {
         throw new RuntimeErrorException(null, "Duplicate definition");
      }
   }

   @Override
   public void exitExpr(TranslatorParser.ExprContext ctx) {
   }

   @Override
   public void enterEveryRule(ParserRuleContext ctx) {
   }

   @Override
   public void exitEveryRule(ParserRuleContext ctx) {
   }

   @Override
   public void visitTerminal(TerminalNode node) {
   }

   @Override
   public void visitErrorNode(ErrorNode node) {
   }
}
