using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextParser.Converters;
using TextParser.SentenceParts;

namespace TextParser
{
    public class Concordance
    {
        private readonly IDictionary<string, Position> _concodance = new SortedDictionary<string, Position>();
        private readonly IConverter<string, IDictionary<string, Position>> _converter = new ConvertConcordanceToString(); 
        private readonly IList<Word> _words = new List<Word>(); 
        private readonly FileReader _fileReader = new FileReader();
        private readonly Regex _regexWord = new Regex(@"\w+", RegexOptions.IgnoreCase);
        private List<string> _text;
        public void Create(string fileName)
        {
            _text = _fileReader.ReadRows(fileName);
            foreach (var row in _text)
            {
                var match = _regexWord.Match(row);
                while (match.Success)
                {
                   _words.Add(new Word(match.Value.ToLower()){Position = _text.IndexOf(row)+1});
                    match = match.NextMatch();
                }
            }
        }

        public void GetConcordance()
        {
            foreach (var word in _words.Select(x => x.Value).Distinct())
            {
                var number = new Position
                {
                    NumberOfUse = _words.Count(x => x.Value == word),
                    Rows = _words.Where(x => x.Value == word).Select(x => x.Position).Distinct().ToList()
                };
                _concodance.Add(word, number);
            }
        }

        public override string ToString()
        {
            return _converter.Convert(_concodance);
        }
    }


}
