using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class CallArgs : EventArgs
    {
        public int FromNumber { get; set; }
        public int ToNumber { get; set; }

        public CallArgs(int from, int to)
        {
            FromNumber = from;
            ToNumber = to;
        }
    }
}
