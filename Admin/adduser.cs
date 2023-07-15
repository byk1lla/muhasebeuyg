using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using butikunmuhasebe.API.Modules;
namespace butikunmuhasebe.Admin
{
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }

        private void adduser_Load(object sender, EventArgs e)
        {
            yetkiCBX.Text = "Yetki Seçin...";
        }
        private string ad, soyad, sifre, kadi, yetki;


        private void soyadTXT_TextChanged(object sender, EventArgs e)
        {
            usern();   
        }

        private void adTXT_TextChanged(object sender, EventArgs e)
        {
            usern();   
        }

        private void ekleBTN_Click(object sender, EventArgs e)
        {
            bool yet;
            yetki = yetkiCBX.Text;
            if (yetki == "Admin")
            {
                yet = true;
            }
            else
            {
                yet = false;
            }
            ad = adTXT.Text;
            soyad = soyadTXT.Text;
            usernameTXT.Text = kadi;
            sifre = passwdTXT.Text;
              User.Admin.addUser
         (ad, soyad, kadi, sifre, yet);
        }
        private void iptalBtn_Click(object sender, EventArgs e)
        {
            adTXT.Clear();
            soyadTXT.Clear();
            usernameTXT.Clear();
            passwdTXT.Clear();
            yetkiCBX.Text = "Yetki Seçin...";
        }

        private void usern()
        {
            string ad = adTXT.Text;
            string soyad = soyadTXT.Text;
            string username = $"{ad}.{soyad}";
            usernameTXT.Text = username;
            kadi = username;
        }
    }
}
