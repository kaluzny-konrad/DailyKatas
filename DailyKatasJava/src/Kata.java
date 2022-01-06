import java.util.Arrays;
import java.util.IntSummaryStatistics;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Kata {
    public static String highAndLow1(String numbers) {
        Integer min = Integer.MAX_VALUE;
        Integer max = Integer.MIN_VALUE;
        for (var numStr : numbers.split(" ")) {
            var num = Integer.parseInt(numStr);
            min = num < min ? num : min;
            max = num > max ? num : max;
        }

        var result = max.toString() + " " + min.toString() ;
        return result;
    }

    public static String highAndLow2(String numbers) {
        IntSummaryStatistics summary = Arrays
            .stream(numbers.split(" "))
            .collect(Collectors.summarizingInt(n -> Integer.parseInt(n)));
        return summary.getMax() + " " + summary.getMin();
    }

    public static String highAndLow(String numbers) {
        int min = getStream(numbers).min().getAsInt();
        int max = getStream(numbers).max().getAsInt();
        return max + " " + min;
    }

    private static IntStream getStream(String numbers) {
        return Arrays
                .stream(numbers.split(" "))
                .mapToInt(n -> Integer.parseInt(n));
    }
}
