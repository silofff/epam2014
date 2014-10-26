using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class SentenceSeparator
    {
        private static readonly FileReader FileReader = new FileReader();
        private string _text;
        public SentenceSeparator(string fileName)
        {
            _text = FileReader.ReadFile(fileName);
        }
    }
}
