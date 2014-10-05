using System;

namespace ChristmasGiftLibrary.Components
{
    public class Candy : Component
    {
        public int Sugar { get; set; }

        public Candy() {}

        public Candy(string name, double weight, int sugar, double costInDollars)
            : base(name, weight, costInDollars)
        {
            Sugar = sugar;
        }
        
        public override string ComponentDescription()
        {
            throw new NotImplementedException();
        }
    }
}
