using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TelephoneExchangeLibrary;

namespace TelephoneExchange
{
    class TestProgramm
    {

        public void Execute()
        {
            var a1 = new Abonent { Name = "Nero" };
            var a2 = new Abonent { Name = "Heliohabal" };
            var a3 = new Abonent { Name = "Caligula" };
            var stantion = new Stantion();
            var company = new Company("Vainah Telecom", stantion);
            var tariff = new Tariff(5);

            company.Tariffs.Add("Sky", tariff);
            company.Contract(a1, "Sky", 777);
            company.Contract(a2, "Sky", 888);
            company.Contract(a3, "Sky", 999);

            a1.Terminal.Ring += PressKey;
            a2.Terminal.Ring += PressKey;
            a3.Terminal.Ring += PressKey;
            
            Console.WriteLine("Number {0} connecting with number {1}", a1.Terminal.TelephoneNumber, a2.Terminal.TelephoneNumber);
            Console.WriteLine(a1.Call(888));
            Thread.Sleep(2000);
            Console.WriteLine(a1.Finish(888));

            Console.WriteLine("Number {0} connecting with number {1}", a1.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a1.Call(999));
            Console.WriteLine("Number {0} connecting with number {1}", a2.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a2.Call(999));
            Thread.Sleep(2000);
            Console.WriteLine(a1.Finish(999));
            Console.WriteLine("Number {0} connecting with number {1}", a2.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a2.Call(999));
            Thread.Sleep(2000);
            Console.WriteLine(a2.Finish(999));

            Console.WriteLine("Outcoming call's history of {0}", a1.Name);
            WriteUserLog(company.GetHistory(a1));
            Console.WriteLine("Outcoming call's history of {0}", a2.Name);
            WriteUserLog(company.GetHistory(a2));

            company.TerminateContract(a1);
            a1.Terminal.Ring -= PressKey;
            Console.WriteLine(a1.Call(888));
            Console.WriteLine(a1.Finish(888));

            Console.ReadKey();
        }

        private void WriteUserLog(IEnumerable<LogRecord> log)
        {
            foreach (var record in log)
            {
                Console.WriteLine("From {0} to {1} start at {2} end at {3} price {4}", record.FromNumber, record.ToNumber,
                    record.StartTime, record.EndTime, record.Price);
            }
        }

        private bool PressKey()
        {
            Console.WriteLine("Type YES or NO: ");
            if (Console.ReadLine() == "YES")
                return true;
            return false;
        }
    }
}
