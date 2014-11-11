using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TelephoneExchange
{
    class Program
    {
        private static bool PressKey(EventArgs e)
        {
            if (Console.ReadLine() == "YES")
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            var a1 = new Abonent(){Name = "Nero"};
            var a2 = new Abonent() {Name = "Heliohabal"};
            var a3 = new Abonent() { Name = "Caligula" };

            var stantion = new Stantion();
            var company = new Company("Wainah Telecom", stantion);
            var tariff = new Tariff(5);
            company.Tariffs.Add("super", tariff);
            company.Contract(a1, "super", 777);
            company.Contract(a2, "super", 888);
            company.Contract(a3, "super", 999);
            a3.Press += PressKey;
            Console.WriteLine("Number {0} connecting with number {1}", a1.Terminal.TelephoneNumber, a2.Terminal.TelephoneNumber);
            Console.WriteLine(a1.Call(888));
            Console.WriteLine(a1.Finish(888));
            Console.WriteLine("Number {0} connecting with number {1}", a1.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a1.Call(999));
            Console.WriteLine("Number {0} connecting with number {1}", a2.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a2.Call(999));
            Console.WriteLine(a1.Finish(999));
            Console.WriteLine("Number {0} connecting with number {1}", a2.Terminal.TelephoneNumber, a3.Terminal.TelephoneNumber);
            Console.WriteLine(a2.Call(999));

            Console.ReadKey();
        }
    }
}
