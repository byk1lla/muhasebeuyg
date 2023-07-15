namespace butikunmuhasebe.ButikUnGUI
{
    partial class siparis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparis));
            this.siparisGB = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.haftalikSiparisLBL = new System.Windows.Forms.Label();
            this.haftalikLBL = new System.Windows.Forms.Label();
            this.siparisToplamLBL = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.excelBtn = new System.Windows.Forms.Button();
            this.tarihCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaDataSet = new butikunmuhasebe.faturaDataSet();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturaTableAdapter = new butikunmuhasebe.faturaDataSetTableAdapters.faturaTableAdapter();
            this.tarihData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisGB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisGB
            // 
            this.siparisGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisGB.Controls.Add(this.label14);
            this.siparisGB.Controls.Add(this.haftalikSiparisLBL);
            this.siparisGB.Controls.Add(this.haftalikLBL);
            this.siparisGB.Controls.Add(this.siparisToplamLBL);
            this.siparisGB.Controls.Add(this.label17);
            this.siparisGB.Controls.Add(this.label18);
            this.siparisGB.ForeColor = System.Drawing.Color.White;
            this.siparisGB.Location = new System.Drawing.Point(769, 419);
            this.siparisGB.Name = "siparisGB";
            this.siparisGB.Size = new System.Drawing.Size(341, 99);
            this.siparisGB.TabIndex = 6;
            this.siparisGB.TabStop = false;
            this.siparisGB.Text = "Siparişler";
            this.siparisGB.Enter += new System.EventHandler(this.siparisGB_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Bu Hafta Verilen Sipariş Sayısı -";
            // 
            // haftalikSiparisLBL
            // 
            this.haftalikSiparisLBL.AutoSize = true;
            this.haftalikSiparisLBL.Location = new System.Drawing.Point(129, 55);
            this.haftalikSiparisLBL.Name = "haftalikSiparisLBL";
            this.haftalikSiparisLBL.Size = new System.Drawing.Size(0, 13);
            this.haftalikSiparisLBL.TabIndex = 1;
            // 
            // haftalikLBL
            // 
            this.haftalikLBL.AutoSize = true;
            this.haftalikLBL.Location = new System.Drawing.Point(167, 68);
            this.haftalikLBL.Name = "haftalikLBL";
            this.haftalikLBL.Size = new System.Drawing.Size(0, 13);
            this.haftalikLBL.TabIndex = 1;
            // 
            // siparisToplamLBL
            // 
            this.siparisToplamLBL.AutoSize = true;
            this.siparisToplamLBL.Location = new System.Drawing.Point(181, 34);
            this.siparisToplamLBL.Name = "siparisToplamLBL";
            this.siparisToplamLBL.Size = new System.Drawing.Size(0, 13);
            this.siparisToplamLBL.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tüm Zamanlardaki Sipariş Sayısı -\r\n";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(824, 541);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(140, 29);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Yeni Sipariş";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(970, 541);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(140, 29);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Yenile";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 541);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(140, 29);
            this.openBtn.TabIndex = 7;
            this.openBtn.Text = "Aç";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(158, 541);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 29);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(678, 541);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(140, 29);
            this.excelBtn.TabIndex = 7;
            this.excelBtn.Text = "Excel\'e Aktar";
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // tarihCB
            // 
            this.tarihCB.FormattingEnabled = true;
            this.tarihCB.Items.AddRange(new object[] {
            "Bugün",
            "Dün",
            "1 Hafta Önce",
            "1 Ay Önce",
            "1 Yıl Önce",
            "Tüm Zamanlar"});
            this.tarihCB.Location = new System.Drawing.Point(23, 466);
            this.tarihCB.Name = "tarihCB";
            this.tarihCB.Size = new System.Drawing.Size(275, 21);
            this.tarihCB.TabIndex = 8;
            this.tarihCB.Text = "Bir Tarih Seçin...";
            this.tarihCB.SelectedIndexChanged += new System.EventHandler(this.tarihCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tarih";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 410);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihData,
            this.idData,
            this.faturaNoData,
            this.musteriData,
            this.urunlerData,
            this.faturaData,
            this.tutarData});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.faturaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 410);
            this.dataGridView1.TabIndex = 11;
            // 
            // faturaDataSet
            // 
            this.faturaDataSet.DataSetName = "faturaDataSet";
            this.faturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataMember = "fatura";
            this.faturaBindingSource.DataSource = this.faturaDataSet;
            // 
            // faturaTableAdapter
            // 
            this.faturaTableAdapter.ClearBeforeFill = true;
            // 
            // tarihData
            // 
            this.tarihData.DataPropertyName = "tarih";
            this.tarihData.HeaderText = "Tarih";
            this.tarihData.Name = "tarihData";
            this.tarihData.ReadOnly = true;
            // 
            // idData
            // 
            this.idData.DataPropertyName = "id";
            this.idData.HeaderText = "#";
            this.idData.Name = "idData";
            this.idData.ReadOnly = true;
            // 
            // faturaNoData
            // 
            this.faturaNoData.DataPropertyName = "fatura_no";
            this.faturaNoData.HeaderText = "Fatura Numarası";
            this.faturaNoData.Name = "faturaNoData";
            this.faturaNoData.ReadOnly = true;
            // 
            // musteriData
            // 
            this.musteriData.DataPropertyName = "firma_adi";
            this.musteriData.HeaderText = "Müşteri";
            this.musteriData.Name = "musteriData";
            this.musteriData.ReadOnly = true;
            // 
            // urunlerData
            // 
            this.urunlerData.DataPropertyName = "urunler";
            this.urunlerData.HeaderText = "Ürünler";
            this.urunlerData.Name = "urunlerData";
            this.urunlerData.ReadOnly = true;
            // 
            // faturaData
            // 
            this.faturaData.DataPropertyName = "aciklama";
            this.faturaData.HeaderText = "Fatura Açıklaması";
            this.faturaData.Name = "faturaData";
            this.faturaData.ReadOnly = true;
            // 
            // tutarData
            // 
            this.tutarData.DataPropertyName = "tutar";
            this.tutarData.HeaderText = "Tutar";
            this.tutarData.Name = "tutarData";
            this.tutarData.ReadOnly = true;
            // 
            // siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1122, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarihCB);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.excelBtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.siparisGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siparis";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.siparis_Load);
            this.siparisGB.ResumeLayout(false);
            this.siparisGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox siparisGB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label haftalikSiparisLBL;
        private System.Windows.Forms.Label siparisToplamLBL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Label haftalikLBL;
        private System.Windows.Forms.ComboBox tarihCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private faturaDataSet faturaDataSet;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private faturaDataSetTableAdapters.faturaTableAdapter faturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idData;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriData;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunlerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarData;
    }
}