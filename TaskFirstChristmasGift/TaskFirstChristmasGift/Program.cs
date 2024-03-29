﻿using System;
using System.Collections.Generic;
using ChristmasGiftLibrary;
using ChristmasGiftLibrary.Components;

namespace TaskFirstChristmasGift
{
    class Program
    {
        static void Main(string[] args)
        {
            var gift = new ChristmasGift
            {
                new Candy("Alionyshka", 40.0, 5, 10.0),
                new Candy("Mishka na severe", 10.0, 35, 120.0),
                new Candy("Yuznie Nochi", 20.0, 15, 110.0),
                new Fruit("Apple", 20.0, "Red", 110.0)
            };

            gift.SortGiftByWeight();

            try
            {
                gift.Save("gift3");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var gift2 = new ChristmasGift();

            try
            {
                gift2.Load("gift3");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var c in gift2)
            {
                if (c != null) Console.WriteLine(c.ComponentDescription());
            }

            Console.WriteLine("\n");

            foreach (var c in gift.FindComponentsBySugar(3, 35))
            {
                if (c != null) Console.WriteLine(c.ComponentDescription());
            }

            Console.ReadKey();
        }
    }
}
