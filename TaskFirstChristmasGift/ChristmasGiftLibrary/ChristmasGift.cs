﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChristmasGiftLibrary.Components;

namespace ChristmasGiftLibrary
{
    public class ChristmasGift : IEnumerable<Component>
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

        public List<Candy> FindComponentsBySugar(int minSugar, int maxSugar)
        {
            return _components.OfType<Candy>().Where(x => x.Sugar < maxSugar && x.Sugar > minSugar).ToList();
        }

        public IEnumerator<Component> GetEnumerator()
        {
            return _components.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
