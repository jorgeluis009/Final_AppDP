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
        public float totalPrice { get; set; }

        public Store(int id, string name, BindingList<Product> order = null)
        {           
            idStore = id;
            storeName = name;
            products = order;
        }

        public void CalculateAmount()
        {
            totalPrice = 0;
            if(products != null)
                foreach (Product product in products)
                    totalPrice += product.quantity * product.price;
        }

        public override string ToString()
        {
            string res = "";
            res += "ID: " + idStore + "|Store Name: " + storeName + "|Products: ";
            foreach(Product product in products)
            {
                res += product.name + " - " + product.quantity + " pz; ";
            }
            res += "|Total Price: " + totalPrice;
            return res;
        }
    }
}
