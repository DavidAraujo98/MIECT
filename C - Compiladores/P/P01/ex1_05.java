import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class ex1_05 {
    public static void main(String[] args) throws FileNotFoundException {
        HashMap<String, Integer> map = load("bloco1/numbers.txt");
        String text = "";
        String numbers = "";
        for (String x : args[0].split("\\s")) {
            if (x.contains("-")) {
                String[] y = x.split("-");
                for (String w : y) {
                    if (map.containsKey(w)) {
                        numbers = numbers.concat(map.get(w) + " ");
                    } else {
                        System.out.print(w + " ");
                        text = text.concat(w + " ");
                    }
                }
            } else {
                if (map.containsKey(x)) {
                    numbers = numbers.concat(map.get(x) + " ");
                } else {
                    text = text.concat(x + " ");
                }
            }
        }

        String[] nums = numbers.split(" ");
        int total = 0;
        int temp = Integer.parseInt(nums[0]);
        for (int i = 0; i < nums.length - 1; i++) {
            int a = Integer.parseInt(nums[i]);
            int b = Integer.parseInt(nums[i + 1]);

            if (a < b) {
                temp *= b;
            } else {
                total += temp;
                temp = b;
                if (i == nums.length - 2) {
                    total += Integer.parseInt(nums[i + 1]);
                }
            }
        }

        System.out.println(text + String.valueOf(total));
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