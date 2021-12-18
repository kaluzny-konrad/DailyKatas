using System.Linq;
using System.Text.RegularExpressions;

namespace DailyKatas
{
    public class Kata
    {
        public static string EvenOrOdd(int n) => n % 2 == 0 ? "Even" : "Odd";

        public static int PositiveSum(int[] arr) => arr.Where(item => item > 0).Sum();


        public static int SquareDigits(int n)
        {
            string output = "";
            foreach (var c in n.ToString())
            {
                var square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }


        public static int SquareDigits3(int n)
        {
            var nStr = n.ToString();
            string resultStr = "";
            for (int i = 0; i < nStr.Length; i++)
            {
                var digit = nStr.Substring(i, 1);
                resultStr += Math.Pow(double.Parse(digit.ToString()), 2).ToString();
            }
            return int.Parse(resultStr);
        }

        public static int SquareDigits2(int n)
        {
            string resultStr = "";
            foreach (var digit in n.ToString().ToList())
            {
                resultStr += Math.Pow(double.Parse(digit.ToString()), 2).ToString();
            }
            return int.Parse(resultStr);
        }

        public static string Disemvowel(string str)
        {
            string vowels = "[aeiou]";
            return Regex.Replace(str, vowels, "", RegexOptions.IgnoreCase);
        }

        public static string Disemvowel2(string str)
        {
            string resultStr = "";

            foreach (var c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    resultStr += c;
                }
            }

            return resultStr;
        }

        public static string PigIt(string str)
        {
            var newStr = "";
            foreach(var word in str.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1);
                var newWord = restOfWord + firstLetter;
                newStr += " " + newWord + "ay";
            }
            newStr = newStr.Substring(1);

            return newStr;
        }

        public static string PigIt2(string str)
        {
            var newStr = "";
            foreach (var word in str.Split())
            {
                if (!"!.,';".Contains(word))
                {
                    newStr += $" {word[1..]}{word[..1]}ay";
                }
                else
                {
                    newStr += $" {word}";
                }
            }
            return newStr[1..];
        }

        public static string PigIt3(string str)
        { 
            return str;
        }

        public static string Bmi(double weight, double height)
        {
            double bmi = (weight / System.Math.Pow(height, 2));
            return bmi <= 18.5 ? "Underweight" :
                   bmi <= 25.0 ? "Normal" :
                   bmi <= 30.0 ? "Overweight" : "Obese";
        }

        public static int GetVowelCount(string str)
        {
            string vowels = "aeiou";
            int count = str.Count(c => vowels.Contains(c));
            return count;
        }

        public static int GetVowelCountKata(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }

        public static int GetVowelCountMy(string str)
        {
            int vowelCount = 0;

            foreach (var c in str.ToCharArray())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(" ").Select(word => GetSpinnedWord(word)));
        }

        private static string GetSpinnedWord(string word)
        {
            if (word.Length < 5) { return word; }
            return string.Join("", word.Reverse());
        }
    }
}
