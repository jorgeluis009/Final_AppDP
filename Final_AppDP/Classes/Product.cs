﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }

        public Product(int id, string nameP, int qty, float priceP)
        {
            idProduct = id;
            name = nameP;
            quantity = qty;
            price = priceP;
        }
    }
}
