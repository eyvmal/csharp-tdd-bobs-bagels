using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int _capacity;
        private List<string> _items;

        public Basket(int capacity)
        {
            _capacity = capacity;
            _items = new List<string>();
        }

        public bool addBagel(string bagel)
        {
            if (_items.Count < _capacity)
            {
                _items.Add(bagel);
                return true;
            }
            return false;
        }
        public bool removeBagel(string bagel)
        {
            if (_items.Contains(bagel))
            {
                _items.Remove(bagel);
                return true;
            }
            return false;
        }
        public void changeCapacity(int newCapacity)
        {

        }
    }
}
