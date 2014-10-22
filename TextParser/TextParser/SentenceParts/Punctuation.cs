using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    class Punctuation
    {
        public string Mark
        {
            get;
            private set;
        }

        public Punctuation(string c)
        {
            Mark = c;
        }
    }
}
