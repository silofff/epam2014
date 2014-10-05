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
            gift.AddComponent(new Candy("Alionyshka", 40.0, 5, 10.0));
            gift.AddComponent(new Candy("Mishka na severe", 10.0, 35, 120.0));
            gift.AddComponent(new Candy("Yuznie Nochi", 20.0, 15, 110.0));
            gift.AddComponent(new Fruit("Apple", 20.0, "Red", 110.0));

            gift.SortGiftByWeight();
            foreach (var c in gift)
            {
                Console.WriteLine(c.ComponentDescription());
            }
            //lst = gift.FindComponentsBySugar(3, 35);
        }
    }
}
