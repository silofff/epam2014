using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Contract
    {
        public string AbonentName { get; set; }
        public int TerminalNumber { get; set; }
        public Tariff Tariff { get; set; }
    }
}
