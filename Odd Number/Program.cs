using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var nums = new long[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            for (long i = 0; i < nums.Length; i++)
            {
                count = 1;
                for (long j = 0; j < nums.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    
                    if(nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                if(count% 2 != 0)
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
            }
        }
    }
}
