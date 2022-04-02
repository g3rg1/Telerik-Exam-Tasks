using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_Numeral_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stringNums = input.Split(", ");
            var list = new List<string>();
            ulong result = 1;

            list.Add("hristo");
            list.Add("tosho");
            list.Add("pesho");
            list.Add("hristofor");
            list.Add("vlad");
            list.Add("haralampi");
            list.Add("zoro");
            list.Add("vladimir");

            for (int i = 0; i < stringNums.Length; i++)
            {
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    stringNums[i] = stringNums[i].Replace(list[j], $"{j}");
                }
                Console.WriteLine(stringNums[i]);
                result *= GetResult(stringNums[i]);
            }

            Console.WriteLine(result);
        }
        static ulong GetResult(string numBaseEight)
        {
            ulong sum = 0;
            var pow = 0;

            for (int i = numBaseEight.Length - 1; i >= 0; i--)
            {
                sum += (ulong)((numBaseEight[i] - '0') * Math.Pow(8, pow));
                pow++;
            }

            return sum;
        }
    }
}
