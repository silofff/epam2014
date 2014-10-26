using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    public abstract class SentencePart
    {
        public string Value
        {
            get;
            private set;
        }

        protected SentencePart(string value)
        {
            Value = value;
        }
    }
}
