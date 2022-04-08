using System;

namespace Tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var pipes = new int[n];
            var smallest = int.MaxValue;
            var divided = 0;

            for (int i = 0; i < n; i++)
            {
                var curr = int.Parse(Console.ReadLine());
                pipes[i] = curr;

                if(curr < smallest)
                {
                    smallest = curr;
                }
            }

            while(true)
            {
                divided = 0;

                foreach (var pipe in pipes)
                {
                    divided += (pipe / smallest);
                }

                if(divided == m || smallest == -1)
                {
                    Console.WriteLine(smallest);
                    break;
                }
                else
                {
                    smallest--;
                }
            }
        }
    }
}
