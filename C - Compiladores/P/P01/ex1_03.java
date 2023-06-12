import java.util.Stack;

public class ex1_03 {
    public static void main(String[] args) {
        Stack<String> sp = new Stack<String>();
        for (String x : args) {
            if (x.matches("[*+/%-]")) {
                double op2 = Double.valueOf(sp.pop());
                double op1 = Double.valueOf(sp.pop());
                sp.push(String.valueOf(operate(op1, op2, x)));
            } else {
                sp.push(x);
            }
            System.out.println("Stack: " + sp);
        }
    }

    private static double operate(double op1, double op2, String opr) {
        switch (opr) {
            case "+":
                return op1 + op2;
            case "-":
                return op1 - op2;
            case "*":
                return op1 * op2;
            case "/":
                return op1 / op2;
            case "%":
                return op1 % op2;
        }
        return 0.0;
    }
}
