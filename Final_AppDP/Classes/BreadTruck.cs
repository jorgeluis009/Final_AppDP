using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class BreadTruck : Truck
    {
        public string Type { get; set; }

        public BreadTruck(int Qty) : base(Qty)
        {            
            Type = "Bread Truck";
        }
    }
}
