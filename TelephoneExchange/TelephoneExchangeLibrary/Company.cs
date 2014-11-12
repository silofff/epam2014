﻿using System.Collections.Generic;
using System.Linq;

namespace TelephoneExchangeLibrary
{
    public class Company
    {
        public string Name { get; set; }
        private readonly IList<Contract> _contracts = new List<Contract>();
        public Stantion CompanyStantion { get; set; }
        public Dictionary<string, Tariff> Tariffs = new Dictionary<string, Tariff>(); 

        public Company(string name, Stantion companyStantion)
        {
            Name = name;
            CompanyStantion = companyStantion;
        }

        public void Contract(Abonent abonent, string tariffName, int number)
        {
            if (!Tariffs.ContainsKey(tariffName)) return;
            var tariff = Tariffs[tariffName];
            var terminal = new Terminal(number);
            var currentContract = new Contract { AbonentName = abonent.Name, Tariff = tariff, TerminalNumber = terminal.TelephoneNumber };
            _contracts.Add(currentContract);
            abonent.Contract = currentContract;
            abonent.Terminal = terminal;
            abonent.StartCall += CompanyStantion.StartConnection;
            abonent.FinishCall += CompanyStantion.FinishConnection;
            CompanyStantion.Ports.Add(new Port { State = PortState.Enabled, Terminal = terminal });
        }

        public void TerminateContract(Abonent abonent)
        {
            abonent.StartCall -= CompanyStantion.StartConnection;
            abonent.FinishCall -= CompanyStantion.FinishConnection;
            CompanyStantion.Ports.Remove(CompanyStantion.Ports.FirstOrDefault(x => x.Terminal.Equals(abonent.Terminal)));
            abonent.Contract = null;
        }
    }
}