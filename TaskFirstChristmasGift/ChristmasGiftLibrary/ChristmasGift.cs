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
        private List<Component> _components = new List<Component>();
        [NonSerialized] private readonly GiftSerializer _giftSerializer = new GiftSerializer();

        public void Add(Component component)
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

        public void Save(string giftName)
        {
            _giftSerializer.SerializeGift(this, giftName);
        }

        public void Open(string giftName)
        {
            _components = _giftSerializer.DeserializeGift(giftName)._components;
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
