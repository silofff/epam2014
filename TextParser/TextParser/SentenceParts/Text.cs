﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TextParser.SentenceParts
{
    public class Text : IEnumerable<Sentence>
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

        public void RemoveConsonant(int length)
        {
            foreach (var sentence in _sentences)
            {
                sentence.RemoveWords(sentence.OfType<Word>().Where(x => x.Lenght() == length && !x.IsVowel())
                                            .ToList());
            }
        }

        public void ReplaceWords(int length, string substring)
        {
            var replacement = new Sentence().Create(substring);
            foreach (var sentence in _sentences)
            {
                sentence.ReplaceWords(sentence.OfType<Word>().Where(x => x.Lenght() == length).ToList(),
                    replacement);
            }
        }

        public IEnumerator<Sentence> GetEnumerator()
        {
            return _sentences.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
