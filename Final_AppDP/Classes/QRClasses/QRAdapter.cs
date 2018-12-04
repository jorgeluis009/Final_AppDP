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

namespace Final_AppDP.Classes
{
    public class QRAdapter : QRTarget
    {
        public override Store GetStore(string file)
        {
            QRDecoder QRCodeDecoder = new QRDecoder();
            Bitmap QRImg = new Bitmap(file);
            byte[][] DataByteArray = QRCodeDecoder.ImageDecoder(QRImg);
            try
            {
                string Result = QRCode.ByteArrayToStr(DataByteArray[0]);                
                Store store = JsonConvert.DeserializeObject<Store>(Result);                
                QRImg.Dispose();
                return store;
            }
            catch (Exception) { return null; }
        }

        public override void SetStore(Store store)
        {
            string output = JsonConvert.SerializeObject(store);
            QREncoder QRCodeEncoder = new QREncoder();
            QRCodeEncoder.Encode(ErrorCorrection.M, output);
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);
            FileStream FS = new FileStream(store.storeName + ".png", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            QRCodeImage.Save(FS, ImageFormat.Png);
            FS.Close();
        }
    }
}
