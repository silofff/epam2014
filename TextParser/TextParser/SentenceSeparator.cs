using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextParser.SentenceParts;

namespace TextParser
{
    public class SentenceSeparator
    {
        private static readonly FileReader FileReader = new FileReader();
        private string _text;
        private readonly Regex _regexSentence = new Regex(@"\w+[^.!?]*[.!?]*\n*", RegexOptions.IgnoreCase);
        private readonly ReadyText _readyText = new ReadyText();
        private readonly Regex _regexSpaces = new Regex(@"[ ]{2,}\t?");
        private static readonly ConvertTextToString Converter = new ConvertTextToString();

        public void Create(string fileName)
        {
            _text = FileReader.ReadFile(fileName);
            _text = _regexSpaces.Replace(_text, @" ");
            var match = _regexSentence.Match(_text);
            while (match.Success)
            {
                _readyText.Add(new Sentence().Create(match.Value));
                match = match.NextMatch();
            }
        }

        public override string ToString()
        {
            return Converter.Convert(_readyText);
        }
    }
}
