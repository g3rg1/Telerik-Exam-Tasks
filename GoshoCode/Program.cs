using System;
using System.Linq;
using System.Text;

namespace GoshoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(" " + Console.ReadLine());
            }

            var text = sb.ToString();
            var sentences = text.Split('.', '!').ToList();
            sentences.RemoveAt(sentences.Count - 1);

            var isExclame = new bool[sentences.Count];
            var exclameIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '.')
                {
                    isExclame[exclameIndex] = false;
                    exclameIndex++;
                }

                if (text[i] == '!')
                {
                    isExclame[exclameIndex] = false;
                    exclameIndex++;
                }
            }

            string stringToCalc = "";
            var index = 0;

            for (int i = 0; i < sentences.Count; i++)
            {
                if(sentences[i].Contains(word))
                {
                    stringToCalc = sentences[i];
                    index = i;
                    break;
                }
            }

            if(isExclame[index])
            {
                var wordIndex = stringToCalc.IndexOf(word) + word.Length;
                var len = stringToCalc.Length - wordIndex;
                stringToCalc = stringToCalc.Substring(wordIndex, len);
            }
            else
            {
                stringToCalc = stringToCalc.Substring(0, stringToCalc.IndexOf(word));
            }

            stringToCalc = stringToCalc.Trim();
            var sum = 0;

            for (int i = 0; i < stringToCalc.Length; i++)
            {
                if (stringToCalc[i] == ' ')
                {
                    continue;
                }
                else
                {
                    sum += (int)stringToCalc[i] * word.Length;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
