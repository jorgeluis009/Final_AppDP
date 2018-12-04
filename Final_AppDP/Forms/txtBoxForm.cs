using Final_AppDP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AppDP.Forms
{
    public partial class txtBoxForm : Form
    {
        public txtBoxForm()
        {
            InitializeComponent();
        }

        public void AddLog(LogObject Log)
        {
            txtBox.AppendText(Log.ToString());
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
