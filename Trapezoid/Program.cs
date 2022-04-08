using System;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('.',n));
            Console.Write(new string('*', n));
            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.', n - (i+1)));
                Console.Write('*');
                Console.Write(new string('.', (n-1) + i));
                Console.Write('*');
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', n*2));
        }
    }
}
