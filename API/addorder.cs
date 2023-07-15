using butikunmuhasebe.API.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace butikunmuhasebe.API
{
    public partial class addorder : Form
    {
        

        public addorder()
        {
            InitializeComponent();
        }
        private Dictionary<string, int> productCounts = new Dictionary<string, int>();
        private static int uruncount = 0;
        private float toplamFiyat;
        
        private double hesapla(double fiyat)
        {
            double kdvh = Math.Round(fiyat * 20 / 100, 2);
            double kdv = Math.Round(fiyat + kdvh, 2);
            toplamTXT.Clear();
            toplamTXT.AppendText(Math.Round(toplamFiyat, 2) + " ₺(Türk Lirası) KDV'siz" + Environment.NewLine);
            toplamTXT.AppendText(kdv + " ₺(Türk Lirası) %20 KDV" + Environment.NewLine);
            return kdv;
        }
        private void Customer(string company)
        {
            string connectionString = reqstr.connectionstring;
            string query = "SELECT DISTINCT musteri_adi, musteri_soyadı, company, sube, extaddr FROM musteri WHERE company = @Company";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Company", company);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string musteriAdi = reader.GetString(0);
                            string musteriSoyadi = reader.GetString(1);
                            string firmaAdi = reader.GetString(2);
                            string sube = reader.GetString(3);
                            string adres = reader.GetString(4);

                            string formatliVeri = $"Adı: {musteriAdi} / Soyadı: {musteriSoyadi} / Firma Adı: {firmaAdi} / Şube: {sube} / Adres: {adres}";

                            faturaM.AppendText(formatliVeri + Environment.NewLine);
                        }
                    }
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(sql.Message, "SqlException");

                }
                catch (SystemException sy)
                {
                    MessageBox.Show(sy.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(sy.Message, "SystemException");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(ex.Message, "Exception");
                }
                reader.Close();
            }
        }
        private void toplamfiyat(string urunadi)
        {

            string connectionString = reqstr.connectionstring;
            string query = $"SELECT fiyat FROM urun WHERE urun_adi = '{urunadi}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            float fiyat = (float)reader.GetDouble(0);
                            toplamFiyat += fiyat;
                        }
                    }
                    reader.Close();
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message, "Hata! - Toplam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(sql.Message, "SqlException");
                }
                catch (SystemException sy)
                {
                    MessageBox.Show(sy.Message, "Hata! - Toplam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(sy.Message, "SystemException");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata! - Toplam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(ex.Message, "Exception");
                }
            }
        }
        private List<string> selectedProducts = new List<string>();
        private void ShowSelectedProducts()
        {
            faturaP.Clear();

            foreach (string item in selectedProducts.Distinct().ToList())
            {
                int count = selectedProducts.Count(x => x == item);
                faturaP.AppendText(item + " - " + count + " Adet" + Environment.NewLine);
                uruncount++;
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addorder_Load(object sender, EventArgs e)
        {
            // size : 274; 396 && 806; 396
            this.Size = new Size(274, 396);
            this.MaximumSize = new Size(274, 396);
            ACH.customerComboBox(musteriCB);
            ACH.productComboBox(urunCB);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void urunCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectedProduct = urunCB.SelectedItem.ToString();
            selectedProducts.Add(selectedProduct);
            toplamfiyat(urunCB.Text);
            
        }

        private void musteriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer(musteriCB.Text);
        }

        private void faturaAciklama_TextChanged(object sender, EventArgs e)
        {
            if (musteriCB.Text == "Müşteri Seçin..." || urunCB.Text == "Ürün Seçin..." || string.IsNullOrEmpty(urunCB.Text) && string.IsNullOrEmpty(musteriCB.Text))
            {
                MessageBox.Show("Fatura Açıklaması Eklemeden Önce Yukarıdaki Alanları Doldurun.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                faturaRO.AppendText(faturaAciklama.Text + Environment.NewLine);
            }

        }
        // 10000000146
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void hesaplaBTN_Click(object sender, EventArgs e)
        {
            ShowSelectedProducts();
            double kdv = hesapla(toplamFiyat);

            if (musteriCB.Text == "Müşteri Seçin..." || urunCB.Text == "Ürün Seçin..." || string.IsNullOrEmpty(urunCB.Text) && string.IsNullOrEmpty(musteriCB.Text))
            {
                MessageBox.Show("Lütfen Alanları Doldurun.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.MaximumSize = new Size(806, 396);
                this.Size = new Size(806, 396);

                faturaRO.Clear();
                if (!string.IsNullOrEmpty(faturaAciklama.Text))
                {
                    faturaRO.AppendText(faturaAciklama.Text);
                    faturaRO.AppendText(Environment.NewLine + tarihDT.Text);
                    faturaRO.AppendText(Environment.NewLine + $"Müşteri Bilgileri : \n{faturaM.Text} " + Environment.NewLine);
                    faturaRO.AppendText($"{uruncount} - Çeşit Ürün Eklendi!" + Environment.NewLine);
                    faturaRO.AppendText($"Toplam Fiyat - {kdv}" + Environment.NewLine);
                }
                else
                {
                    faturaRO.AppendText(Environment.NewLine + tarihDT.Text);
                    faturaRO.AppendText(Environment.NewLine + $"Müşteri Bilgileri : \n{faturaM.Text} " + Environment.NewLine);
                    faturaRO.AppendText($"{uruncount} - Çeşit Ürün Eklendi!" + Environment.NewLine);
                    faturaRO.AppendText($"Toplam Fiyat - {kdv}" + Environment.NewLine);
                }
            }
        }

        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            double kdvh = Math.Round(toplamFiyat * 0.20, 2);
            double kdv = Math.Round(toplamFiyat + kdvh, 2);
            string faturano = NumberG.Generate();
            string result = order.Add(musteriCB.Text, faturano, faturaP.Text, kdv, tarihDT.Value, faturaRO.Text);
            if (result == "basarili")
            {
                MessageBox.Show("Fatura Başarıyla Oluşturuldu! Fatura No: " + faturano, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


