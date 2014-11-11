using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Abonent
    {
        public string Name { get; set; }
        public Terminal Terminal { get; set; }
        public Contract Contract { get; set; }

        public void Call(int number)
        {
            OnStartCall(this, new CallArgs(Terminal.TelephoneNumber, number));
        }

        public void Finish(int number)
        {
            OnFinishCall(this, new CallArgs(Terminal.TelephoneNumber, number));
        }

        protected void OnStartCall(object sender, CallArgs e)
        {
            var temp = StartCall;
            if (temp != null)
            {
                StartCall(sender, e);
            }
        }

        protected void OnFinishCall(object sender, CallArgs e)
        {
            var temp = FinishCall;
            if (temp != null)
            {
                FinishCall(sender, e);
            }
        }

        public event EventHandler<CallArgs> StartCall;
        public event EventHandler<CallArgs> FinishCall;

    }
}
