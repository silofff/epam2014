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
        public enum TerminalState
        {
            YES,
            NO
        }

        public TerminalState State;

        public Terminal(int number)
        {
            TelephoneNumber = number;
            State = TerminalState.NO;
        }
    }
}
