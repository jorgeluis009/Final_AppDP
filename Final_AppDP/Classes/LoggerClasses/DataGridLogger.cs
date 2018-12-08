using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses
{
    class DataGridLogger : LogObserver
    {
        private DataGridClass aux;

        public DataGridLogger()
        {
            IdLog = 2;
            LogName = "DataGridView Log";
            aux = DataGridClass.GetReference();
            aux.Show();
        }

        public override void Close()
        {
            aux.Close();
        }

        public override void ConcreteLog(LogObject log)
        {
            aux.AddLog(log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
