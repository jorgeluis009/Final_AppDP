using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses
{
    abstract class LoggerSubject
    {
        public abstract void Add(LogObserver NewObserver);
        public abstract void RemoveLogs();
        public abstract void DeleteLog(int id);
        public abstract void Log(string LogMessage);
        public abstract List<int> GetIds();
        public abstract BindingList<LogObserver> GetBindingList();
    }
}
