using System;

namespace ChristmasGiftLibrary.Components
{
    [Serializable]
    public abstract class Component
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double Cost { get; private set; }
        
        protected Component(string name, double weight, double cost)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }

        public abstract string ComponentDescription();
    }
}
