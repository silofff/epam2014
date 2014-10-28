using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextParser.SentenceParts
{
    public class Sentence : IEnumerable<ISentencePart>
    {
        private readonly IList<ISentencePart> _sentenceParts = new List<ISentencePart>();
        private readonly Regex _regexWord = new Regex(@"\w+", RegexOptions.IgnoreCase);
        private readonly Regex _regexPunctuation = new Regex(@"[^\w\s]+\n*|\n", RegexOptions.IgnoreCase);
		private readonly Regex _regexWhitespace = new Regex(@"[ ]", RegexOptions.IgnoreCase);
        
        public Sentence Create(string sentence)
        {
            foreach (Match match in Regex.Matches(sentence, @"\s+|[^\w\s]|\w+", RegexOptions.IgnoreCase))
            {
                if (_regexPunctuation.IsMatch(match.Value))
                {
                    _sentenceParts.Add(new Punctuation(_regexPunctuation.Match(match.Value).Value));
					continue;
                }
				if (_regexWord.IsMatch(match.Value))
                {
                    _sentenceParts.Add(new Word(_regexWord.Match(match.Value).Value));
					continue;
                }
                if (_regexWhitespace.IsMatch(match.Value))
                {
                    _sentenceParts.Add(new Whitespace(_regexWhitespace.Match(match.Value).Value));
                }
            }
            return this;
        }

        public int WordCount()
        {
            return _sentenceParts.OfType<Word>().Count();
        }

        public void RemoveWords(List<Word> words)
        {
			words.ForEach (x => _sentenceParts.Remove (x));
        }


		public void ReplaceWords(List<Word> words, string substring)
        {
			words.ForEach (x => _sentenceParts [_sentenceParts.IndexOf (x)] = new Word (substring));
        }

        public IEnumerator<ISentencePart> GetEnumerator()
        {
            return _sentenceParts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }			
    }
}
