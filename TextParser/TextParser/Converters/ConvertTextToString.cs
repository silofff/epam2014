using System.Text;
using TextParser.SentenceParts;

namespace TextParser.Converters
{
    class ConvertTextToString : IConverter<string, ReadyText>
    {
        private static readonly StringBuilder Sb = new StringBuilder();
        private readonly ConvertSentenceToString _converter = new ConvertSentenceToString();
        public string Convert(ReadyText convertible)
        {
            Sb.Clear();
            foreach (var c in convertible)
            {
                Sb.Append(_converter.Convert(c));
            }
            return Sb.ToString();
        }
    }
}
