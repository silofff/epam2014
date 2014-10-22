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
        private FileStream _fs;

        public void OpenFile(string fileName)
        {
            try
            {
                _fs = new FileStream(fileName, FileMode.Create);

            }
            finally
            {
                _fs.Close();
            }
        }

    }
}
