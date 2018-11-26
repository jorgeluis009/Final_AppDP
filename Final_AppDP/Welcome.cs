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
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;            
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            QRDecoder QRCodeDecoder = new QRDecoder();
            BindingList<Store> stores = new BindingList<Store>();
            string order = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in open.FileNames)
                {
                    Bitmap QRImg = new Bitmap(file);                                      
                    byte[][] DataByteArray = QRCodeDecoder.ImageDecoder(QRImg);
                    try
                    {                        
                        string Result = QRCode.ByteArrayToStr(DataByteArray[0]);
                        order += Result + "\n";                                         
                        Store store = JsonConvert.DeserializeObject<Store>(Result);
                        stores.Add(store);
                        QRImg.Dispose();
                    }
                    catch (Exception ex){ label3.Text = ex.Message; }
                }
            }
            open.Dispose();
            GC.Collect();
            foreach(Store store in stores)
            {
                if (store.products == null)
                {
                    MakeOrder make = new MakeOrder(store);
                    make.ShowDialog();
                }
            }
            label3.Text = order;            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            Store auxStore = new Store(1, "Walmart");
            string output = JsonConvert.SerializeObject(auxStore);
            QREncoder QRCodeEncoder = new QREncoder();
            QRCodeEncoder.Encode(ErrorCorrection.M, output);
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);
            FileStream FS = new FileStream(auxStore.storeName + ".png", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            QRCodeImage.Save(FS, ImageFormat.Png);
            FS.Close();
        }
    }
}
