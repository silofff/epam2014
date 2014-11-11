using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    struct Tariff
    {
        public int MinuteCost;

        public Tariff(int cost)
        {
            MinuteCost = cost;
        }
    }
}
