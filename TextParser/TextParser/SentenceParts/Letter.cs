using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    class Letter
    {
        public char Character
        {
            get;
            private set;
        }

        public Letter(char c)
        {
            Character = c;
        }
    }
}
