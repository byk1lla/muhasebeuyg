namespace butikunmuhasebe.API
{
    partial class addproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproduct));
            this.label4 = new System.Windows.Forms.Label();
            this.TLfiyat = new System.Windows.Forms.TextBox();
            this.urunText = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KRSFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.capTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyatı";
            // 
            // TLfiyat
            // 
            this.TLfiyat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TLfiyat.Location = new System.Drawing.Point(65, 153);
            this.TLfiyat.Name = "TLfiyat";
            this.TLfiyat.Size = new System.Drawing.Size(182, 20);
            this.TLfiyat.TabIndex = 5;
            // 
            // urunText
            // 
            this.urunText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.urunText.Location = new System.Drawing.Point(65, 35);
            this.urunText.Name = "urunText";
            this.urunText.Size = new System.Drawing.Size(220, 20);
            this.urunText.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.Location = new System.Drawing.Point(187, 183);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(65, 183);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TL";
            // 
            // KRSFiyat
            // 
            this.KRSFiyat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.KRSFiyat.Location = new System.Drawing.Point(244, 153);
            this.KRSFiyat.MaxLength = 2;
            this.KRSFiyat.Name = "KRSFiyat";
            this.KRSFiyat.Size = new System.Drawing.Size(41, 20);
            this.KRSFiyat.TabIndex = 5;
            this.KRSFiyat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = ",";
            // 
            // turCB
            // 
            this.turCB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.turCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.turCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.turCB.FormattingEnabled = true;
            this.turCB.Location = new System.Drawing.Point(65, 113);
            this.turCB.Name = "turCB";
            this.turCB.Size = new System.Drawing.Size(220, 21);
            this.turCB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Susamlı/Susamsız";
            // 
            // capTXT
            // 
            this.capTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.capTXT.Location = new System.Drawing.Point(65, 74);
            this.capTXT.Name = "capTXT";
            this.capTXT.Size = new System.Drawing.Size(220, 20);
            this.capTXT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Çapı";
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(351, 232);
            this.Controls.Add(this.KRSFiyat);
            this.Controls.Add(this.turCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TLfiyat);
            this.Controls.Add(this.capTXT);
            this.Controls.Add(this.urunText);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 220);
            this.Name = "addproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TLfiyat;
        private System.Windows.Forms.TextBox urunText;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KRSFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capTXT;
        private System.Windows.Forms.Label label6;
    }
}