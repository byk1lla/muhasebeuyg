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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.musteriBtn = new System.Windows.Forms.Button();
            this.siparisBtn = new System.Windows.Forms.Button();
            this.noteArea = new System.Windows.Forms.RichTextBox();
            this.newNotebtn = new System.Windows.Forms.Button();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userActivityGB = new System.Windows.Forms.GroupBox();
            this.siparisLBL = new System.Windows.Forms.Label();
            this.activityLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mailLBL = new System.Windows.Forms.Label();
            this.displayNote = new System.Windows.Forms.CheckBox();
            this.notePanel = new System.Windows.Forms.Panel();
            this.klasorAcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.adminBtn = new System.Windows.Forms.Button();
            this.userActivityGB.SuspendLayout();
            this.notePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriBtn
            // 
            this.musteriBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musteriBtn.Location = new System.Drawing.Point(12, 424);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(99, 25);
            this.musteriBtn.TabIndex = 0;
            this.musteriBtn.Text = "Müşteri";
            this.musteriBtn.UseVisualStyleBackColor = true;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // siparisBtn
            // 
            this.siparisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siparisBtn.Location = new System.Drawing.Point(117, 425);
            this.siparisBtn.Name = "siparisBtn";
            this.siparisBtn.Size = new System.Drawing.Size(102, 25);
            this.siparisBtn.TabIndex = 1;
            this.siparisBtn.Text = "Sipariş";
            this.siparisBtn.UseVisualStyleBackColor = true;
            this.siparisBtn.Click += new System.EventHandler(this.siparisBtn_Click);
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
            this.noteArea.MouseEnter += new System.EventHandler(this.noteArea_MouseEnter);
            this.noteArea.MouseLeave += new System.EventHandler(this.noteArea_MouseLeave);
            this.noteArea.MouseHover += new System.EventHandler(this.noteArea_MouseHover);
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
            this.userActivityGB.Controls.Add(this.siparisLBL);
            this.userActivityGB.Controls.Add(this.activityLBL);
            this.userActivityGB.Controls.Add(this.label11);
            this.userActivityGB.Controls.Add(this.label6);
            this.userActivityGB.Controls.Add(this.label8);
            this.userActivityGB.Controls.Add(this.label13);
            this.userActivityGB.Controls.Add(this.label10);
            this.userActivityGB.ForeColor = System.Drawing.Color.White;
            this.userActivityGB.Location = new System.Drawing.Point(392, 14);
            this.userActivityGB.Name = "userActivityGB";
            this.userActivityGB.Size = new System.Drawing.Size(341, 85);
            this.userActivityGB.TabIndex = 5;
            this.userActivityGB.TabStop = false;
            this.userActivityGB.Text = "En Son Yapılan İşlemler";
            this.userActivityGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // siparisLBL
            // 
            this.siparisLBL.AutoSize = true;
            this.siparisLBL.Location = new System.Drawing.Point(81, 51);
            this.siparisLBL.Name = "siparisLBL";
            this.siparisLBL.Size = new System.Drawing.Size(0, 14);
            this.siparisLBL.TabIndex = 3;
            // 
            // activityLBL
            // 
            this.activityLBL.AutoSize = true;
            this.activityLBL.Location = new System.Drawing.Point(81, 27);
            this.activityLBL.Name = "activityLBL";
            this.activityLBL.Size = new System.Drawing.Size(0, 14);
            this.activityLBL.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Son Sipariş -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Son Eylem -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 14);
            this.label13.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 14);
            this.label10.TabIndex = 0;
            // 
            // mailLBL
            // 
            this.mailLBL.AutoSize = true;
            this.mailLBL.ForeColor = System.Drawing.Color.White;
            this.mailLBL.Location = new System.Drawing.Point(409, 112);
            this.mailLBL.Name = "mailLBL";
            this.mailLBL.Size = new System.Drawing.Size(0, 14);
            this.mailLBL.TabIndex = 0;
            this.mailLBL.Click += new System.EventHandler(this.label13_Click);
            // 
            // displayNote
            // 
            this.displayNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayNote.AutoSize = true;
            this.displayNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayNote.ForeColor = System.Drawing.Color.White;
            this.displayNote.Location = new System.Drawing.Point(12, 391);
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
            this.button1.Location = new System.Drawing.Point(225, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürünler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dateLBL.Location = new System.Drawing.Point(29, 13);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(0, 18);
            this.dateLBL.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adminBtn
            // 
            this.adminBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminBtn.Location = new System.Drawing.Point(631, 424);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(102, 25);
            this.adminBtn.TabIndex = 10;
            this.adminBtn.Text = "Admin Menü";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Visible = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.displayNote);
            this.Controls.Add(this.userActivityGB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siparisBtn);
            this.Controls.Add(this.mailLBL);
            this.Controls.Add(this.musteriBtn);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(761, 501);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.userActivityGB.ResumeLayout(false);
            this.userActivityGB.PerformLayout();
            this.notePanel.ResumeLayout(false);
            this.notePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button siparisBtn;
        private System.Windows.Forms.RichTextBox noteArea;
        private System.Windows.Forms.Button newNotebtn;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox userActivityGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label mailLBL;
        private System.Windows.Forms.CheckBox displayNote;
        private System.Windows.Forms.Panel notePanel;
        private System.Windows.Forms.Label activityLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button klasorAcBtn;
        private System.Windows.Forms.Label siparisLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button adminBtn;
    }
}

