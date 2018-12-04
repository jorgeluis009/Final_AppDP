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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVegetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_AppDP.Properties.Resources.Vegetables;
            this.pictureBox3.Location = new System.Drawing.Point(52, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_AppDP.Properties.Resources.Soda;
            this.pictureBox2.Location = new System.Drawing.Point(52, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_AppDP.Properties.Resources.Bread;
            this.pictureBox1.Location = new System.Drawing.Point(40, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numVegetable
            // 
            this.numVegetable.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVegetable.Location = new System.Drawing.Point(188, 54);
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
            this.numSoda.Location = new System.Drawing.Point(188, 156);
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
            this.numBread.Location = new System.Drawing.Point(188, 258);
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
            this.btnSimulate.Location = new System.Drawing.Point(326, 258);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(84, 23);
            this.btnSimulate.TabIndex = 6;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Enabled = false;
            this.btnDeliver.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.Location = new System.Drawing.Point(188, 287);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(222, 23);
            this.btnDeliver.TabIndex = 7;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vegetables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sodas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bread";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(322, 54);
            this.lblRes.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 19);
            this.lblRes.TabIndex = 11;
            // 
            // Deliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 324);
            this.Controls.Add(this.lblRes);
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
            this.Name = "Deliver";
            this.Text = "Deliver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVegetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).EndInit();
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
    }
}