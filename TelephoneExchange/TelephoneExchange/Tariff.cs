using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Tariff
    {
        public int MinuteCost { get; private set; }

        public Tariff(int cost)
        {
            MinuteCost = cost;
        }
    }
}
