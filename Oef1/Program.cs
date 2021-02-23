using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    class Program
    {
        public static List<string> words = new List<string>();
        static void Main(string[] args)
        {
            WordAdder();
            ShowUniqueWords();
        }
        static void WordAdder()
        {
            bool loop = true;
            string input = null;
            int line = 0;
            do
            {
                Console.Write("Give me a word :");
                input = Console.ReadLine().ToLower();
                if (input != "end")
                {
                    words.Add(input);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(17+input.Length,line);
                    Console.WriteLine("Added!");
                    Console.ResetColor();
                    line++;
                }
                else
                {
                    loop = false;
                }
            } while (loop);
        }
        static void ShowUniqueWords()
        {
            words.Distinct().ToList().ForEach(Console.WriteLine);
        }
    }
}
