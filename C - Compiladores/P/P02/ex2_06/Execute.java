import org.antlr.v4.runtime.ParserRuleContext;
import org.antlr.v4.runtime.tree.ErrorNode;
import org.antlr.v4.runtime.tree.TerminalNode;
import java.util.HashMap;

public class Execute extends CalculatorBaseVisitor<Double> {
   HashMap<String, Double> variables = new HashMap<String, Double>();

   @Override public Double visitProgram(CalculatorParser.ProgramContext ctx) {
      Double res = null;
      return visitChildren(ctx);
   }

   @Override public Double visitStatAssig(CalculatorParser.StatAssigContext ctx) {
      System.out.print("Variable ");
      visit(ctx.assignment());
      return null;
   }

   @Override public Double visitStatExpr(CalculatorParser.StatExprContext ctx) {
      System.out.println("Value: " + visit(ctx.expr()));
      return null;
   }

   @Override public Double visitStatNewLine(CalculatorParser.StatNewLineContext ctx) {
      return null;
   }

   @Override public Double visitAssignment(CalculatorParser.AssignmentContext ctx) {
      Double value = visit(ctx.expr());
      System.out.println(ctx.ID().getText() + " value " + value);
      variables.put(ctx.ID().getText(), value);
      return null;
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

   @Override public Double visitExprUnary(CalculatorParser.ExprUnaryContext ctx) {
      Double res = visit(ctx.expr());

      if (ctx.op.getText() == "-")
         res = 0 - res;

      return res;
   }

   @Override public Double visitExprInteger(CalculatorParser.ExprIntegerContext ctx) {
      return Double.parseDouble(ctx.Integer().getText());
   }

   @Override public Double visitExprID(CalculatorParser.ExprIDContext ctx) {
      return variables.get(ctx.ID().getText());
   }
}
