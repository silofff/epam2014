using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Contract
    {
        public Abonent Abonent { get; set; }
        public Terminal Terminal { get; set; }
        public Tariff Tariff { get; set; }
    }
}
