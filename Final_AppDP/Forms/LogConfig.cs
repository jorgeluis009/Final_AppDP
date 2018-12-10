﻿using Final_AppDP.Classes;
using Final_AppDP.Classes.LoggerClasses;
using Final_AppDP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
