using System;
using System.IO;
using System.Linq;

namespace Result132
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string path = "D:\\task13\\Text.txt";

            var text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            var words = noPunctuationText
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length >= 1)
                .GroupBy(w => w)
                .OrderByDescending(g => g.Count());
            


            var i = 0;

            foreach (var word in words)
            {
                Console.WriteLine("{0}: {1}", word.Count(), word.Key);

                i++;

                if (i == 10) break;
                
            }
        }
    }
}