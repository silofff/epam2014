using System;

namespace TelephoneExchangeLibrary
{
    public class Abonent
    {
        public string Name { get; set; }
        public Terminal Terminal { get; set; }
        public Contract Contract { get; set; }

        public string Call(int number)
        {
            return OnStartCall(new CallData(Terminal.TelephoneNumber, number));
        }

        public string Finish(int number)
        {
            return OnFinishCall(new CallData(Terminal.TelephoneNumber, number));
        }

        protected string OnStartCall(CallData e)
        {
            var temp = StartCall;
            var srt = String.Format("{0}'s terminal deactivate", Name);
            if (temp != null)
            {
                srt = StartCall(e);
            }
            return srt;
        }

        protected string OnFinishCall(CallData e)
        {
            var temp = FinishCall;
            var srt = String.Format("{0}'s terminal deactivate", Name);
            if (temp != null)
            {
                srt = FinishCall(e);
            }
            return srt;
        }

        public event Func<CallData, string> StartCall;
        public event Func<CallData, string> FinishCall;

    }
}
