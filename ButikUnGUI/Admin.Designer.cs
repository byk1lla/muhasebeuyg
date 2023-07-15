namespace butikunmuhasebe.ButikUnGUI
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.ekleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.urunData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musteriData = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(13, 187);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(335, 39);
            this.ekleBtn.TabIndex = 1;
            this.ekleBtn.Text = "Kullanıcı Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.musteriData);
            this.groupBox1.Controls.Add(this.userData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.siparisData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş -";
            // 
            // siparisData
            // 
            this.siparisData.AutoSize = true;
            this.siparisData.Location = new System.Drawing.Point(79, 39);
            this.siparisData.Name = "siparisData";
            this.siparisData.Size = new System.Drawing.Size(0, 16);
            this.siparisData.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı -";
            // 
            // userData
            // 
            this.userData.AutoSize = true;
            this.userData.Location = new System.Drawing.Point(86, 100);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(0, 16);
            this.userData.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün -";
            // 
            // urunData
            // 
            this.urunData.AutoSize = true;
            this.urunData.Location = new System.Drawing.Point(73, 71);
            this.urunData.Name = "urunData";
            this.urunData.Size = new System.Drawing.Size(0, 16);
            this.urunData.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri -";
            // 
            // musteriData
            // 
            this.musteriData.AutoSize = true;
            this.musteriData.Location = new System.Drawing.Point(86, 128);
            this.musteriData.Name = "musteriData";
            this.musteriData.Size = new System.Drawing.Size(0, 16);
            this.musteriData.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(360, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ekleBtn);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(376, 277);
            this.MinimumSize = new System.Drawing.Size(376, 277);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label urunData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label siparisData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label musteriData;
        private System.Windows.Forms.Label label2;
    }
}