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
    class Word : SentencePart
    {
        public Word(string value) :
            base(value)
        {
            
        }
    }
}

