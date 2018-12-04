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
        private static TextBoxClass textbox_singleton = null;

        private TextBoxClass()
        {
        }

        public static TextBoxClass GetReference()
        {
            if (textbox_singleton == null)
            {
                textbox_singleton = new TextBoxClass();
            } 

            return textbox_singleton;
        }

        public void Show()
        {
            referencesCount++;
            if (referencesCount == 1)
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
