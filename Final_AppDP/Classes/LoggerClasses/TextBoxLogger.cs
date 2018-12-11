using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses
{
    class TextBoxLogger : LogObserver
    {
        TextBoxClass textBoxClass;

        public TextBoxLogger()
        {
            Log_ID = 1;
            Log_Name = "Textbox Log";
            textBoxClass = TextBoxClass.GetReference();
            textBoxClass.Show();
        }

        public override void Close()
        {
            textBoxClass.Close();
        }

        public override void ConcreteLog(LogObject log)
        {
            textBoxClass.AddLog(log);
        }

        public override int GetId()
        {
            return Log_ID;
        }
    }
}
