namespace ChristmasGiftLibrary.Components
{
    public abstract class Component
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CostInDollars { get; set; }
        //public int Calories { get; set; }

        protected Component() {}

        protected Component(string name, double weight, double costInDollars)
        {
            Name = name;
            Weight = weight;
            costInDollars = costInDollars;
        }

        public abstract string ComponentDescription();
    }
}
