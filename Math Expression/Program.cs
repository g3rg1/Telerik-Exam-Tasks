using System;

namespace Math_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());
            var p = decimal.Parse(Console.ReadLine());
            var brake = "";

            var result = GetResult(n, m, p);

            Console.WriteLine($"{result:F6}");
        }
        static decimal GetResult(decimal n, decimal m, decimal p)
        {
            decimal dividend = (decimal)Math.Pow((double)n, 2) + (1 / (m * p)) + 1337;

            decimal divisor = n - 128.523123123M * p;

            var sine = (decimal)Math.Sin(Math.Truncate((double)m % 180));

            var result = (dividend / divisor) + sine;

            return result;
        }
    }
}
