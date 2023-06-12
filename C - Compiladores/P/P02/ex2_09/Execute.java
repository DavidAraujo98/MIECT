import java.util.HashMap;

@SuppressWarnings("CheckReturnValue")
public class Execute extends CalculatorBaseVisitor<int[]> {
   HashMap<String, int[]> variables = new HashMap<String, int[]>();

   @Override
   public int[] visitProgram(CalculatorParser.ProgramContext ctx) {
      int[] res = null;
      return visitChildren(ctx);
      // return res;
   }

   @Override
   public int[] visitStatPrint(CalculatorParser.StatPrintContext ctx) {
      visit(ctx.print());
      return null;
   }

   @Override
   public int[] visitStatAssig(CalculatorParser.StatAssigContext ctx) {
      visit(ctx.assig());
      return null;
   }

   @Override
   public int[] visitPrintReduce(CalculatorParser.PrintReduceContext ctx) {
      int[] res = visit(ctx.expr());
      System.out.print(res[0]);
      if (res[1] != 1 && res[0] != 0) {
         System.out.println("/" + res[1]);
      } else {
         System.out.println();
      }
      return null;
   }

   @Override
   public int[] visitAssig(CalculatorParser.AssigContext ctx) {
      variables.put(ctx.ID().getText(), visit(ctx.expr()));
      return null;
   }

   @Override
   public int[] visitExprFrac(CalculatorParser.ExprFracContext ctx) {
      String[] ops = ctx.Frac().getText().split("/");
      return new int[] { Integer.parseInt(ops[0]), Integer.parseInt(ops[1]) };
   }

   @Override
   public int[] visitExprAddSub(CalculatorParser.ExprAddSubContext ctx) {
      int[] op1 = visit(ctx.expr(0));
      int[] op2 = visit(ctx.expr(1));

      int[] temp1 = { op1[0] * op2[1], op1[1] * op2[1] };
      int[] temp2 = { op2[0] * op1[1], op2[1] * op1[1] };
      switch (ctx.op.getText()) {
         case "+":
            int r = temp1[0] + temp2[0];
            if (r == 0)
               temp1[1] = 0;
            return new int[] { r, temp1[1] };
         case "-":
            r = temp1[0] - temp2[0];
            if (r == 0)
               temp1[1] = 0;
            return new int[] { r, temp1[1] };
         default:
            return null;
      }
   }

   @Override
   public int[] visitExprParent(CalculatorParser.ExprParentContext ctx) {
      return visit(ctx.expr());
   }

   @Override
   public int[] visitExprUnary(CalculatorParser.ExprUnaryContext ctx) {
      int[] res = visit(ctx.expr());
      if (ctx.op.getText() == "-")
         res[0] = 0 - res[0];
      return res;
   }

   @Override
   public int[] visitExprMulDivRem(CalculatorParser.ExprMulDivRemContext ctx) {
      int[] op1 = visit(ctx.expr(0));
      int[] op2 = visit(ctx.expr(1));
      switch (ctx.op.getText()) {
         case "*":
            return new int[] { op1[0] * op1[1], op1[1] * op2[1] };
         case ":":
            return new int[] { op1[0] * op2[1], op1[1] * op2[0] };
         case "%":
            // Not correctly implemented
            int rem = (op1[0] / op1[1]) % (op2[0] / op2[1]);
            return new int[] { rem, 1 };
         default:
            return null;
      }
   }

   @Override
   public int[] visitExprInteger(CalculatorParser.ExprIntegerContext ctx) {
      return new int[] { Integer.parseInt(ctx.Integer().getText()), 1 };
   }

   @Override
   public int[] visitExprReduce(CalculatorParser.ExprReduceContext ctx) {
      int[] exp = visit(ctx.expr());
      int i = exp[0];
      if (exp[1] < exp[0])
         i = exp[1];

      if (exp[0] == exp[1]) {
         return new int[] { 1, 1 };
      } else if (Math.abs(exp[0]) == Math.abs(exp[1])) {
         return new int[] { -1, 1 };
      }

      while (i > 1) {
         if ((exp[0] % i == 0) && (exp[1] % i == 0)) {
            exp[0] = exp[0] / i;
            exp[1] = exp[1] / i;
            i = exp[0];
            if (exp[1] < exp[0])
               i = exp[1];
         }
         i--;
      }

      return exp;
   }

   @Override
   public int[] visitExprId(CalculatorParser.ExprIdContext ctx) {
      return variables.get(ctx.ID().getText());
   }

   @Override
   public int[] visitExprExpo(CalculatorParser.ExprExpoContext ctx) {
      int expo = Integer.parseInt(ctx.Integer().getText());
      int[] frac = visit(ctx.expr());
      return new int[] { (int) Math.pow(frac[0], expo), (int) Math.pow(frac[1], expo) };
   }
}