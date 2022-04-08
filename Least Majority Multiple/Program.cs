using System;

namespace Least_Majority_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5];
            var result = 1;
            nums[0] = int.Parse(Console.ReadLine());
            nums[1] = int.Parse(Console.ReadLine());
            nums[2] = int.Parse(Console.ReadLine());
            nums[3] = int.Parse(Console.ReadLine());
            nums[4] = int.Parse(Console.ReadLine());

            while(true)
            {
                var majorityCount = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (result % nums[i] == 0)
                    {
                        majorityCount++;
                    }
                }

                if (majorityCount >= 3)
                {
                    Console.WriteLine(result);
                    break;
                }

                result++;
            }
        }
    }
}
