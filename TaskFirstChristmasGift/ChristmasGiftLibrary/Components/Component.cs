using System;

namespace ChristmasGiftLibrary.Components
{
    [Serializable]
    public abstract class Component
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double CostInDollars { get; private set; }
        
        protected Component(string name, double weight, double costInDollars)
        {
            Name = name;
            Weight = weight;
            CostInDollars = costInDollars;
        }

        public abstract string ComponentDescription();
    }
}
