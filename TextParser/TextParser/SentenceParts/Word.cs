using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    class Word : IEnumerable<Letter>
    {
        private readonly IList<Letter> _letters = new List<Letter>();

        public void Add(Letter letter)
        {
            _letters.Add(letter);
        }

        public IEnumerator<Letter> GetEnumerator()
        {
            return _letters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
