using System;
using System.Collections.Generic;

namespace CryptoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numBaseTwentySix = Console.ReadLine();
            var sign = Console.ReadLine();
            var numBaseSeven = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < 26; i++)
            {
                var charToAdd = (char)('a' + i);
                dict.Add(charToAdd, i);
            }

            var firstNum = GetFirstNum(dict, numBaseTwentySix);
            var secondNum = GetSecondNum(numBaseSeven);
            Console.WriteLine(GetResult(firstNum, secondNum, sign));
        }
        static long GetFirstNum(Dictionary<char, int> dict, string numBaseTwentySix)
        {
            long sum = 0;
            var pow = 0;
            for (int i = numBaseTwentySix.Length - 1; i >= 0; i--)
            {
                sum += (long)(dict[numBaseTwentySix[i]] * Math.Pow(26, pow));
                pow++;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static int GetSecondNum(string numBaseSeven)
        {
            var sum = 0;
            var pow = 0;

            for (int i = numBaseSeven.Length - 1; i >= 0; i--)
            {
                sum += (int)( (numBaseSeven[i] - '0') * Math.Pow(7, pow));
                pow++;
            }

            return sum;
        }
        static string GetResult(long firstNum, long SecondNum, string sign)
        {
            long protoNum = 0;
            var sum = "";
            var result = "";

            if (sign == "+")
            {
                protoNum = firstNum + SecondNum;
            }
            else
            {
                protoNum = firstNum - SecondNum;
            }

            while (true)
            {
                var left = protoNum % 9;
                sum += left;
                protoNum = (protoNum - left) / 9;

                if (protoNum < 9)
                {
                    sum += protoNum;
                    break;
                }
            }

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                result += sum[i];
            }

            return result;
        }
    }
}
