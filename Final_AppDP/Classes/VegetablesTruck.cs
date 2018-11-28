using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class VegetablesTruck : Truck
    {
        public string Type { get; set; }

        public VegetablesTruck(int Qty) : base(Qty)
        {            
            Type = "Vegetables Truck";
        }
    }
}
