using Final_AppDP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses
{
    class DataGridClass : LogManager
    {
        private static DataGridClass singleDGV = null;

        private DataGridClass(){}

        public static DataGridClass GetReference()
        {
            if (singleDGV == null)
            {
                singleDGV = new DataGridClass();
            }

            return singleDGV;
        }

        public void Show()
        {
            instanceCount++;
            if (instanceCount == 1)
            {
                form = new DataGridLogForm();
                form.Show();
            }
        }

        public void AddLog(LogObject log)
        {
            ((DataGridLogForm)form).AddLog(log);
        }
    }
}
