namespace butikunmuhasebe.ButikUnGUI
{
    partial class urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urun));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butikunDataSet = new butikunmuhasebe.butikunDataSet();
            this.urunTableAdapter = new butikunmuhasebe.butikunDataSetTableAdapters.urunTableAdapter();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.subeCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newUpdated = new butikunmuhasebe.newUpdated();
            this.newUpdatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new butikunmuhasebe.newUpdatedTableAdapters.musteriTableAdapter();
            this.urunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter1 = new butikunmuhasebe.newUpdatedTableAdapters.urunTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.excelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUpdatedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.id,
            this.urun_adi,
            this.cap,
            this.tur,
            this.fiyat});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.urunBindingSource2;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.butikunDataSet;
            // 
            // butikunDataSet
            // 
            this.butikunDataSet.DataSetName = "butikunDataSet";
            this.butikunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshBtn.Location = new System.Drawing.Point(643, 447);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(127, 23);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Yenile";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Seçin\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(147, 476);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 23);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBtn.Location = new System.Drawing.Point(9, 476);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(136, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Ara";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // subeCB
            // 
            this.subeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subeCB.FormattingEnabled = true;
            this.subeCB.Location = new System.Drawing.Point(15, 394);
            this.subeCB.Name = "subeCB";
            this.subeCB.Size = new System.Drawing.Size(232, 21);
            this.subeCB.TabIndex = 7;
            this.subeCB.Text = "Ürün Seçin...";
            this.subeCB.SelectedIndexChanged += new System.EventHandler(this.subeCB_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(643, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newUpdated
            // 
            this.newUpdated.DataSetName = "newUpdated";
            this.newUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newUpdatedBindingSource
            // 
            this.newUpdatedBindingSource.DataSource = this.newUpdated;
            this.newUpdatedBindingSource.Position = 0;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.newUpdatedBindingSource;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // urunBindingSource1
            // 
            this.urunBindingSource1.DataMember = "urun";
            this.urunBindingSource1.DataSource = this.newUpdatedBindingSource;
            // 
            // urunTableAdapter1
            // 
            this.urunTableAdapter1.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // urun_adi
            // 
            this.urun_adi.DataPropertyName = "urun_adi";
            this.urun_adi.HeaderText = "Ürün Adı";
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.ReadOnly = true;
            // 
            // cap
            // 
            this.cap.DataPropertyName = "cap";
            this.cap.HeaderText = "Ürün Çapı";
            this.cap.Name = "cap";
            this.cap.ReadOnly = true;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "Susamlı/Susamsız";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Fiyatı";
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            // 
            // urunBindingSource2
            // 
            this.urunBindingSource2.DataMember = "urun";
            this.urunBindingSource2.DataSource = this.newUpdatedBindingSource;
            // 
            // excelBTN
            // 
            this.excelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.excelBTN.Location = new System.Drawing.Point(510, 476);
            this.excelBTN.Name = "excelBTN";
            this.excelBTN.Size = new System.Drawing.Size(127, 23);
            this.excelBTN.TabIndex = 17;
            this.excelBTN.Text = "Excel\'e Aktar";
            this.excelBTN.UseVisualStyleBackColor = true;
            this.excelBTN.Click += new System.EventHandler(this.excelBTN_Click);
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(782, 511);
            this.Controls.Add(this.excelBTN);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.subeCB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urun";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUpdatedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private butikunDataSet butikunDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private butikunDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox subeCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource newUpdatedBindingSource;
        private newUpdated newUpdated;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private newUpdatedTableAdapters.musteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.BindingSource urunBindingSource1;
        private newUpdatedTableAdapters.urunTableAdapter urunTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.BindingSource urunBindingSource2;
        private System.Windows.Forms.Button excelBTN;
    }
}