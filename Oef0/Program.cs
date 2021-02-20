using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type een zin:");
            string input = Console.ReadLine();
            int length = input.Length;
            int words = GetAmountOfWords(input);
            int spaces = GetAmountOfSpaces(input);
            Console.WriteLine($"Amount of characters: {length}");
            Console.WriteLine($"Amount of words: {words}");
            Console.WriteLine($"Amount of spaces: {spaces}");
        }
        static int GetAmountOfWords(string str)
        {
            return str.Split(' ').Length;
        }
        static int GetAmountOfSpaces(string str)
        {
            int output = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    output++;
                }
            }
            return output;
        }
    }
}
