namespace butikunmuhasebe.Admin
{
    partial class adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduser));
            this.adTXT = new System.Windows.Forms.TextBox();
            this.soyadTXT = new System.Windows.Forms.TextBox();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.passwdTXT = new System.Windows.Forms.TextBox();
            this.yetkiCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.ekleBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adTXT
            // 
            this.adTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adTXT.Location = new System.Drawing.Point(55, 63);
            this.adTXT.Name = "adTXT";
            this.adTXT.Size = new System.Drawing.Size(217, 24);
            this.adTXT.TabIndex = 0;
            this.adTXT.TextChanged += new System.EventHandler(this.adTXT_TextChanged);
            // 
            // soyadTXT
            // 
            this.soyadTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.soyadTXT.Location = new System.Drawing.Point(55, 114);
            this.soyadTXT.Name = "soyadTXT";
            this.soyadTXT.Size = new System.Drawing.Size(217, 24);
            this.soyadTXT.TabIndex = 0;
            this.soyadTXT.TextChanged += new System.EventHandler(this.soyadTXT_TextChanged);
            // 
            // usernameTXT
            // 
            this.usernameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTXT.Location = new System.Drawing.Point(55, 170);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(217, 24);
            this.usernameTXT.TabIndex = 0;
            // 
            // passwdTXT
            // 
            this.passwdTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwdTXT.Location = new System.Drawing.Point(55, 225);
            this.passwdTXT.Name = "passwdTXT";
            this.passwdTXT.PasswordChar = '*';
            this.passwdTXT.Size = new System.Drawing.Size(217, 24);
            this.passwdTXT.TabIndex = 0;
            // 
            // yetkiCBX
            // 
            this.yetkiCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yetkiCBX.FormattingEnabled = true;
            this.yetkiCBX.Items.AddRange(new object[] {
            "Yetki Seçin...",
            "Admin",
            "User"});
            this.yetkiCBX.Location = new System.Drawing.Point(55, 283);
            this.yetkiCBX.Name = "yetkiCBX";
            this.yetkiCBX.Size = new System.Drawing.Size(217, 24);
            this.yetkiCBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yetki";
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(161, 325);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(111, 26);
            this.iptalBtn.TabIndex = 3;
            this.iptalBtn.Text = "iptal";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // ekleBTN
            // 
            this.ekleBTN.Location = new System.Drawing.Point(55, 325);
            this.ekleBTN.Name = "ekleBTN";
            this.ekleBTN.Size = new System.Drawing.Size(100, 26);
            this.ekleBTN.TabIndex = 3;
            this.ekleBTN.Text = "Ekle";
            this.ekleBTN.UseVisualStyleBackColor = true;
            this.ekleBTN.Click += new System.EventHandler(this.ekleBTN_Click);
            // 
            // adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(334, 408);
            this.Controls.Add(this.ekleBTN);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetkiCBX);
            this.Controls.Add(this.passwdTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.soyadTXT);
            this.Controls.Add(this.adTXT);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(350, 447);
            this.MinimumSize = new System.Drawing.Size(350, 447);
            this.Name = "adduser";
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.adduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adTXT;
        private System.Windows.Forms.TextBox soyadTXT;
        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.TextBox passwdTXT;
        private System.Windows.Forms.ComboBox yetkiCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button ekleBTN;
    }
}