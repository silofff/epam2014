using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Terminal
    {
        public int TelephoneNumber { get; private set; }

        public Terminal(int number)
        {
            TelephoneNumber = number;
        }

        public event Func<bool> Ring;

        public bool TelephoneRing()
        {
            return OnRing();
        }

        protected bool OnRing()
        {
            var handler = Ring;
            if (handler != null) return handler();
            return false;
        }
    }
}
