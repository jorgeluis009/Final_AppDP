using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeEncoderDecoderLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Final_AppDP.Classes;

namespace Final_AppDP
{
    public partial class Welcome : Form
    {        
        public Welcome()
        {
            InitializeComponent();
        }        

        private void label2_Click(object sender, EventArgs e)
        {
            QRAdapter adapter = new QRAdapter();
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;            
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";            
            BindingList<Store> stores = new BindingList<Store>();            
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in open.FileNames)
                {
                    Store store = adapter.GetStore(file);
                    stores.Add(store);                        
                }
            }
            /*for(int i = 0; i < stores.Count; i++)
            {
                if (stores[i].products == null)
                {
                    using (MakeOrder make = new MakeOrder(stores[i]))
                    {                        
                        var result = make.ShowDialog();
                        if (result == DialogResult.OK)
                            stores[i] = make.auxStore;
                    }
                }                
            }   */         
            var source = new BindingSource(stores, null);
            dgvStores.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRAdapter adapter = new QRAdapter();
            Store auxStore = new Store(4, "Aurrera");
            adapter.SetStore(auxStore);
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Deliver deliver = new Deliver();
            deliver.ShowDialog();
        }
    }
}
