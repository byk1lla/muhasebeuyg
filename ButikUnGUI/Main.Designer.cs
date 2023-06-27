namespace butikunmuhasebe
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.siparisBtn = new System.Windows.Forms.Button();
            this.doviz = new System.Windows.Forms.GroupBox();
            this.sterlinLBL = new System.Windows.Forms.Label();
            this.euroLBL = new System.Windows.Forms.Label();
            this.dolarLBL = new System.Windows.Forms.Label();
            this.goldLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noteArea = new System.Windows.Forms.RichTextBox();
            this.newNotebtn = new System.Windows.Forms.Button();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userActivityGB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.displayNote = new System.Windows.Forms.CheckBox();
            this.notePanel = new System.Windows.Forms.Panel();
            this.klasorAcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.siparisGB = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.haftalikSiparisLBL = new System.Windows.Forms.Label();
            this.siparisToplamLBL = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.kazancGB = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.doviz.SuspendLayout();
            this.userActivityGB.SuspendLayout();
            this.notePanel.SuspendLayout();
            this.siparisGB.SuspendLayout();
            this.kazancGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriBtn
            // 
            this.musteriBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musteriBtn.Location = new System.Drawing.Point(12, 546);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(99, 25);
            this.musteriBtn.TabIndex = 0;
            this.musteriBtn.Text = "Müşteri";
            this.musteriBtn.UseVisualStyleBackColor = true;
            // 
            // siparisBtn
            // 
            this.siparisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siparisBtn.Location = new System.Drawing.Point(117, 547);
            this.siparisBtn.Name = "siparisBtn";
            this.siparisBtn.Size = new System.Drawing.Size(102, 25);
            this.siparisBtn.TabIndex = 1;
            this.siparisBtn.Text = "Sipariş";
            this.siparisBtn.UseVisualStyleBackColor = true;
            // 
            // doviz
            // 
            this.doviz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doviz.Controls.Add(this.sterlinLBL);
            this.doviz.Controls.Add(this.euroLBL);
            this.doviz.Controls.Add(this.dolarLBL);
            this.doviz.Controls.Add(this.goldLBL);
            this.doviz.Controls.Add(this.label7);
            this.doviz.Controls.Add(this.label5);
            this.doviz.Controls.Add(this.label3);
            this.doviz.Controls.Add(this.label1);
            this.doviz.ForeColor = System.Drawing.Color.White;
            this.doviz.Location = new System.Drawing.Point(698, 441);
            this.doviz.Name = "doviz";
            this.doviz.Size = new System.Drawing.Size(341, 131);
            this.doviz.TabIndex = 2;
            this.doviz.TabStop = false;
            this.doviz.Text = "Döviz Kurları";
            // 
            // sterlinLBL
            // 
            this.sterlinLBL.AutoSize = true;
            this.sterlinLBL.Location = new System.Drawing.Point(56, 100);
            this.sterlinLBL.Name = "sterlinLBL";
            this.sterlinLBL.Size = new System.Drawing.Size(0, 14);
            this.sterlinLBL.TabIndex = 1;
            // 
            // euroLBL
            // 
            this.euroLBL.AutoSize = true;
            this.euroLBL.Location = new System.Drawing.Point(56, 72);
            this.euroLBL.Name = "euroLBL";
            this.euroLBL.Size = new System.Drawing.Size(0, 14);
            this.euroLBL.TabIndex = 1;
            // 
            // dolarLBL
            // 
            this.dolarLBL.AutoSize = true;
            this.dolarLBL.Location = new System.Drawing.Point(56, 45);
            this.dolarLBL.Name = "dolarLBL";
            this.dolarLBL.Size = new System.Drawing.Size(0, 14);
            this.dolarLBL.TabIndex = 1;
            // 
            // goldLBL
            // 
            this.goldLBL.AutoSize = true;
            this.goldLBL.Location = new System.Drawing.Point(56, 19);
            this.goldLBL.Name = "goldLBL";
            this.goldLBL.Size = new System.Drawing.Size(0, 14);
            this.goldLBL.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sterlin -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Euro -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dolar -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altın -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // noteArea
            // 
            this.noteArea.Enabled = false;
            this.noteArea.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteArea.Location = new System.Drawing.Point(10, 32);
            this.noteArea.Name = "noteArea";
            this.noteArea.Size = new System.Drawing.Size(341, 234);
            this.noteArea.TabIndex = 3;
            this.noteArea.Text = "";
            this.noteArea.TextChanged += new System.EventHandler(this.noteArea_TextChanged);
            // 
            // newNotebtn
            // 
            this.newNotebtn.Location = new System.Drawing.Point(10, 274);
            this.newNotebtn.Name = "newNotebtn";
            this.newNotebtn.Size = new System.Drawing.Size(99, 25);
            this.newNotebtn.TabIndex = 0;
            this.newNotebtn.Text = "Yeni Not";
            this.newNotebtn.UseVisualStyleBackColor = true;
            this.newNotebtn.Click += new System.EventHandler(this.newNotebtn_Click);
            // 
            // deleteNoteBtn
            // 
            this.deleteNoteBtn.Location = new System.Drawing.Point(223, 274);
            this.deleteNoteBtn.Name = "deleteNoteBtn";
            this.deleteNoteBtn.Size = new System.Drawing.Size(102, 25);
            this.deleteNoteBtn.TabIndex = 1;
            this.deleteNoteBtn.Text = "Sil";
            this.deleteNoteBtn.UseVisualStyleBackColor = true;
            this.deleteNoteBtn.Click += new System.EventHandler(this.deleteNoteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Not Defteri";
            // 
            // userActivityGB
            // 
            this.userActivityGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userActivityGB.Controls.Add(this.label4);
            this.userActivityGB.Controls.Add(this.label6);
            this.userActivityGB.Controls.Add(this.label8);
            this.userActivityGB.Controls.Add(this.label9);
            this.userActivityGB.Controls.Add(this.label10);
            this.userActivityGB.Controls.Add(this.label13);
            this.userActivityGB.ForeColor = System.Drawing.Color.White;
            this.userActivityGB.Location = new System.Drawing.Point(698, 358);
            this.userActivityGB.Name = "userActivityGB";
            this.userActivityGB.Size = new System.Drawing.Size(341, 77);
            this.userActivityGB.TabIndex = 5;
            this.userActivityGB.TabStop = false;
            this.userActivityGB.Text = "En Son Yapılan İşlemler";
            this.userActivityGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Son Eylem -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 14);
            this.label9.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 14);
            this.label10.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Son Giriş -";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Location = new System.Drawing.Point(937, 14);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(102, 25);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.Text = "Ayarlar";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // displayNote
            // 
            this.displayNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayNote.AutoSize = true;
            this.displayNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayNote.ForeColor = System.Drawing.Color.White;
            this.displayNote.Location = new System.Drawing.Point(12, 513);
            this.displayNote.Name = "displayNote";
            this.displayNote.Size = new System.Drawing.Size(135, 18);
            this.displayNote.TabIndex = 7;
            this.displayNote.Text = "Not Defterini Görüntüle";
            this.displayNote.UseVisualStyleBackColor = true;
            this.displayNote.CheckedChanged += new System.EventHandler(this.displayNote_CheckedChanged);
            // 
            // notePanel
            // 
            this.notePanel.Controls.Add(this.klasorAcBtn);
            this.notePanel.Controls.Add(this.label2);
            this.notePanel.Controls.Add(this.noteArea);
            this.notePanel.Controls.Add(this.deleteNoteBtn);
            this.notePanel.Controls.Add(this.newNotebtn);
            this.notePanel.Location = new System.Drawing.Point(13, 66);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(364, 311);
            this.notePanel.TabIndex = 8;
            // 
            // klasorAcBtn
            // 
            this.klasorAcBtn.Location = new System.Drawing.Point(115, 274);
            this.klasorAcBtn.Name = "klasorAcBtn";
            this.klasorAcBtn.Size = new System.Drawing.Size(102, 25);
            this.klasorAcBtn.TabIndex = 5;
            this.klasorAcBtn.Text = "Klasöre Git";
            this.klasorAcBtn.UseVisualStyleBackColor = true;
            this.klasorAcBtn.Click += new System.EventHandler(this.klasorAcBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(225, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürünler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // siparisGB
            // 
            this.siparisGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisGB.Controls.Add(this.label14);
            this.siparisGB.Controls.Add(this.haftalikSiparisLBL);
            this.siparisGB.Controls.Add(this.siparisToplamLBL);
            this.siparisGB.Controls.Add(this.label17);
            this.siparisGB.Controls.Add(this.label18);
            this.siparisGB.ForeColor = System.Drawing.Color.White;
            this.siparisGB.Location = new System.Drawing.Point(698, 254);
            this.siparisGB.Name = "siparisGB";
            this.siparisGB.Size = new System.Drawing.Size(341, 98);
            this.siparisGB.TabIndex = 5;
            this.siparisGB.TabStop = false;
            this.siparisGB.Text = "Siparişler";
            this.siparisGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "Haftalık Sipariş Sayısı -";
            // 
            // haftalikSiparisLBL
            // 
            this.haftalikSiparisLBL.AutoSize = true;
            this.haftalikSiparisLBL.Location = new System.Drawing.Point(129, 55);
            this.haftalikSiparisLBL.Name = "haftalikSiparisLBL";
            this.haftalikSiparisLBL.Size = new System.Drawing.Size(0, 14);
            this.haftalikSiparisLBL.TabIndex = 1;
            // 
            // siparisToplamLBL
            // 
            this.siparisToplamLBL.AutoSize = true;
            this.siparisToplamLBL.Location = new System.Drawing.Point(181, 34);
            this.siparisToplamLBL.Name = "siparisToplamLBL";
            this.siparisToplamLBL.Size = new System.Drawing.Size(0, 14);
            this.siparisToplamLBL.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 14);
            this.label17.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tüm Zamanlardaki Sipariş Sayısı -\r\n";
            this.label18.Click += new System.EventHandler(this.label13_Click);
            // 
            // kazancGB
            // 
            this.kazancGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kazancGB.Controls.Add(this.label11);
            this.kazancGB.Controls.Add(this.label12);
            this.kazancGB.Controls.Add(this.label15);
            this.kazancGB.Controls.Add(this.label16);
            this.kazancGB.Controls.Add(this.label19);
            this.kazancGB.ForeColor = System.Drawing.Color.White;
            this.kazancGB.Location = new System.Drawing.Point(698, 150);
            this.kazancGB.Name = "kazancGB";
            this.kazancGB.Size = new System.Drawing.Size(341, 98);
            this.kazancGB.TabIndex = 5;
            this.kazancGB.TabStop = false;
            this.kazancGB.Text = "Kazanç";
            this.kazancGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Haftalık Toplam Hasılat -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 14);
            this.label12.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 14);
            this.label15.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 14);
            this.label16.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tüm Zamanlardaki Toplam Hasılat -";
            this.label19.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateLBL);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 46);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.dateLBL.ForeColor = System.Drawing.Color.White;
            this.dateLBL.Location = new System.Drawing.Point(166, 13);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(0, 18);
            this.dateLBL.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1051, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.displayNote);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.kazancGB);
            this.Controls.Add(this.siparisGB);
            this.Controls.Add(this.userActivityGB);
            this.Controls.Add(this.doviz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siparisBtn);
            this.Controls.Add(this.musteriBtn);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.doviz.ResumeLayout(false);
            this.doviz.PerformLayout();
            this.userActivityGB.ResumeLayout(false);
            this.userActivityGB.PerformLayout();
            this.notePanel.ResumeLayout(false);
            this.notePanel.PerformLayout();
            this.siparisGB.ResumeLayout(false);
            this.siparisGB.PerformLayout();
            this.kazancGB.ResumeLayout(false);
            this.kazancGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button siparisBtn;
        private System.Windows.Forms.GroupBox doviz;
        private System.Windows.Forms.Label euroLBL;
        private System.Windows.Forms.Label dolarLBL;
        private System.Windows.Forms.Label goldLBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox noteArea;
        private System.Windows.Forms.Button newNotebtn;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox userActivityGB;
        private System.Windows.Forms.Label sterlinLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.CheckBox displayNote;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox siparisGB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label siparisToplamLBL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label haftalikSiparisLBL;
        private System.Windows.Forms.GroupBox kazancGB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button klasorAcBtn;
    }
}

