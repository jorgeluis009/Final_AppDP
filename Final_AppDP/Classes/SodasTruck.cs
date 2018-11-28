using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class SodasTruck : Truck
    {
        public string Type { get; set; }

        public SodasTruck(int Qty) : base(Qty)
        {            
            Type = "Soda Truck";
        }
    }
}
