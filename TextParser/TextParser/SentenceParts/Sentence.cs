using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    public class Sentence : IEnumerable<SentencePart>
    {
        private readonly IList<SentencePart> _sentenceParts = new List<SentencePart>();
        private readonly Regex _regexWord = new Regex(@"\w+", RegexOptions.IgnoreCase);
        private readonly Regex _regexPunctuation = new Regex(@"[^\w\s]+", RegexOptions.IgnoreCase);
        
        public Sentence Create(string sentence)
        {
            foreach (Match match in Regex.Matches(sentence, @"\W+|\w+", RegexOptions.IgnoreCase))
            {
                if (_regexPunctuation.IsMatch(match.Value))
                {
                    _sentenceParts.Add(new Punctuation(_regexPunctuation.Match(match.Value).Value));
                } else if (_regexWord.IsMatch(match.Value))
                {
                    _sentenceParts.Add(new Word(_regexWord.Match(match.Value).Value));
                }
            }

            return this;
        }

        public IEnumerator<SentencePart> GetEnumerator()
        {
            return _sentenceParts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
