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
    public partial class MakeOrder : Form
    {
        Store auxStore;

        public MakeOrder(Store store)
        {
            InitializeComponent();
            auxStore = store;
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            lblStore.Text = auxStore.storeName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BindingList<Product> products = new BindingList<Product>();
            if (noVegetables.Value > 0)
                products.Add(new Product(1, "Frozen vegetables", (int)noVegetables.Value));
            if (noSodas.Value > 0)
                products.Add(new Product(2, "Sodas", (int)noSodas.Value));
            if (noBread.Value > 0)
                products.Add(new Product(3, "Bread", (int)noBread.Value));
            auxStore.products = products;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(auxStore);
            QREncoder QRCodeEncoder = new QREncoder();
            QRCodeEncoder.Encode(ErrorCorrection.M, output);
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);
            FileStream FS = new FileStream(auxStore.storeName + ".png", FileMode.Create);
            QRCodeImage.Save(FS, ImageFormat.Png);
            FS.Close();
        }
    }
}
