using butikunmuhasebe.API.Modules;
using butikunmuhasebe.ButikUnGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace butikunmuhasebe.API
{
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
        }
        

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TLfiyat.Text) && string.IsNullOrEmpty(urunText.Text))
            {
                MessageBox.Show("Lütfen Alanları Doldurun!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float fiyat;
                string fiyatTL = TLfiyat.Text;
                string fiyatKurus = KRSFiyat.Text;

                string fiyatMetin = fiyatTL + "," + fiyatKurus;
                if (float.TryParse(fiyatMetin, out fiyat))
                {
                    

                    
                    DialogResult quest = MessageBox.Show("Ürün Adı: " + urunText.Text + " \nFiyatı: " + fiyat + "\nOnaylıyor Musunuz?", "Onay - Butik Un Dünyası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (quest == DialogResult.Yes)
                    {
                        string result = product.add(fiyat, urunText.Text,int.Parse(capTXT.Text),turCB.Text);
                        if (result == "basarili")
                        {
                            MessageBox.Show("Ürün Başarıyla Eklendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        capTXT.Clear();
                        turCB.Items.Clear();
                        
                        TLfiyat.Clear();
                        KRSFiyat.Clear();
                        urunText.Clear();
                        turCB.Text = "Tür Seçin...";
                        turCB.Items.Add("Susamlı");
                        turCB.Items.Add("Susamsız");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Değer!\nLütfen Tekrar Deneyin.","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


                
            }
        }

        private void addproduct_Load(object sender, EventArgs e)
        {
            turCB.Text = "Susamlı/Susamsız";
            turCB.Items.Add("Susamlı");
            turCB.Items.Add("Susamsız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunText.Focus();
            urunText.Clear();
            TLfiyat.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
