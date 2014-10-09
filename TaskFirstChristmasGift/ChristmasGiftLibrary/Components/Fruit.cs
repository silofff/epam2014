using System;

namespace ChristmasGiftLibrary.Components
{
    [Serializable]
    public class Fruit : Component
    {
        public string FruitColor { get; private set; }

        public Fruit(string name, double weight, string fruitColor, double cost)
            : base(name, weight, cost)
        {
            FruitColor = fruitColor;
        }

        public override string ComponentDescription()
        {
            return String.Format("Candy {0} weighs {1} grams, its {2} and cost {3} dollars",
                Name, Weight, FruitColor, Cost);
        }
    }
}
