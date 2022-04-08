using System;
using System.Linq;

namespace Crooked_Walls_Atempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = input.Split(' ').Select(s => int.Parse(s)).ToArray();
            var distances = new int[nums.Length - 1];
            var sum = 0;

            for (int i = 0; i < distances.Length-1; i++)
            {
                var toCheck = Math.Abs(Math.Max(nums[i], nums[i+1]) - Math.Min(nums[i], nums[i + 1]));
                distances[i] = toCheck;
            }

            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] % 2 == 0)
                {
                    sum += distances[i];
                    i++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
