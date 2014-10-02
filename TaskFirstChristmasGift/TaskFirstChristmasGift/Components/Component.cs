using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirstChristmasGift.Components
{
    public abstract class Component
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CostInDollars { get; set; }
        //public int Sugar { get; set; }
        //public int Calories { get; set; }
        
        public abstract string ComponentDescription();
    }
}
