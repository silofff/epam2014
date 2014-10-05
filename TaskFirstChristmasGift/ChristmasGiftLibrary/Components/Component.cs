namespace ChristmasGiftLibrary.Components
{
    public abstract class Component
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CostInDollars { get; set; }
        //public int Calories { get; set; }
        
        public abstract string ComponentDescription();
    }
}
