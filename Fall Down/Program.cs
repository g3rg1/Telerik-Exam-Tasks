using System;

namespace Fall_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            var byteRow = new byte[8];

            for (int i = 0; i < 8; i++)
            {
                byteRow[i] = byte.Parse(Console.ReadLine());
            }


        }
    }
}
