using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChristmasGiftLibrary.Components;

namespace ChristmasGiftLibrary
{
    [Serializable]
    public class ChristmasGift : IEnumerable<Component>
    {
        private IList<Component> _components = new List<Component>();
        [NonSerialized] private static readonly GiftSerializer GiftSerializer = new GiftSerializer();
        
        public void Add(Component component)
        {
            _components.Add(component);
        }

        public void SortGiftByWeight()
        {
            _components = _components.OrderBy(component => component.Weight).ToList();
        }

        public IEnumerable<Component> FindComponentsBySugar(int minSugar, int maxSugar)
        {
            return _components.Where(x => x is ISugar).Where(x => ((ISugar)x).Sugar < maxSugar && ((ISugar)x).Sugar > minSugar);
        }

        public void Save(string giftName)
        {
            GiftSerializer.SerializeGift(this, giftName);
        }

        public void Open(string giftName)
        {
            _components = GiftSerializer.DeserializeGift(this, giftName)._components;
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
