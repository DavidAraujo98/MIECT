import java.util.Arrays;

public class ex1_07 {
    public static void main(String[] args) {
        Node root = new Node(args[0]);
        root = ExpressionTree(root);
        System.out.println("Result: " + root.value);
    }

    private static Node ExpressionTree(Node current) {
        String temp = (String) current.value;

        try {
            current.value = Integer.parseInt(temp);

        } catch (NumberFormatException e) {
            String[] val = String.valueOf(current.value).split(" ");

            current.left = ExpressionTree(new Node(val[1]));
            current.right = ExpressionTree(new Node(String.join(" ", Arrays.copyOfRange(val, 2, val.length))));

            switch (val[0]) {
                case "+":
                    current.value = (Integer) current.left.value + (Integer) current.right.value;
                    break;
                case "-":
                    current.value = (Integer) current.left.value - (Integer) current.right.value;
                    break;
                case "/":
                    current.value = (Integer) current.left.value / (Integer) current.right.value;
                    break;
                case "*":
                    current.value = (Integer) current.left.value * (Integer) current.right.value;
                    break;
            }
        }

        return current;
    }
}

class Node {

    Object value;
    Node right;
    Node left;

    public Node(Object value) {
        this.value = value;
        right = null;
        left = null;
    }
}
