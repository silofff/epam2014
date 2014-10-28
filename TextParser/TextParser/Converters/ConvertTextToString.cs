using System.Text;
using TextParser.SentenceParts;

namespace TextParser.Converters
{
    class ConvertTextToString : IConverter<string, Text>
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private readonly ConvertSentenceToString _converter = new ConvertSentenceToString();
        public string Convert(Text convertible)
        {
            _sb.Clear();
            foreach (var c in convertible)
            {
                _sb.Append(_converter.Convert(c));
            }
            return _sb.ToString();
        }
    }
}
