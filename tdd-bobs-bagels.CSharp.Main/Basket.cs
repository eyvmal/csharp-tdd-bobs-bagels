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
            return false;
        }
        public bool removeBagel(string bagel)
        {
            return false;
        }
        public void changeCapacity(int newCapacity)
        {

        }
    }
}
