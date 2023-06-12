import java.util.*;

public class ex1_01 {

    static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) {
        try {
            double opi = 0.0;
            double opf = 0.0;
            char opr = ' ';

            String line = "";
            while (true){
                String nl = sc.nextLine();
                nl = nl.trim().concat(" ");
                line = line.concat(nl);
                String[] ll = line.split("\\s+");
                if (ll.length >= 3) {
                    opi = Double.parseDouble(ll[0]);
                    opr = ll[1].toCharArray()[0];
                    opf = Double.parseDouble(ll[2]);
                    break;
                }
            }
        
            double r = 0.0;

            switch (opr) {
                case '/':
                    r = opi / opf;
                    break;
                case '*':
                    r = opi * opf;
                    break;
                case '+':
                    r = opi + opf;
                    break;
                case '-':
                    r = opi - opf;
                    break;
            }

            System.out.println(r);
        } catch (Exception e) {
            System.err.println(e);
        }

    }

}
