using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Company
    {
        public string Name { get; set; }
        public IList<Contract> Contracts = new List<Contract>();
        public Stantion Stantion { get; set; }

        public Company(string name, Stantion stantion)
        {
            Name = name;
            Stantion = stantion;
        }

        public void Contract(Abonent abonent, Tariff tariff, int number)
        {
            var terminal = new Terminal(number);
            var currentContract = new Contract() {Abonent = abonent, Tariff = tariff, Terminal = terminal};
            Contracts.Add(currentContract);
            abonent.Contract = currentContract;
            abonent.Terminal = terminal;
            abonent.StartCall += Stantion.StartConnection;
            abonent.FinishCall += Stantion.FinishConnection;
            Stantion.Ports.Add(new Port(){State = PortState.Enabled, Terminal = terminal});
        }
    }
}
