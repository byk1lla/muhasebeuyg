namespace butikunmuhasebe.API
{
    partial class addorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addorder));
            this.kaydetBTN = new System.Windows.Forms.Button();
            this.faturaAciklama = new System.Windows.Forms.RichTextBox();
            this.tarihDT = new System.Windows.Forms.DateTimePicker();
            this.urunCB = new System.Windows.Forms.ComboBox();
            this.musteriCB = new System.Windows.Forms.ComboBox();
            this.faturaP = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hesaplaBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toplamTXT = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.faturaM = new System.Windows.Forms.RichTextBox();
            this.faturaRO = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydetBTN
            // 
            this.kaydetBTN.Location = new System.Drawing.Point(131, 322);
            this.kaydetBTN.Name = "kaydetBTN";
            this.kaydetBTN.Size = new System.Drawing.Size(120, 23);
            this.kaydetBTN.TabIndex = 0;
            this.kaydetBTN.Text = "Kaydet";
            this.kaydetBTN.UseVisualStyleBackColor = true;
            this.kaydetBTN.Click += new System.EventHandler(this.kaydetBTN_Click);
            // 
            // faturaAciklama
            // 
            this.faturaAciklama.Location = new System.Drawing.Point(12, 203);
            this.faturaAciklama.Name = "faturaAciklama";
            this.faturaAciklama.Size = new System.Drawing.Size(239, 114);
            this.faturaAciklama.TabIndex = 2;
            this.faturaAciklama.Text = "";
            this.faturaAciklama.TextChanged += new System.EventHandler(this.faturaAciklama_TextChanged);
            // 
            // tarihDT
            // 
            this.tarihDT.Location = new System.Drawing.Point(12, 38);
            this.tarihDT.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.tarihDT.Name = "tarihDT";
            this.tarihDT.Size = new System.Drawing.Size(239, 20);
            this.tarihDT.TabIndex = 4;
            this.tarihDT.Value = new System.DateTime(2023, 7, 13, 0, 0, 0, 0);
            // 
            // urunCB
            // 
            this.urunCB.FormattingEnabled = true;
            this.urunCB.Location = new System.Drawing.Point(12, 156);
            this.urunCB.Name = "urunCB";
            this.urunCB.Size = new System.Drawing.Size(239, 21);
            this.urunCB.TabIndex = 5;
            this.urunCB.Text = "Ürün Seçin...";
            this.urunCB.SelectedIndexChanged += new System.EventHandler(this.urunCB_SelectedIndexChanged);
            // 
            // musteriCB
            // 
            this.musteriCB.FormattingEnabled = true;
            this.musteriCB.Location = new System.Drawing.Point(12, 99);
            this.musteriCB.Name = "musteriCB";
            this.musteriCB.Size = new System.Drawing.Size(239, 21);
            this.musteriCB.TabIndex = 6;
            this.musteriCB.Text = "Müşteri Seçin...";
            this.musteriCB.SelectedIndexChanged += new System.EventHandler(this.musteriCB_SelectedIndexChanged);
            // 
            // faturaP
            // 
            this.faturaP.Location = new System.Drawing.Point(19, 115);
            this.faturaP.Name = "faturaP";
            this.faturaP.ReadOnly = true;
            this.faturaP.Size = new System.Drawing.Size(288, 85);
            this.faturaP.TabIndex = 2;
            this.faturaP.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Seçin";
            // 
            // hesaplaBTN
            // 
            this.hesaplaBTN.Location = new System.Drawing.Point(12, 322);
            this.hesaplaBTN.Name = "hesaplaBTN";
            this.hesaplaBTN.Size = new System.Drawing.Size(113, 23);
            this.hesaplaBTN.TabIndex = 0;
            this.hesaplaBTN.Text = "Önizle";
            this.hesaplaBTN.UseVisualStyleBackColor = true;
            this.hesaplaBTN.Click += new System.EventHandler(this.hesaplaBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fatura Açıklaması";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toplamTXT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.faturaM);
            this.panel1.Controls.Add(this.faturaRO);
            this.panel1.Controls.Add(this.faturaP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(257, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 337);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toplamTXT
            // 
            this.toplamTXT.Location = new System.Drawing.Point(326, 33);
            this.toplamTXT.Name = "toplamTXT";
            this.toplamTXT.ReadOnly = true;
            this.toplamTXT.Size = new System.Drawing.Size(185, 291);
            this.toplamTXT.TabIndex = 14;
            this.toplamTXT.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(84, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fatura Açıklaması";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(127, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ürünler";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Müşteri";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faturaM
            // 
            this.faturaM.Location = new System.Drawing.Point(19, 33);
            this.faturaM.Name = "faturaM";
            this.faturaM.ReadOnly = true;
            this.faturaM.Size = new System.Drawing.Size(288, 56);
            this.faturaM.TabIndex = 2;
            this.faturaM.Text = "";
            // 
            // faturaRO
            // 
            this.faturaRO.Location = new System.Drawing.Point(20, 226);
            this.faturaRO.Name = "faturaRO";
            this.faturaRO.ReadOnly = true;
            this.faturaRO.Size = new System.Drawing.Size(288, 98);
            this.faturaRO.TabIndex = 2;
            this.faturaRO.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fatura Tarihi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(790, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musteriCB);
            this.Controls.Add(this.tarihDT);
            this.Controls.Add(this.urunCB);
            this.Controls.Add(this.faturaAciklama);
            this.Controls.Add(this.hesaplaBTN);
            this.Controls.Add(this.kaydetBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(806, 396);
            this.MinimumSize = new System.Drawing.Size(264, 396);
            this.Name = "addorder";
            this.Text = "Sipariş Oluştur";
            this.Load += new System.EventHandler(this.addorder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetBTN;
        private System.Windows.Forms.RichTextBox faturaAciklama;
        private System.Windows.Forms.DateTimePicker tarihDT;
        private System.Windows.Forms.ComboBox urunCB;
        private System.Windows.Forms.ComboBox musteriCB;
        private System.Windows.Forms.RichTextBox faturaP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hesaplaBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox faturaM;
        private System.Windows.Forms.RichTextBox faturaRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox toplamTXT;
    }
}