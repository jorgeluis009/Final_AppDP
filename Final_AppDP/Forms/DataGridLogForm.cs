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
    public partial class DataGridLogForm : Form
    {
        public DataGridLogForm()
        {
            InitializeComponent();
        }

        private void DataGridLogForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AddLog(LogObject Log)
        {
            dgvLog.Rows.Add(Log.Date.ToLongTimeString(), Log.Message);
        }
    }
}
