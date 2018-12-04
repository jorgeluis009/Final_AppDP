using Final_AppDP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP
{
    public abstract class LogObserver
    {
        public int IdLog { get; set; }
        public string LogName { get; set; }

        public abstract void ConcreteLog(LogObject log);

        public abstract void Close();

        public abstract int GetId();
    }
}
