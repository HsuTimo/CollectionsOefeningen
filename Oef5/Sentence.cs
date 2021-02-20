using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef5
{
    public class Sentence
    {
        private string[] _words;
        public delegate string MappingFunction(string s);
        public delegate string AggregateFunction(string resultaat, string woord);
        public Sentence(string input)
        {
            _words = input.Split(new char[] {' ','.',',','!',':' },StringSplitOptions.RemoveEmptyEntries);
        }
        public void Map(MappingFunction mappingFunction)
        {
            for (int i = 0; i < _words.Length; i++)
            {
                _words[i] = mappingFunction(_words[i]);
            }
        }
        public string Aggregate(AggregateFunction aggregateFunction)
        {
            StringBuilder sb = new StringBuilder();
            string result = _words[0];
            for (int i = 1; i < _words.Length; i++)
            {
                result = aggregateFunction(result, _words[i]);
            }
            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string output;
            foreach (var item in _words)
            {
                sb.Append(item+" ");
            }
            output = sb.ToString().Trim() + ".";
            return output;
        }
    }
}
