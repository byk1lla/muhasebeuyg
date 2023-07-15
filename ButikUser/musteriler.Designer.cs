namespace butikunmuhasebe
{
    partial class musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.butikunDataSet = new butikunmuhasebe.butikunDataSet();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butikunDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new butikunmuhasebe.butikunDataSetTableAdapters.musteriTableAdapter();
            this.subeCB = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.adText = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.excelBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterisoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.ID,
            this.musteriad,
            this.musterisoyad,
            this.firma,
            this.sube,
            this.adres});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.musteriBindingSource2;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(847, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // musteriBindingSource2
            // 
            this.musteriBindingSource2.DataMember = "musteri";
            this.musteriBindingSource2.DataSource = this.butikunDataSet;
            // 
            // butikunDataSet
            // 
            this.butikunDataSet.DataSetName = "butikunDataSet";
            this.butikunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.butikunDataSet;
            // 
            // butikunDataSetBindingSource
            // 
            this.butikunDataSetBindingSource.DataSource = this.butikunDataSet;
            this.butikunDataSetBindingSource.Position = 0;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // subeCB
            // 
            this.subeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subeCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musteriBindingSource, "sube", true));
            this.subeCB.FormattingEnabled = true;
            this.subeCB.Location = new System.Drawing.Point(20, 379);
            this.subeCB.Name = "subeCB";
            this.subeCB.Size = new System.Drawing.Size(232, 21);
            this.subeCB.TabIndex = 1;
            this.subeCB.Text = "Şube Seçin...";
            this.subeCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBtn.Location = new System.Drawing.Point(12, 467);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(136, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Ara";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şube Seçin\r\n";
            // 
            // addUser
            // 
            this.addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUser.Location = new System.Drawing.Point(699, 467);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(127, 23);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "Müşteri Ekle";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // adText
            // 
            this.adText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adText.Location = new System.Drawing.Point(20, 420);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(232, 20);
            this.adText.TabIndex = 5;
            this.adText.TextChanged += new System.EventHandler(this.adText_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(154, 467);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshBtn.Location = new System.Drawing.Point(699, 438);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(127, 23);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Yenile";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma Adı";
            // 
            // excelBTN
            // 
            this.excelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.excelBTN.Location = new System.Drawing.Point(566, 467);
            this.excelBTN.Name = "excelBTN";
            this.excelBTN.Size = new System.Drawing.Size(127, 23);
            this.excelBTN.TabIndex = 16;
            this.excelBTN.Text = "Excel\'e Aktar";
            this.excelBTN.UseVisualStyleBackColor = true;
            this.excelBTN.Click += new System.EventHandler(this.excelBTN_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(296, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // musteriad
            // 
            this.musteriad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musteriad.DataPropertyName = "musteri_adi";
            this.musteriad.HeaderText = "Müşteri Adı";
            this.musteriad.Name = "musteriad";
            this.musteriad.ReadOnly = true;
            this.musteriad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // musterisoyad
            // 
            this.musterisoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musterisoyad.DataPropertyName = "musteri_soyadı";
            this.musterisoyad.HeaderText = "Müşteri Soyadı";
            this.musterisoyad.Name = "musterisoyad";
            this.musterisoyad.ReadOnly = true;
            this.musterisoyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // firma
            // 
            this.firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firma.DataPropertyName = "company";
            this.firma.HeaderText = "Firma";
            this.firma.Name = "firma";
            this.firma.ReadOnly = true;
            // 
            // sube
            // 
            this.sube.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sube.DataPropertyName = "sube";
            this.sube.HeaderText = "Şube";
            this.sube.Name = "sube";
            this.sube.ReadOnly = true;
            this.sube.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "extaddr";
            this.adres.HeaderText = "Tam Adres";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(838, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excelBTN);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.subeCB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(854, 541);
            this.MinimumSize = new System.Drawing.Size(854, 541);
            this.Name = "musteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butikunDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource butikunDataSetBindingSource;
        private butikunDataSet butikunDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private butikunDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.ComboBox subeCB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource musteriBindingSource2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button excelBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterisoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn sube;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
    }
}