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
            gift.AddComponent(new Candy() { Weight = 5, Sugar = 4 });
            gift.AddComponent(new Candy() { Weight = 6, Sugar = 40 });
            gift.AddComponent(new Candy() { Weight = 7, Sugar = 20 });
            gift.SortGiftByWeight();
            lst = gift.FindComponentsBySugar(3, 35);
        }
    }
}
