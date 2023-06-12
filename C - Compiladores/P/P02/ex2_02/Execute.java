import org.antlr.v4.runtime.ParserRuleContext;
import org.antlr.v4.runtime.tree.ErrorNode;
import org.antlr.v4.runtime.tree.TerminalNode;

public class Execute extends SuffixCalculatorBaseVisitor<Double> {

   @Override public Double visitProgram(SuffixCalculatorParser.ProgramContext ctx) {
      return visitChildren(ctx);
   }

   @Override public Double visitStat(SuffixCalculatorParser.StatContext ctx) {
      if(ctx.expr() != null){
         double res = visit(ctx.expr());
         System.out.println(res);
      }
      return null;
   }

   @Override public Double visitExprNumber(SuffixCalculatorParser.ExprNumberContext ctx) {
      return Double.parseDouble(ctx.Number().getText());
   }

   @Override
   public Double visitExprSuffix(SuffixCalculatorParser.ExprSuffixContext ctx) {
      switch (ctx.op.getText()) {
         case "+":
            return (visit(ctx.expr(0)) + visit(ctx.expr(1)));
         case "-":
            return (visit(ctx.expr(0)) - visit(ctx.expr(1)));
         case "*":
            return (visit(ctx.expr(0)) * visit(ctx.expr(1)));
         case "/":
            return (visit(ctx.expr(0)) / visit(ctx.expr(1)));
      }
      return null;
   }
}
