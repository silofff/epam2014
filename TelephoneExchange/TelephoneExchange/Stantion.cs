using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Stantion
    {
        public IList<Port> Ports = new List<Port>();

        public string StartConnection(CallData e)
        {
            var fromTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.FromNumber));
            var toTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.ToNumber));
            
            if (toTerminal == null)
            {
                return String.Format("Number {0} does not exist", e.ToNumber);

            }
            if (fromTerminal != null && (fromTerminal.State == PortState.Enabled &&
                                         toTerminal.State == PortState.Enabled))
            {
                if (OnConnect(new EventArgs()))
                {
                    fromTerminal.State = PortState.Connected;
                    toTerminal.State = PortState.Connected;
                    return String.Format("Number {0} connected with number {1}", e.FromNumber, e.ToNumber);
                }
                return String.Format("Number {0} can not talk with {1}", e.FromNumber, e.ToNumber);
            }
            return String.Format("Can not connected to number {0}", e.ToNumber);
        }

        public string FinishConnection(CallData e)
        {
            var fromTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.FromNumber));
            var toTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.ToNumber));

            if (toTerminal != null && toTerminal.State == PortState.Connected
                && fromTerminal != null && fromTerminal.State == PortState.Connected)
            {
                fromTerminal.State = PortState.Enabled;
                toTerminal.State = PortState.Enabled;
                return String.Format("Call Finished");
            }
            return null;
        }

        protected bool OnConnect(EventArgs e)
        {
            var temp = Connect;
            if (temp != null)
            {
                return Connect(e);
            }
            return false;
        }

        public event Predicate<EventArgs> Connect;

    }
}
