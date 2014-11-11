using System;

namespace TelephoneExchange
{
    class Abonent
    {
        public string Name { get; set; }
        public Terminal Terminal { get; set; }
        public Contract Contract { get; set; }

        public string Call(int number)
        {
            return OnStartingCall(new CallData(Terminal.TelephoneNumber, number));
        }

        public string Finish(int number)
        {
            return OnFinishCall(new CallData(Terminal.TelephoneNumber, number));
        }

        protected string OnStartingCall(CallData e)
        {
            var temp = StartCall;
            var srt = String.Empty;
            if (temp != null)
            {
                srt = StartCall(e);
            }
            return srt;
        }

        protected string OnFinishCall(CallData e)
        {
            var temp = FinishCall;
            var srt = String.Empty;
            if (temp != null)
            {
                srt = FinishCall(e);
            }
            return srt;
        }

        protected bool OnPress(EventArgs e)
        {
            var temp = Press;
            if (temp != null)
            {
                return Press(e);
            }
            return false;
        }

        public bool Ring(EventArgs e)
        {
            return OnPress(e);
        }

        public event Func<CallData, string> StartCall;
        public event Func<CallData, string> FinishCall;
        public event Predicate<EventArgs> Press;

    }
}
