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

        public void StartConnection(object sender, CallArgs e)
        {
            var fromTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.FromNumber));
            var toTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.ToNumber));
            
            if (toTerminal == null)
            {
                Console.WriteLine("Number {0} does not exist", e.ToNumber);
            } 
            else if (fromTerminal != null && (fromTerminal.State == PortState.Enabled &&
                                              toTerminal.State == PortState.Enabled))
            {
                fromTerminal.State = PortState.Connected;
                toTerminal.State = PortState.Connected;
                Console.WriteLine("Number {0} connected with number {1}", e.FromNumber, e.ToNumber);
            }
            else
            {
                Console.WriteLine("Can not connected to number {0} because it is {1}", e.ToNumber, 
                    toTerminal.State);
            }
        }

        public void FinishConnection(object sender, CallArgs e)
        {
            var fromTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.FromNumber));
            var toTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.ToNumber));

            if (toTerminal != null && toTerminal.State == PortState.Connected
                && fromTerminal != null && fromTerminal.State == PortState.Connected)
            {
                fromTerminal.State = PortState.Enabled;
                toTerminal.State = PortState.Enabled;
                Console.WriteLine("Call Finished");
            }
            
            
        }
    }
}
