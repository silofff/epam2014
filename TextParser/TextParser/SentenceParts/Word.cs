using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextParser.SentenceParts
{
    public class Word : SentencePart
    {
        public Word(string value) :
            base(value)
        {
            
        }

        public int Lenght()
        {
            return Value.Length;
        }

        public bool IsVowel()
        {
            var match = Regex.Match(Value, @"^(A|E|I|O|U)", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}

