using Final_AppDP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_AppDP.Classes.LoggerClasses
{
    class TextBoxClass : LogManager
    {
        private static TextBoxClass singleTextBox = null;

        private TextBoxClass(){}

        public static TextBoxClass GetReference()
        {
            if (singleTextBox == null)
            {
                singleTextBox = new TextBoxClass();
            } 

            return singleTextBox;
        }

        public void Show()
        {
            instanceCount++;
            if (instanceCount == 1)
            {
                form = new txtBoxForm();
                form.Show();
            }
        }

        public void AddLog(LogObject log)
        {
            ((txtBoxForm)form).AddLog(log);
        }

    }
}
