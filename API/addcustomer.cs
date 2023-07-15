using butikunmuhasebe.API.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butikunmuhasebe.API
{
    public partial class addcustomer : Form
    {
        public addcustomer()
        {
            InitializeComponent();
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adText.Text = string.Empty;
            soyadText.Text = string.Empty;
            subeText.Text = string.Empty;
            firmaText.Text = string.Empty;
            succLBL.Text = string.Empty;
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string add = customer.add(subeText.Text, adText.Text, soyadText.Text, firmaText.Text,richTextBox1.Text);
            if (add == "basarili")
            {
                MessageBox.Show("Müşteri Başarıyla Eklendi",this.Text + " - Butik Un Dünyası",MessageBoxButtons.OK,MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show(add,"Bir Hata Oluştu!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void addcustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void addcustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
