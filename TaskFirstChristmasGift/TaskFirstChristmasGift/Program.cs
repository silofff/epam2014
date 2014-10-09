using System;
using System.Collections.Generic;
using ChristmasGiftLibrary;
using ChristmasGiftLibrary.Components;

namespace TaskFirstChristmasGift
{
    class Program
    {
        static void Main(string[] args)
        {
            var gift = new ChristmasGift();
            var lst = new List<Candy>();
            gift.Add(new Candy("Alionyshka", 40.0, 5, 10.0));
            gift.Add(new Candy("Mishka na severe", 10.0, 35, 120.0));
            gift.Add(new Candy("Yuznie Nochi", 20.0, 15, 110.0));
            gift.Add(new Fruit("Apple", 20.0, "Red", 110.0));

            gift.SortGiftByWeight();

            gift.Save("gift3");
            var gift2 = new ChristmasGift();
            gift2.Load("gift3");

            foreach (var c in gift2)
            {
                if (c != null) Console.WriteLine(c.ComponentDescription());
            }
            Console.ReadKey();
            //lst = gift.FindComponentsBySugar(3, 35);
        }
    }
}
