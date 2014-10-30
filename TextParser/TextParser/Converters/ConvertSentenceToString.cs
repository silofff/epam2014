using System.Text;
using TextParser.SentenceParts;

namespace TextParser.Converters
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
