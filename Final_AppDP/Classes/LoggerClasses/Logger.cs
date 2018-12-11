using Final_AppDP.Classes.LoggerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public static class Logger
    {
        private static BindingList<LogObserver> logsList = new BindingList<LogObserver>();

        public static void Add(LogObserver NewObserver)
        {
            logsList.Add(NewObserver);
        }

        public static void RemoveLogs()
        {
            foreach (var LogManager in logsList) LogManager.Close();
            logsList.Clear();
        }

        public static void DeleteLog(int id)
        {
            LogObserver log_observer = logsList.FirstOrDefault(x => x.Log_ID == id);
            log_observer.Close();
            logsList.Remove(log_observer);
        }

        public static void Log(string LogMessage)
        {
            foreach (var LogManager in logsList)
            {
                LogManager.ConcreteLog(new LogObject(DateTime.Now, LogMessage));
            }
        }

        public static List<int> GetIds()
        {
            List<int> _ids = new List<int>();
            foreach (var LogManager in logsList)
            {
                _ids.Add(LogManager.GetId());
            }
            return _ids;
        }

        public static BindingList<LogObserver> GetBindingList()
        {
            return logsList;
        }
    }
}
