using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class Store
    {
        public int idStore { get; set; }
        public string storeName { get; set; }        
        public BindingList<Product> products { get; set; }

        public Store(int id, string name, BindingList<Product> order = null)
        {           
            idStore = id;
            storeName = name;
            products = order;
        }
    }
}
