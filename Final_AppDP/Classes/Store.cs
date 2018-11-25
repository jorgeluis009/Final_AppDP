using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    class Store
    {
        public int idStore { get; set; }
        public string storeName { get; set; }
        public Product[] products { get; set; }

        public Store(int id, string name, Product[] order)
        {
            idStore = id;
            storeName = name;
            products = order;
        }
    }
}
