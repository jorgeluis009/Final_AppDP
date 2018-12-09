using Final_AppDP.Classes;
using Final_AppDP.Classes.LoggerClasses;
using Final_AppDP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AppDP
{
    public partial class LogConfig : Form
    {
        public LogConfig()
        {
            InitializeComponent();
        }        

        private void LogConfig_Load(object sender, EventArgs e)
        {

            dgvLog.DataSource = Logger.GetBindingList();
            dgvLog.Columns["LogName"].Width = 125;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logger.Add(new TextBoxLogger());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logger.Add(new DataGridLogger());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Add(new TextFileLogger());

        }
    }
}
