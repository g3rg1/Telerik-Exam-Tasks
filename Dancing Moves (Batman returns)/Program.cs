using System;
using System.Collections.Generic;

namespace Dancing_Moves__Batman_returns_
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var moves = new List<string>();

            while(true)
            {
                var move = Console.ReadLine();

                if(move == "stop")
                {
                    break;
                }

                moves.Add(move);
            }

            var arrString = input.Split(' ');
            var arr = new int[arrString.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrString[i]);
            }

            var currentPos = 0;
            var sumOfall = 0;

            for (int i = 0; i < moves.Count; i++)
            {
                var instructions = moves[i].Split(' ');

                var times = int.Parse(instructions[0]);
                var direction = instructions[1];
                var step = int.Parse(instructions[2]);
                var maxIndex = arr.Length - 1;
                for (int j = 0; j < times; j++)
                {
                    var tempPos = currentPos;

                    if (direction == "right")
                    {
                        tempPos += step;

                        if (tempPos > maxIndex)
                        {
                            tempPos = (currentPos + step) % maxIndex;
                            tempPos--;
                        }
                    }
                    else
                    {
                        tempPos -= step;

                        if(tempPos < 0)
                        {
                            tempPos += maxIndex;
                        }
                    }
                    currentPos = tempPos;
                    sumOfall += arr[currentPos];
                }
            }

            double result = (double)sumOfall / (double)moves.Count;
            Console.WriteLine("{0}", Math.Round(result, 1));
        }
    }
}
