using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AppDP.Classes.LoggerClasses
{
    abstract class LogManager
    {
            protected int instanceCount { get; set; }
            protected Form form { get; set; }

            public void Close()
            {
                if (instanceCount == 1) form.Close();
                instanceCount--;
            }
        
    }
}
