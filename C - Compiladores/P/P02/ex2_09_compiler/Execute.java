import org.stringtemplate.v4.*;

@SuppressWarnings("CheckReturnValue")
public class Execute extends CalculatorBaseVisitor<ST> {
   STGroup stg = new STGroupFile("template.stg");

   @Override
   public ST visitProgram(CalculatorParser.ProgramContext ctx) {
      // FIXME - temp stays as null
      ST temp = stg.getInstanceOf("module");
      String[] statements = new String[ctx.stat().size()];
      for (int i = 0; i < ctx.stat().size(); i++) {
         statements[i] = visit(ctx.stat().get(i)).render();
      }+
      temp.add("stat", statements);
      System.out.println(temp.render());
      return null;
   }

   @Override
   public ST visitStatPrint(CalculatorParser.StatPrintContext ctx) {
      return visit(ctx.print());
   }

   @Override
   public ST visitStatAssig(CalculatorParser.StatAssigContext ctx) {
      return visit(ctx.assig());
   }

   @Override
   public ST visitPrintReduce(CalculatorParser.PrintReduceContext ctx) {
      ST temp = new ST("print(<expr>);");
      temp.add("expr", visit(ctx.expr()));
      return temp;
   }

   @Override
   public ST visitAssig(CalculatorParser.AssigContext ctx) {
      // variables.put(ctx.ID().getText(), visit(ctx.expr()));
      ST temp = new ST("int[] var_<ID> = <expr>;");
      temp.add("ID", ctx.ID().getText());
      temp.add("expr", visit(ctx.expr()));
      return temp;
   }

   @Override
   public ST visitExprFrac(CalculatorParser.ExprFracContext ctx) {
      ST temp = new ST("new int[] { Integer.parseInt('<expr>'.split('/')[0]), Integer.parseInt('<expr>'.split('/')[1]) }");
      temp.add("expr", ctx.Frac().getText());
      return temp;
   }

   @Override
   public ST visitExprAddSub(CalculatorParser.ExprAddSubContext ctx) {
      ST temp = new ST("addSub(<expr1>, '<op>', <expr2>)");
      temp.add("expr1", visit(ctx.expr(0)));
      temp.add("expr2", visit(ctx.expr(1)));
      temp.add("op", ctx.op.getText());
      return temp;
   }

   @Override
   public ST visitExprParent(CalculatorParser.ExprParentContext ctx) {
      return visit(ctx.expr());
   }

   @Override
   public ST visitExprUnary(CalculatorParser.ExprUnaryContext ctx) {
      ST temp = new ST("new int { <op><expr>[0], <expr>[1]}");
      temp.add("op", ctx.op.getText());
      temp.add("expr", visit(ctx.expr()));
      return temp;
   }

   @Override
   public ST visitExprMulDivRem(CalculatorParser.ExprMulDivRemContext ctx) {
      ST temp = new ST("mulDivRem(<expr1>, '<op>', <expr2>)");
      temp.add("expr1", visit(ctx.expr(0)));
      temp.add("expr2", visit(ctx.expr(1)));
      temp.add("op", ctx.op.getText());
      return temp;
   }

   @Override
   public ST visitExprInteger(CalculatorParser.ExprIntegerContext ctx) {
      ST temp = new ST("new int[] { <int>, 1 }");
      temp.add("int", ctx.Integer().getText());
      return temp;
   }

   @Override
   public ST visitExprReduce(CalculatorParser.ExprReduceContext ctx) {
      ST temp = new ST("reduce(<exp>)");
      temp.add("exp", visit(ctx.expr()));
      return temp;
   }

   @Override
   public ST visitExprId(CalculatorParser.ExprIdContext ctx) {
      ST temp = new ST("<ID>");
      temp.add("ID", ctx.ID().getText());
      return temp;
   }

   @Override
   public ST visitExprExpo(CalculatorParser.ExprExpoContext ctx) {
      ST temp = new ST("new int[] {Math.pow(<expr>[0], <expo>), Math.pow(<expr>[1], <expo>)}");
      temp.add("expr", visit(ctx.expr()));
      temp.add("expo", ctx.Integer().getText());
      return temp;
   }
}