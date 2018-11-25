﻿using System;
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
            BindingList<string> orders = new BindingList<string>();
            string order = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in open.FileNames)
                {
                    Bitmap QRImg = new Bitmap(file);
                    //pictureBox1.Image = new Bitmap(QRImg);                    
                    byte[][] DataByteArray = QRCodeDecoder.ImageDecoder(QRImg);
                    try
                    {                        
                        string Result = QRCode.ByteArrayToStr(DataByteArray[0]);
                        order += Result + "\n";
                        orders.Add(Result);                        
                    }
                    catch (Exception){ }
                }
            }
            label3.Text = order;                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QREncoder QRCodeEncoder = new QREncoder();            
            QRCodeEncoder.Encode(ErrorCorrection.M, "This is a message, hello.");            
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);            
            FileStream FS = new FileStream("TestQR.png", FileMode.Create);
            QRCodeImage.Save(FS, ImageFormat.Png);
            FS.Close();
        }
    }
}
