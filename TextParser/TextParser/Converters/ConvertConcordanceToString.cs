using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextParser.Converters
{
    class ConvertConcordanceToString : IConverter<string, IDictionary<string,Position>>
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private readonly IList<string> _alphabeth = new List<string>(); 
        public string Convert(IDictionary<string, Position> convertible)
        {
            foreach (var position in convertible)
            {
                if (!(_alphabeth.Contains(position.Key[0].ToString().ToUpper())))
                {
                    _alphabeth.Add(position.Key[0].ToString().ToUpper());
                    _sb.Append(_alphabeth.Last()).Append("\n");
                }
                _sb.Append(position.Key)
                   .Append("..........")
                   .Append(position.Value.NumberOfUse)
                   .Append(": ");
                foreach (var pos in position.Value.Pages)
                {
                    _sb.Append(pos.ToString())
                       .Append(" ");
                }
                _sb.Append("\n");
            }
            return _sb.ToString();
        }
    }
}
