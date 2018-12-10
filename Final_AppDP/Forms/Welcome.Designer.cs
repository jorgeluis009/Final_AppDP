namespace Final_AppDP
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitFullScreen = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOptions = new System.Windows.Forms.Button();
            this.btnDeliver1 = new System.Windows.Forms.Button();
            this.btnReadQR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar QR de prueba sin productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvStores
            // 
            this.dgvStores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Location = new System.Drawing.Point(219, 41);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.Size = new System.Drawing.Size(376, 438);
            this.dgvStores.TabIndex = 5;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.btnExitFullScreen);
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnFullScreen);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(608, 35);
            this.TopPanel.TabIndex = 8;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "QR Scanner App";
            // 
            // btnExitFullScreen
            // 
            this.btnExitFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFullScreen.Image")));
            this.btnExitFullScreen.Location = new System.Drawing.Point(541, 7);
            this.btnExitFullScreen.Name = "btnExitFullScreen";
            this.btnExitFullScreen.Size = new System.Drawing.Size(24, 24);
            this.btnExitFullScreen.TabIndex = 3;
            this.btnExitFullScreen.TabStop = false;
            this.btnExitFullScreen.Visible = false;
            this.btnExitFullScreen.Click += new System.EventHandler(this.btnExitFullScreen_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(509, 7);
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
            this.btnFullScreen.Location = new System.Drawing.Point(540, 7);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(24, 24);
            this.btnFullScreen.TabIndex = 1;
            this.btnFullScreen.TabStop = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(571, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.btnLogOptions);
            this.panel1.Controls.Add(this.btnDeliver1);
            this.panel1.Controls.Add(this.btnReadQR);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 456);
            this.panel1.TabIndex = 9;
            // 
            // btnLogOptions
            // 
            this.btnLogOptions.FlatAppearance.BorderSize = 0;
            this.btnLogOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOptions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOptions.Image")));
            this.btnLogOptions.Location = new System.Drawing.Point(12, 342);
            this.btnLogOptions.Name = "btnLogOptions";
            this.btnLogOptions.Size = new System.Drawing.Size(173, 102);
            this.btnLogOptions.TabIndex = 13;
            this.btnLogOptions.Text = "Log Options";
            this.btnLogOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOptions.UseVisualStyleBackColor = true;
            this.btnLogOptions.Click += new System.EventHandler(this.btnLogOptions_Click);
            // 
            // btnDeliver1
            // 
            this.btnDeliver1.FlatAppearance.BorderSize = 0;
            this.btnDeliver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliver1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeliver1.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliver1.Image")));
            this.btnDeliver1.Location = new System.Drawing.Point(12, 234);
            this.btnDeliver1.Name = "btnDeliver1";
            this.btnDeliver1.Size = new System.Drawing.Size(173, 102);
            this.btnDeliver1.TabIndex = 12;
            this.btnDeliver1.Text = "Deliver";
            this.btnDeliver1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeliver1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeliver1.UseVisualStyleBackColor = true;
            this.btnDeliver1.Click += new System.EventHandler(this.btnDeliver1_Click);
            // 
            // btnReadQR
            // 
            this.btnReadQR.FlatAppearance.BorderSize = 0;
            this.btnReadQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadQR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadQR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadQR.Image = ((System.Drawing.Image)(resources.GetObject("btnReadQR.Image")));
            this.btnReadQR.Location = new System.Drawing.Point(12, 126);
            this.btnReadQR.Name = "btnReadQR";
            this.btnReadQR.Size = new System.Drawing.Size(173, 102);
            this.btnReadQR.TabIndex = 11;
            this.btnReadQR.Text = "Read QR codes";
            this.btnReadQR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReadQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReadQR.UseVisualStyleBackColor = true;
            this.btnReadQR.Click += new System.EventHandler(this.btnReadQR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(608, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.dgvStores);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnFullScreen;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExitFullScreen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReadQR;
        private System.Windows.Forms.Button btnLogOptions;
        private System.Windows.Forms.Button btnDeliver1;
        private System.Windows.Forms.Label label1;
    }
}

