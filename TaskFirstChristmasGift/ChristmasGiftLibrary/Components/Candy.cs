using System;

namespace ChristmasGiftLibrary.Components
{
    [Serializable]
    public class Candy : Component, ISugar
    {
        public int Sugar { get; private set; }
        
        public Candy(string name, double weight, int sugar, double costInDollars)
            : base(name, weight, costInDollars)
        {
            Sugar = sugar;
        }
        
        public override string ComponentDescription()
        {
            return String.Format("Candy {0} weighs {1} grams, contains {2} sugars and its cost {3} dollars",
                Name, Weight, Sugar, CostInDollars);
        }
    }
}
