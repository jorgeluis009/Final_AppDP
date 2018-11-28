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

namespace Final_AppDP
{
    public partial class Deliver : Form
    {
        BindingList<Store> stores;
        public Deliver(BindingList<Store> aux)
        {
            InitializeComponent();
            stores = aux;
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {

        }
    }
}
