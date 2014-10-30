using System.Text.RegularExpressions;
using TextParser.Converters;
using TextParser.SentenceParts;

namespace TextParser
{
    public class SentenceSeparator
    {
        private readonly FileReader _fileReader = new FileReader();
        private string _rawText;
        private readonly Regex _regexSentence = new Regex(@"\w+[^.!?]*[.!?]*\n*", RegexOptions.IgnoreCase);
        private readonly Text _text = new Text();
		private readonly Regex _regexSpaces = new Regex(@"\s+");
        private readonly IConverter<string,Text> _converter = new ConvertTextToString();

        public void Create(string fileName)
        {
            _rawText = _fileReader.ReadFile(fileName);
            _rawText = _regexSpaces.Replace(_rawText, @" ");
            var match = _regexSentence.Match(_rawText);
            while (match.Success)
            {
                _text.Add(new Sentence().Create(match.Value));
                match = match.NextMatch();
            }
        }

        public void RemoveConsonant(int length)
        {
            _text.RemoveConsonant(length);
        }

        public void ReplaceWords(int length, string substring)
        {
            _text.ReplaceWords(length, substring);
        }

        public void Sort()
        {
            _text.SortByWord();
        }

        public override string ToString()
        {
            return _converter.Convert(_text);
        }
    }
}
