using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DailyKatas
{
    public class Parser
    {
        public static int ParseInt(string s)
        {
            char[] separators = { ' ', '-' };
            var result = 0;
            foreach (var number in s.Split(separators))
            {
                result += GetParsedNumber(number);
                if (number == "hundred")
                {
                    result *= 100;
                }
                else if (number == "thousand")
                {
                    result *= 1000;
                }
                else if (number == "milion")
                {
                    result *= 1000000;
                }
            }

            return result;
        }

        private static int GetParsedNumber(string num)
        {
            return num switch
            {
                "zero" => 0,
                "one" => 1,
                "two" => 2,
                "three" => 3,
                "four" => 4,
                "five" => 5,
                "six" => 6,
                "seven" => 7,
                "eight" => 8,
                "nine" => 9,
                "ten" => 10,
                "eleven" => 11,
                "twelve" => 12,
                "thirteen" => 13,
                "fourteen" => 14,
                "fifteen" => 15,
                "sixteen" => 16,
                "seventeen" => 17,
                "eighteen" => 18,
                "nineteen" => 19,
                "twenty" => 20,
                "thirty" => 30,
                "forty" => 40,
                "fifty" => 50,
                "sixty" => 60,
                "seventy" => 70,
                "eighty" => 80,
                "ninety" => 90,
                _ => 0,
            };
        }

    }
}
