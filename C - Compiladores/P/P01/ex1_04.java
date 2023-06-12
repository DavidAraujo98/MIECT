import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class ex1_04 {
    public static void main(String[] args) throws FileNotFoundException {
        HashMap<String, Integer> map = load("bloco1/numbers.txt");
        for (String x : args[0].split("\\s")) {
            if (x.contains("-")) {
                String[] y = x.split("-");
                for (String w : y) {
                    if (map.containsKey(w)) {
                        System.out.print(map.get(w) + " ");
                    } else {
                        System.out.print(w + " ");
                    }
                }
            } else {
                if (map.containsKey(x)) {
                    System.out.print(map.get(x) + " ");
                } else {
                    System.out.print(x + " ");
                }
            }
        }
        System.out.println();
    }

    private static HashMap<String, Integer> load(String x) throws FileNotFoundException {
        File file = new File(x);
        Scanner sf = new Scanner(file);
        HashMap<String, Integer> map = new HashMap<String, Integer>();
        while (sf.hasNextLine()) {
            String pair = sf.nextLine();
            String key = (pair.split("-")[1]).trim();
            int value = Integer.parseInt((pair.split("-")[0]).trim());
            map.put(key, value);
        }
        sf.close();
        return map;
    }
}
