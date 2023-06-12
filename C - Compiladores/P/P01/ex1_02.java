import java.util.HashMap;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ex1_02 {
    static HashMap<String, Object> map = new HashMap<String, Object>();
    static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) {
        while (true) {
            try {
                System.out.print("$ ");
                String n = sc.nextLine();
                n.replaceAll("\\s+", "");
                interpreter(n);
            } catch (Exception e) {
                System.err.println(e);
            }
        }
    }

    private static Object interpreter(String n) {
        Object val = 0;
        int op1 = 0, op2 = 0;
        char opr = ' ';

        try {
            if (n.matches("^[a-zA-Z]+\\d*\\s*[+/*-]{1}\\s*\\d*")) { // Operation type: variable <operator> integer
                int i = indexOfRegEx(n, "[+/*-]");
                op1 = (int) map.get(n.substring(0, i).trim());
                op2 = Integer.parseInt(n.substring(i + 1).trim());
                opr = n.charAt(i);
                val = operate(op1, op2, opr);
                map.put(n.substring(0, i - 1).trim(), val);

            } else if (n.matches("^\\d+\\s*[+/*-]{1}[\\sa-zA-Z]+\\d*")) { // Operation type: integer <operator> variable
                int i = indexOfRegEx(n, "[+/*-]");
                op1 = Integer.parseInt(n.substring(0, i).trim());
                opr = n.charAt(i);
                op2 = (int) map.get(n.substring(i + 1).trim());
                val = operate(op1, op2, opr);
                map.put(n.substring(i + 1).trim(), val);

            } else if (n.matches("^[a-zA-Z\\s]+\\d*[+/*-][a-zA-Z\\s]+\\d*")) { // Operation type: variable <operator> variable
                int i = indexOfRegEx(n, "[+/*-]");
                op1 = (int) map.get(n.substring(0, i).trim());
                opr = n.charAt(i);
                op2 = (int) map.get(n.substring(i + 1).trim());
                val = operate(op1, op2, opr);

            } else if (n.matches("^[a-zA-Z\\s]+[=]{1}.+")) { // Attribution
                int i = n.indexOf("=");
                String ni = n.substring(i + 1).trim();
                if (ni.matches("\\d*")) {
                    val = Integer.parseInt(n.substring(i + 1).trim());
                } else {
                    val = interpreter(ni);
                }
                map.put(n.split("=")[0].trim(), val);
                return 0;
            } else if (n.matches("^[a-zA-Z\\s]*")) {
                System.out.println(map.get(n));
            } else {
                System.err.println("Invalid format");
                System.exit(0);
            }
        } catch (NullPointerException e) {
            System.err.println("Undefined variable");
        }

        return val;
    }

    private static int operate(int op1, int op2, char opr) {
        int val = 0;
        switch (opr) {
            case '*':
                val = op1 * op2;
                break;
            case '/':
                val = op1 / op2;
                break;
            case '+':
                val = op1 + op2;
                break;
            case '-':
                val = op1 - op2;
        }
        return val;
    }

    private static int indexOfRegEx(String strSource, String strRegExPattern) {
        int idx = -1;
        Pattern p = Pattern.compile(strRegExPattern);
        Matcher m = p.matcher(strSource);
        if (m.find()) {
            idx = m.start();
        }
        return idx;
    }

}
