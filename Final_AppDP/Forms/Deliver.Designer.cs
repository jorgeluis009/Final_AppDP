namespace Final_AppDP
{
    partial class Deliver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deliver));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numVegetable = new System.Windows.Forms.NumericUpDown();
            this.numSoda = new System.Windows.Forms.NumericUpDown();
            this.numBread = new System.Windows.Forms.NumericUpDown();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExitFullScreen = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKImage = new System.Windows.Forms.PictureBox();
            this.NOTImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVegetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OKImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_AppDP.Properties.Resources.Vegetables;
            this.pictureBox3.Location = new System.Drawing.Point(29, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_AppDP.Properties.Resources.Soda;
            this.pictureBox2.Location = new System.Drawing.Point(29, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_AppDP.Properties.Resources.Bread;
            this.pictureBox1.Location = new System.Drawing.Point(17, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numVegetable
            // 
            this.numVegetable.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVegetable.Location = new System.Drawing.Point(165, 83);
            this.numVegetable.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numVegetable.Name = "numVegetable";
            this.numVegetable.Size = new System.Drawing.Size(120, 24);
            this.numVegetable.TabIndex = 3;
            this.numVegetable.ValueChanged += new System.EventHandler(this.numVegetable_ValueChanged);
            // 
            // numSoda
            // 
            this.numSoda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoda.Location = new System.Drawing.Point(165, 185);
            this.numSoda.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSoda.Name = "numSoda";
            this.numSoda.Size = new System.Drawing.Size(120, 24);
            this.numSoda.TabIndex = 4;
            this.numSoda.ValueChanged += new System.EventHandler(this.numSoda_ValueChanged);
            // 
            // numBread
            // 
            this.numBread.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBread.Location = new System.Drawing.Point(165, 287);
            this.numBread.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBread.Name = "numBread";
            this.numBread.Size = new System.Drawing.Size(120, 24);
            this.numBread.TabIndex = 5;
            this.numBread.ValueChanged += new System.EventHandler(this.numBread_ValueChanged);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.Location = new System.Drawing.Point(148, 345);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(155, 51);
            this.btnSimulate.TabIndex = 6;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Enabled = false;
            this.btnDeliver.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.Location = new System.Drawing.Point(321, 345);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(155, 51);
            this.btnDeliver.TabIndex = 7;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vegetables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sodas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bread";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(3, 12);
            this.lblRes.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 19);
            this.lblRes.TabIndex = 11;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.btnExitFullScreen);
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnFullScreen);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(562, 35);
            this.TopPanel.TabIndex = 12;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deliver";
            // 
            // btnExitFullScreen
            // 
            this.btnExitFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFullScreen.Image")));
            this.btnExitFullScreen.Location = new System.Drawing.Point(495, 7);
            this.btnExitFullScreen.Name = "btnExitFullScreen";
            this.btnExitFullScreen.Size = new System.Drawing.Size(24, 24);
            this.btnExitFullScreen.TabIndex = 3;
            this.btnExitFullScreen.TabStop = false;
            this.btnExitFullScreen.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(463, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(494, 7);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(24, 24);
            this.btnFullScreen.TabIndex = 1;
            this.btnFullScreen.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(525, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRes);
            this.panel1.Location = new System.Drawing.Point(337, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 179);
            this.panel1.TabIndex = 14;
            // 
            // OKImage
            // 
            this.OKImage.Image = ((System.Drawing.Image)(resources.GetObject("OKImage.Image")));
            this.OKImage.Location = new System.Drawing.Point(425, 62);
            this.OKImage.Name = "OKImage";
            this.OKImage.Size = new System.Drawing.Size(24, 24);
            this.OKImage.TabIndex = 12;
            this.OKImage.TabStop = false;
            this.OKImage.Visible = false;
            // 
            // NOTImage
            // 
            this.NOTImage.Image = ((System.Drawing.Image)(resources.GetObject("NOTImage.Image")));
            this.NOTImage.Location = new System.Drawing.Point(425, 62);
            this.NOTImage.Name = "NOTImage";
            this.NOTImage.Size = new System.Drawing.Size(24, 24);
            this.NOTImage.TabIndex = 15;
            this.NOTImage.TabStop = false;
            this.NOTImage.Visible = false;
            // 
            // Deliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(562, 416);
            this.Controls.Add(this.NOTImage);
            this.Controls.Add(this.OKImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.numBread);
            this.Controls.Add(this.numSoda);
            this.Controls.Add(this.numVegetable);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deliver";
            this.Text = "Deliver";
            this.Load += new System.EventHandler(this.Deliver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVegetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OKImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown numVegetable;
        private System.Windows.Forms.NumericUpDown numSoda;
        private System.Windows.Forms.NumericUpDown numBread;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnExitFullScreen;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnFullScreen;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox OKImage;
        private System.Windows.Forms.PictureBox NOTImage;
    }
}