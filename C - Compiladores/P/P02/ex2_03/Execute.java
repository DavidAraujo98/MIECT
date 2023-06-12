import org.antlr.v4.runtime.ParserRuleContext;
import org.antlr.v4.runtime.tree.ErrorNode;
import org.antlr.v4.runtime.tree.TerminalNode;

public class Execute extends CalculatorBaseVisitor<Double> {

   @Override public Double visitProgram(CalculatorParser.ProgramContext ctx) {
      Double res = null;
      return visitChildren(ctx);
   }

   @Override public Double visitStat(CalculatorParser.StatContext ctx) {
      Double res = null;
      if (ctx.expr() != null) {
         System.out.println(visit(ctx.expr()));
      }
      return res;
   }

   @Override public Double visitExprMulDivMod(CalculatorParser.ExprMulDivModContext ctx) {
      Double res = null;
      switch (ctx.op.getText()) {
         case "*":
            return (visit(ctx.expr(0)) * visit(ctx.expr(1)));
         case "/":
            return (visit(ctx.expr(0)) * visit(ctx.expr(1)));
         case "%":
            return (visit(ctx.expr(0)) * visit(ctx.expr(1)));
      }
      return res;
   }

   @Override public Double visitExprAddSub(CalculatorParser.ExprAddSubContext ctx) {
      Double res = null;
      switch (ctx.op.getText()) {
         case "+":
            return (visit(ctx.expr(0)) + visit(ctx.expr(1)));
         case "-":
            return (visit(ctx.expr(0)) - visit(ctx.expr(1)));
      }
      return res;
   }

   @Override public Double visitExprParent(CalculatorParser.ExprParentContext ctx) {
      return visit(ctx.expr());
   }

   @Override public Double visitExprInteger(CalculatorParser.ExprIntegerContext ctx) {
      return Double.parseDouble(ctx.Integer().getText());
   }
}
