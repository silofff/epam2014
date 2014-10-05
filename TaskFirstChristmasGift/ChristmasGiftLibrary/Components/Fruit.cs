using System;

namespace ChristmasGiftLibrary.Components
{
    public class Fruit : Component
    {
        public string FruitColor { get; set; }

        public Fruit() {}

        public Fruit(string name, double weight, string fruitColor, double costInDollars)
            : base(name, weight, costInDollars)
        {
            FruitColor = fruitColor;
        }

        public override string ComponentDescription()
        {
            throw new NotImplementedException();
        }
    }
}
