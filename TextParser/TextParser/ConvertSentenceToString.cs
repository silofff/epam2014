using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.SentenceParts;

namespace TextParser
{
    class ConvertSentenceToString : IConverter<string,Sentence>
    {
        private readonly StringBuilder _sb = new StringBuilder();
        public string Convert(Sentence convertible)
        {
            _sb.Clear();

            foreach (var c in convertible)
            {
                _sb.Append(c.Value);
            }

            return _sb.ToString();
        }
    }
}
