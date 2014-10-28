using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextParser
{
    public class FileReader
    {
        private StreamReader _fs;
        private readonly StringBuilder _sb = new StringBuilder();

        public string ReadFile(string fileName)
        {
            _sb.Clear();
			using (_fs = new StreamReader(fileName))
			{
                
                string line;
                while ((line = _fs.ReadLine()) != null)
                {
                    _sb.Append(line).Append("\n");
                }
                _fs.Close();
            }

            return _sb.ToString();
        }

        public List<string> ReadRows(string fileName)
        {
			var result = new List<string>();
			using (_fs = new StreamReader(fileName))
			{
                string line;
                while ((line = _fs.ReadLine()) != null)
                {
                    result.Add(line);
                }
                _fs.Close();
            }

            return result;
        }

    }
}
