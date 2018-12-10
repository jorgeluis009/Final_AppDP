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
using System.Runtime.InteropServices;

namespace Final_AppDP
{
    public partial class MakeOrder : Form
    {        
        public Store store { get; set; }
        int auxVegetables = 0;
        int auxSodas = 0;
        int auxBread = 0;

        public MakeOrder(Store auxStore)
        {
            InitializeComponent();
            store = auxStore;
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            lblStore.Text = store.storeName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BindingList<Product> products = new BindingList<Product>();
            if (noVegetables.Value > 0)
                products.Add(new Product(1, "Frozen vegetables", (int)noVegetables.Value, 100.0f));
            if (noSodas.Value > 0)
                products.Add(new Product(2, "Sodas", (int)noSodas.Value, 30.0f));
            if (noBread.Value > 0)
                products.Add(new Product(3, "Bread", (int)noBread.Value, 40.0f));
            store.products = products;
            Logger.Log(String.Format("The order of {0} has been saved", store.storeName));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QRAdapter adapter = new QRAdapter();
            adapter.SetStore(store);
            Logger.Log(String.Format("The QR image of {0} has been saved", store.storeName));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noVegetables_ValueChanged(object sender, EventArgs e)
        {            
            NumericUpDown num = (NumericUpDown)sender;
            if (auxVegetables > num.Value)
            {
                Logger.Log(String.Format("The amount of vegetables for {0} has decreased to {1} pieces", store.storeName, num.Value));
                auxVegetables = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("The amount of vegetables for {0} has increased to {1} pieces", store.storeName, num.Value));                
                auxVegetables = (int)num.Value;
            }
        }

        private void noSodas_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (auxSodas > num.Value)
            {
                Logger.Log(String.Format("The amount of sodas for {0} has decreased to {1} pieces", store.storeName, num.Value));
                auxSodas = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("The amount of sodas for {0} has increased to {1} pieces", store.storeName, num.Value));
                auxSodas = (int)num.Value;
            }
        }

        private void noBread_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (auxBread > num.Value)
            {
                Logger.Log(String.Format("The amount of bread for {0} has decreased to {1} pieces", store.storeName, num.Value));
                auxBread = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("The amount of bread for {0} has increased to {1} pieces", store.storeName, num.Value));
                auxBread = (int)num.Value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
