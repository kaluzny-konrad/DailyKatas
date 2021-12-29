using System;
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

        public static string WhatIsTheTime(string timeInMirror)
        {
            int hoursInMirror = int.Parse(timeInMirror.Split(':')[0]);
            int minutesInMirror = int.Parse(timeInMirror.Split(':')[1]);

            int minutes = minutesInMirror > 0 ? 60 - minutesInMirror : 0;

            int hours;
            int maxHours = 12;
            if (minutesInMirror > 0)
            {
                if (hoursInMirror == maxHours)
                {
                    hours = (maxHours - 1);
                }
                else if (hoursInMirror == (maxHours - 1))
                {
                    hours = maxHours;
                }
                else
                {
                    hours = (maxHours - 1) - hoursInMirror;
                }
            }
            else
            {
                if (hoursInMirror == maxHours)
                {
                    hours = maxHours;
                }
                else
                {
                    hours = maxHours - hoursInMirror;
                }
            }

            string hoursString = hours.ToString();
            hoursString = hours < 10 ? $"0{hoursString}" : hoursString;

            string minutesString = minutes.ToString();
            minutesString = minutes < 10 ? $"0{minutesString}" : minutesString;

            return $"{hoursString}:{minutesString}";
        }

        public static string Rot13(string message)
        {
            string rotMessage = "";

            foreach (var character in message)
            {
                int c = character;
                if (c >= 97 && c <= 122)
                {
                    c += 13;
                    if (!(c >= 97 && c <= 122))
                    {
                        c -= 26;
                    }
                }
                else if (c >= 65 && c <= 90)
                {
                    c += 13;
                    if (!(c >= 65 && c <= 90))
                    {
                        c -= 26;
                    }
                }
                rotMessage += (char)c;
            }

            return rotMessage;
        }

        public static string Rot13v2(string message)
        {
            string rotMessage = "";
            foreach (var character in message)
            {
                int c = character;
                if (IsLowerCase(c))
                {
                    c = GetRotedCase(c);
                    c = IsLowerCase(c) ? c : GetRestoredCaps(c);
                }
                if (IsUpperCase(c))
                {
                    c = GetRotedCase(c);
                    c = IsUpperCase(c) ? c : GetRestoredCaps(c);
                }
                rotMessage += (char)c;
            }
            return rotMessage;
        }

        private static bool IsLowerCase(int c) => (c >= 97 && c <= 122);
        private static bool IsUpperCase(int c) => (c >= 65 && c <= 90);
        private static int GetRotedCase(int c) => c + 13;
        private static int GetRestoredCaps(int c) => c - 26;

        public static int DigPow(int n, int p)
        {
            var sum = 0;
            foreach (var d in n.ToString())
            {
                int digit = int.Parse(d.ToString());
                sum += (int)Math.Pow(digit, p);
                p++;
            }

            return sum % n == 0 ? sum / n : -1;
        }

        public static int DigPow2(int n, int p)
        {
            var sum = 0;
            foreach (var d in n.ToString())
            {
                int digit = int.Parse(d.ToString());
                int pow = (int)Math.Pow(digit, p);
                sum += pow;
                p++;
            }

            if (sum % n == 0)
            {
                return sum / n;
            }
            else
            {
                return -1;
            }
        }

        public static string[] TowerBuilder(int nFloors)
        {
            var result = new string[nFloors];
            for (var nFloor = 0; nFloor < nFloors; nFloor++)
            {
                result[nFloor] = (GetFloorRow(nFloors, nFloor));
            }
            return result;
        }

        private static string GetFloorRow(int nFloors, int nFloor)
        {
            var signsInRow = (nFloor * 2) + 1;
            var halfOfSpacesInRow = nFloors - nFloor - 1;
            var row = new string(' ', halfOfSpacesInRow);
            row += new string('*', signsInRow);
            row += new string(' ', halfOfSpacesInRow);
            return row;
        }

        public static string[] TowerBuilder2(int nFloors)
        {
            var result = new List<string>();
            for (var nFloor = 0; nFloor < nFloors; nFloor++)
            {
                result.Add(GetFloorRow(nFloors, nFloor));
            }
            return result.ToArray();
        }

        public static string UInt32ToIP(uint ip)
        {
            var ipString = ip.ToString();
            var ipParsed = System.Net.IPAddress.Parse(ipString);
            return ipParsed.ToString();
        }

        public static string UInt32ToIP2(uint ip)
        {
            string[] octets = new string[4];
            for (uint i = 0; i < 4; i++)
            {
                uint pow = (uint)Math.Pow(256, 3 - i);
                octets[i] = (ip / pow).ToString();
                ip %= pow;
            }
            return string.Join(".", octets);
        }

        public static uint IPToUInt32(string ip)
        {
            var splitedIp = ip.Split(".");
            int numOfOctets = 4;
            uint sum = 0;
            for (uint i = 0; i < numOfOctets; i++)
            {
                uint octet = uint.Parse(splitedIp[i]);
                uint pow = (uint)Math.Pow(256, numOfOctets - i - 1);
                sum += octet * pow;
            }

            return sum;
        }

        public static string SumStrings(string a, string b)
        {
            ulong result = GetNum(a) + GetNum(b);
            return result.ToString();
        }

        private static ulong GetNum(string number)
        {
            try
            {
                return ulong.Parse(number);
            }
            catch (System.FormatException)
            {
                return 0;
            }
            catch (System.OverflowException)
            {
                return 0;
            }
        }

        public static long NextSmaller(long n)
        {
            for (var i = n - 1; i >= 0; i--)
            {
                if (GetSortedString(i) == GetSortedString(n))
                {
                    return i;
                }
            }
            return -1;
        }

        private static string GetSortedString(long i)
        {
            char[] iCharacters = i.ToString().ToArray();
            Array.Sort(iCharacters);
            return new string(iCharacters);
        }
    }
}
