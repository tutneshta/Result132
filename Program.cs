using System;
using System.IO;
using System.Linq;

namespace Result132
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\task13\\Text.txt";

            string text = File.ReadAllText(path);

            string noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            var words = noPunctuationText
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length >= 1)
                .GroupBy(w => w)
                .OrderByDescending(g => g.Count());

            int i = 0;

            foreach (var word in words)
            {
                Console.WriteLine("{0}: {1}", word.Count(), word.Key);

                i++;

                if (i == 10)
                {
                    break;
                }
            }
        }
    }
}
