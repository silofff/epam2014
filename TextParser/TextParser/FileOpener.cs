using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class FileOpener
    {
        private StreamReader _fs;

        public List<string> OpenFile(string fileName)
        {
            var strings = new List<string>();
            try
            {
                _fs = new StreamReader(fileName);
                string line;
                while ((line = _fs.ReadLine()) != null)
                {
                    strings.Add(line);
                }

            }
            finally
            {
                _fs.Close();
            }

            return strings;
        }

    }
}
