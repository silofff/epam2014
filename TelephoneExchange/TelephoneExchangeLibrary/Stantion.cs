using System;
using System.Collections.Generic;
using System.Linq;

namespace TelephoneExchangeLibrary
{
    public class Stantion
    {
        public IList<Port> Ports = new List<Port>();
        public IList<LogRecord> Log = new List<LogRecord>(); 

        public string StartConnection(CallData e)
        {
            var fromTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.FromNumber));
            var toTerminal = Ports.FirstOrDefault(x => x.Terminal.TelephoneNumber.Equals(e.ToNumber));
            
            if (toTerminal == null)
            {
                return String.Format("Number {0} does not exist", e.ToNumber);
            }
            if (toTerminal == fromTerminal)
            {
                return "You can not call yourself!";
            }
            if (fromTerminal != null && (fromTerminal.State == PortState.Enabled &&
                                         toTerminal.State == PortState.Enabled))
            {
                if (toTerminal.Terminal.TelephoneRing())
                {
                    fromTerminal.State = PortState.Connected;
                    toTerminal.State = PortState.Connected;
                    Log.Add(new LogRecord
                    {
                        StartTime = DateTime.Now, 
                        FromNumber = fromTerminal.Terminal.TelephoneNumber, 
                        ToNumber = toTerminal.Terminal.TelephoneNumber
                    });
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
                var record = Log.LastOrDefault(x => x.FromNumber.Equals(fromTerminal.Terminal.TelephoneNumber) &&
                    x.ToNumber.Equals(toTerminal.Terminal.TelephoneNumber));
                    record.EndTime = DateTime.Now;
                return String.Format("{0}, Call with {1} finished", fromTerminal.Terminal.TelephoneNumber,
                    toTerminal.Terminal.TelephoneNumber);
            }
            return fromTerminal != null ? String.Format("{0} does not connecting to anyone", 
                fromTerminal.Terminal.TelephoneNumber) : null;
        }

    }
}
