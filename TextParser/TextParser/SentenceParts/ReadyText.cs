using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    public class ReadyText : IEnumerable<Sentence>
    {
        private IList<Sentence> _sentences = new List<Sentence>();

        public void Add(Sentence sentence)
        {
            _sentences.Add(sentence);
        }

        public void SortByWord()
        {
            _sentences = _sentences.OrderBy(x => x.WordCount()).ToList();
        }

        public IEnumerator<Sentence> GetEnumerator()
        {
            return _sentences.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void RemoveConsonant(int length)
        {
            foreach (var sentence in _sentences)
            {
                sentence.RemoveWords(sentence.OfType<Word>().Where(x => x.Lenght() == length && !x.IsVowel()).ToList());
            }
        }

        public void ReplaceWord(int length, string substring)
        {
            foreach (var sentence in _sentences)
            {
                sentence.ReplaceWords(sentence.OfType<Word>().Where(x => x.Lenght() == length).ToList(), substring);
            }
        }
    }
}
