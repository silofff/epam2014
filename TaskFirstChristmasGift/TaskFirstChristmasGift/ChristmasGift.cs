using System;
using System.Collections;
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
        private List<Component> _components = new List<Component>();

        public void AddComponent(Component component)
        {
            _components.Add(component);
        }

        public void SortGiftByWeight()
        {
            _components = _components.OrderBy(component => component.Weight).ToList();
        }

        public List<Component> FindComponentsBySugar(int minSugar, int maxSugar)
        {
            return _components.Where(x => x.Sugar < maxSugar && x.Sugar > minSugar).ToList();
        }
    }
}
