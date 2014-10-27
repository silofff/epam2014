using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class FileReader
    {
        private StreamReader _fs;
        private readonly StringBuilder _sb = new StringBuilder();

        public string ReadFile(string fileName)
        {
            _sb.Clear();
            try
            {
                _fs = new StreamReader(fileName);
                string line;
                while ((line = _fs.ReadLine()) != null)
                {
                    _sb.Append(line).Append("\n");
                }

            }
            finally
            {
                _fs.Close();
            }

            return _sb.ToString();
        }

        public List<string> ReadRows(string fileName)
        {
            var list = new List<string>();
            try
            {
                _fs = new StreamReader(fileName);
                string line;
                while ((line = _fs.ReadLine()) != null)
                {
                    list.Add(line);
                }

            }
            finally
            {
                _fs.Close();
            }

            return list;

        }

    }
}
