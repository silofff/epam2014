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
        //сделать внешним сериализатор
        [NonSerialized] private static readonly GiftSerializer GiftSerializer = new GiftSerializer();
        

        public double TotalWeight { get; private set; }
        public double TotalCost { get; private set; }
        public int TotalSugar { get; private set; }

        public void Add(Component component)
        {
            _components.Add(component);
            TotalWeight += component.Weight;
            TotalCost += component.Cost;
            if (component is ISugar) TotalSugar += ((ISugar) component).Sugar;
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
            try
            {
                GiftSerializer.SerializeGift(this, giftName);
            }
            catch (Exception e)
                //передать ошибку выше
            {
                throw new Exception("Failed to save gift");
            }
            
        }

        public void Load(string giftName)
        {
            try
            {
                var loadedGift = GiftSerializer.DeserializeGift(this, giftName);
                TotalWeight = loadedGift.TotalWeight;
                TotalCost = loadedGift.TotalCost;
                TotalSugar = loadedGift.TotalSugar;
                _components = loadedGift._components;
            }
            catch (Exception)
            {
                throw new Exception("Failed to load gift");
            }

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
