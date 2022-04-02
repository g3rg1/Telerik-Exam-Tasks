using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToCalc = Console.ReadLine() + Console.ReadLine();
            var word = Console.ReadLine();
            ulong sum = 0;
            for (int i = 0; i < stringToCalc.Length; i++)
            {
                if (stringToCalc[i] == ' ')
                {
                    continue;
                }
                else
                {
                    sum += (ulong)((int)stringToCalc[i] * word.Length);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
