using System;

namespace TelephoneExchangeLibrary
{
    public class Terminal
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
