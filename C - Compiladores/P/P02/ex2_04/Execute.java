@SuppressWarnings("CheckReturnValue")
public class Execute extends PreffixCalculatorBaseVisitor<Double> {

   @Override
   public Double visitProgram(PreffixCalculatorParser.ProgramContext ctx) {
      return visitChildren(ctx);
   }

   @Override
   public Double visitStat(PreffixCalculatorParser.StatContext ctx) {
      System.out.println("Result: " + visit(ctx.expr()));
      return null;
   }

   @Override
   public Double visitExprPreffix(PreffixCalculatorParser.ExprPreffixContext ctx) {
      switch (ctx.op.getText()) {
         case "+":
            return (visit(ctx.expr(0)) + visit(ctx.expr(1)));
         case "-":
            return (visit(ctx.expr(0)) - visit(ctx.expr(1)));
         case "*":
            return (visit(ctx.expr(0)) * visit(ctx.expr(1)));
         case "/":
            return (visit(ctx.expr(0)) / visit(ctx.expr(1)));
         default:
            System.out.println("Error: bad operator");
            return null;
      }
   }

   @Override
   public Double visitExprNumber(PreffixCalculatorParser.ExprNumberContext ctx) {
      return Double.parseDouble(ctx.getText());
   }
}
