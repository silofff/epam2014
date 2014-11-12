using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new TestProgramm();
            program.Execute();
        }
    }
}
