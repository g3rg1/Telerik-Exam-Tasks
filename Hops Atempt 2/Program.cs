using System;
using System.Collections.Generic;
using System.Linq;

namespace Hops_Atempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrotPatch = Console.ReadLine();
            var nums = carrotPatch.Split(", ").Select(c => int.Parse(c)).ToArray();
            var n = int.Parse(Console.ReadLine());
            var inputDirections = new string[n];
            var maxSum = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                inputDirections[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                var direction = inputDirections[i].Split(", ").Select(i => int.Parse(i)).ToArray();
                var index = 0;
                var currentSum = nums[index];
                var dirIndex = 0;
                bool visited = false;
                var visitedIndex = new List<int>();
                visitedIndex.Add(index);

                while (true)
                {
                    if(dirIndex > direction.Length-1)
                    {
                        dirIndex = 0;
                    }

                    index += direction[dirIndex];

                    if (index < 0 || index > nums.Length - 1)
                    {
                        break;
                    }

                    foreach (var visit in visitedIndex)
                    {
                        if(visit == index)
                        {
                            visited = true;
                        }
                    }

                    if(visited)
                    {
                        break;
                    }

                    currentSum += nums[index];
                    visitedIndex.Add(index);
                    dirIndex++;
                }

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
