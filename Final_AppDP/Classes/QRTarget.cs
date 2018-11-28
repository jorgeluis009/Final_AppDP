using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public abstract class QRTarget
    {
        public abstract Store GetStore(string file);
        public abstract void SetStore(Store store);
    }
}
