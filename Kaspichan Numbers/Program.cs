using System;
using System.Collections.Generic;

namespace Kaspichan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = ulong.Parse(Console.ReadLine());
            var kaspichanNums = new Dictionary<int, string>();
            int kasNum = 0;

            for (char i = 'A'; i <= 'Z'; i++)
            {
                kaspichanNums.Add(kasNum, i.ToString());
                kasNum++;
            }

            bool stop = false;

            for (char i = 'a';; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    kaspichanNums.Add(kasNum, $"{i.ToString() + j.ToString()}");
                    kasNum++;
                    if(kasNum == 256)
                    {
                        stop = true;
                        break;
                    }
                }
                if(stop)
                {
                    break;
                }
            }

            var kaspichanNum = new List<string>();

            while(true)
            {
                ulong value = num % 256;
                kaspichanNum.Add($"{kaspichanNums[(int)value]}");
                num /= 256;
                
                if(num < 256)
                {
                    if(num == 0)
                    {
                        break;
                    }

                    kaspichanNum.Add($"{kaspichanNums[(int)num]}");
                    break;
                }
            }

            var result = "";

            for (int i = kaspichanNum.Count - 1; i >= 0; i--)
            {
                result += kaspichanNum[i];
            }
            Console.WriteLine(result);
        }
    }
}
