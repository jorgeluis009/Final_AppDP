using Final_AppDP.Classes.LoggerClasses.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses
{
    class TextFileLogger : LogObserver
    {
        private TextFileClass logElement;

        public TextFileLogger()
        {
            IdLog = 0;
            LogName = "File Log";
            logElement = TextFileClass.GetReference();
        }

        public override void Close()
        {
            logElement.Close();
        }

        public override void ConcreteLog(LogObject log)
        {
            logElement.AddLog(log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
