import java.util.HashMap;

@SuppressWarnings("CheckReturnValue")
public class Execute extends CalculatorBaseVisitor<String> {
   HashMap<String, String> variables = new HashMap<String, String>();

   @Override public String visitProgram(CalculatorParser.ProgramContext ctx) {
      String res = null;
      return visitChildren(ctx);
   }

   @Override public String visitStatExpr(CalculatorParser.StatExprContext ctx) {
      System.out.println(visit(ctx.expr()));
      return null;
   }

   @Override public String visitStatAssig(CalculatorParser.StatAssigContext ctx) {
      System.out.println(visit(ctx.assig()));
      return null;
   }

   @Override public String visitAssig(CalculatorParser.AssigContext ctx) {
      String v = visit(ctx.expr());
      String var = ctx.ID().getText();
      variables.put(var, v);
      return var + " = " + v;
   }

   @Override public String visitExprMulDivMod(CalculatorParser.ExprMulDivModContext ctx) {
      return visit(ctx.expr(0)) + " " + visit(ctx.expr(1)) + " " + ctx.op.getText();
   }

   @Override public String visitExprAddSub(CalculatorParser.ExprAddSubContext ctx) {
      return visit(ctx.expr(0)) + " " + visit(ctx.expr(1)) + " " + ctx.op.getText();
   }

   @Override public String visitExprDouble(CalculatorParser.ExprDoubleContext ctx) {
      return ctx.Double().getText();
   }

   @Override public String visitExprParent(CalculatorParser.ExprParentContext ctx) {
      return visit(ctx.expr());
   }

   @Override public String visitExprUnary(CalculatorParser.ExprUnaryContext ctx) {
      return visit(ctx.expr()) + " " + ctx.op.getText();
   }

   @Override public String visitExprId(CalculatorParser.ExprIdContext ctx) {
      return variables.get(ctx.ID().getText());
   }
}
