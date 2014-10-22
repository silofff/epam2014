using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    class Word : SentencePart, IEnumerable<Letter>
    {
        private readonly IList<Letter> _letters = new List<Letter>();
        private static StringBuilder _sb = new StringBuilder();

        public void Add(Letter letter)
        {
            _letters.Add(letter);
        }

        public int Size()
        {
            return _letters.Count;
        }

        public IEnumerator<Letter> GetEnumerator()
        {
            return _letters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ReturnString()
        {
            foreach (var letter in _letters)
            {
                _sb.Append(letter);
            }
            return _sb.ToString();
        }
    }
}
