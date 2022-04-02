using System;
using System.Collections.Generic;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCypher = Console.ReadLine();
            var operatorSign = Console.ReadLine();
            var secondCypher = Console.ReadLine();
            var georgeTheGreatNums = new string[] { "cad", "xoz", "nop", "cyk", "min",
                                                    "mar", "kon", "iva", "ogi", "yan"};
            var codePair = new Dictionary<string, string>();

            for (int i = 0; i < georgeTheGreatNums.Length; i++)
            {
                codePair.Add(georgeTheGreatNums[i], $"{i}");
            }

            var firstDigits = GetDigits(firstCypher, codePair);
            var secondDigits = GetDigits(secondCypher, codePair);
            var firstNum = int.Parse(string.Join("", firstDigits));
            var secondNum = int.Parse(string.Join("", secondDigits));
            int intResult;

            if(operatorSign == "+")
            {
                intResult = firstNum + secondNum;
            }
            else
            {
                intResult = firstNum - secondNum;
            }

            var stringResult = intResult.ToString();
            var result = "";

            for (int i = 0; i < stringResult.Length; i++)
            {
                result += georgeTheGreatNums[stringResult[i] - '0'];
            }

            Console.WriteLine(result);
        }

        static List<string> GetDigits(string cypher, Dictionary<string, string> codePair)
        {
            var firstDigits = new List<string>();

            while (cypher.Length >= 3)
            {
                var num = cypher.Substring(0, 3);
                firstDigits.Add(codePair[num]);
                cypher = cypher.Remove(0, 3);
            }

            return firstDigits;
        }
    }
}
