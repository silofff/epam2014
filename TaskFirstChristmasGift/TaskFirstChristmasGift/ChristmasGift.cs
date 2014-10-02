using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirstChristmasGift.Components;

namespace TaskFirstChristmasGift
{
    public class ChristmasGift
    {
        private readonly ICollection<Component> _components = new List<Component>();

        public void AddComponent(Component component)
        {
            _components.Add(component);
        }
    }
}
