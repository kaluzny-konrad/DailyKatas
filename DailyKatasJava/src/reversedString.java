public class reversedString {
    public static String solution(String str) {
        var input = new StringBuilder(str);
        input.reverse();
        return input.toString();
    }
}
