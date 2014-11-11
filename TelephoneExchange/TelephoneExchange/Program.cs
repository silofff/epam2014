using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Abonent(){Name = "Nero"};
            var a2 = new Abonent() {Name = "Heliohabal"};
            var a3 = new Abonent() { Name = "Caligula" };

            var stantion = new Stantion();
            var company = new Company("Wainah Telecom", stantion);
            var tariff = new Tariff(5);
            company.Contract(a1, tariff, 777);
            company.Contract(a2, tariff, 888);
            company.Contract(a3, tariff, 999);
            a1.Call(888);
            a2.Call(999);
            a1.Finish(888);
            a2.Call(999);
            Console.ReadKey();
        }
    }
}
