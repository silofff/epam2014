using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    public class ReadyText : IEnumerable<Sentence>
    {
        private readonly List<Sentence> _sentences = new List<Sentence>();

        public void Add(Sentence sentence)
        {
            _sentences.Add(sentence);
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
