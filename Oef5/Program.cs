using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef5
{
    class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = new Sentence("Delegate in C# works as a method reference.");
            Console.WriteLine("Aggregation using -");
            Console.WriteLine(sentence.Aggregate((a, b) => a + "-" + b));
            Console.WriteLine("Aggregation using space");
            Console.WriteLine(sentence.Aggregate((a, b) => a + " " + b));
            Console.WriteLine("Aggregation using brackets");
            Console.WriteLine(sentence.Aggregate((a, b) => "("+a + ")" + b));
            Console.WriteLine("Shortening words with aggregation");
            Console.WriteLine(sentence.Aggregate(LangerDan4));
            Console.WriteLine("Mapping all words longer than five to uppercase");
            sentence.Map(LangerDan5);
            Console.WriteLine(sentence);
        }
        static string LangerDan5(string word)
        {
            if (word.Length>5)
            {
                return word.ToUpper();
            }
            return word;
        }
        static string LangerDan4(string result, string word)
        {
            string output = result;
            if (word.Length>4)
            {
                output = result + " " +  word.Substring(0,4) + ".";
                return output;
            }
            return output +" "+ word;
        }
    }
}
