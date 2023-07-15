using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using butikunmuhasebe;
using butikunmuhasebe.ButikUnGUI;
using butikunmuhasebe.API;
using System.Diagnostics;
using System.Xml;
using butikunmuhasebe.API.Modules;
using System.Threading;
using butikunmuhasebe.ButikUser;

namespace butikunmuhasebe
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }
        string baslik;

        private void Main_Load(object sender, EventArgs e)
        {

            timer1.Start();
            notePanel.Visible = false;
            if (string.IsNullOrEmpty(noteArea.Text))
            {
                newNotebtn.Text = "Yeni Not";
            }
            else
            {
                newNotebtn.Text = "Düzenle";
            }
            noteArea.Enabled = false;
            baslik = $"{this.Text} - Butik Un Dünyası";

            string lb = User.getlastactivity(reqstr.Email);

            activityLBL.Text = lb;
            string not = Not.Getir();

            noteArea.Text = not;

            string yetki = api.getYetki(reqstr.Email);

            if (yetki == "admin")
            {
                adminBtn.Visible = true;
            }
            else
            {
                adminBtn.Visible = false;
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void displayNote_CheckedChanged(object sender, EventArgs e)
        {
            if (notePanel.Visible == false)
            {
                Not.Getir();
                displayNote.Text = "Not Defterini Gizle";
                notePanel.Visible = true;
                noteArea.Enabled = false;
            }
            else
            {
                displayNote.Text = "Not Defterini Göster";
                notePanel.Visible = false;
                noteArea.Enabled = false;
            }
            Not.Kaydet(noteArea.Text);
        }

        private void newNotebtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(noteArea.Text))
            {
                newNotebtn.Text = "Düzenle";
                deleteNoteBtn.Enabled = true;
            }
            else
            {
                newNotebtn.Text = "Yeni Not";
                deleteNoteBtn.Enabled = false;
            }

            noteArea.Enabled = true;
            noteArea.Focus();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteNoteBtn_Click(object sender, EventArgs e)
        {
            noteArea.Text = string.Empty;
            newNotebtn.Text = "Yeni Not";
            noteArea.Enabled = false;
            Not.Kaydet(string.Empty);
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            Log.dosyayaKaydet($"{reqstr.Email} User Logged Out!", "LoginActivity");
            Log.vtyekaydet("Logged Out!", reqstr.Email);
            Log.dosyayaKaydet("Program Closed!", "SystemActivity");
            progresscagir();
            MessageBox.Show("İşlemler Tamamlandı!\nSistem Kapanıyor.", "Ana Menü - Butik Un Dünyası", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string output = date.ToString("dddd dd MMMM yyyy - HH:mm:ss");

            dateLBL.Text = output;
        }

        private void noteArea_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noteArea.Text))
            {
                newNotebtn.Text = "Yeni Not";
                deleteNoteBtn.Enabled = false;
            }
            else
            {
                newNotebtn.Text = "Düzenle";
                deleteNoteBtn.Enabled = true;
            }


        }

        private void klasorAcBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "notes");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noteArea_MouseLeave(object sender, EventArgs e)
        {
            noteArea.Enabled = false;
            Not.Kaydet(noteArea.Text);
        }

        private void noteArea_MouseEnter(object sender, EventArgs e)
        {
            noteArea.Enabled = true;
        }

        private void noteArea_MouseHover(object sender, EventArgs e)
        {
            noteArea.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun ur = new urun();
            ur.Show();
        }

        private void siparisBtn_Click(object sender, EventArgs e)
        {
            siparis si = new siparis();
            si.Show();
        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            musteriler ms = new musteriler();
            ms.Show();
        }

        private void doviz_Enter(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.tcmb.gov.tr/kurlar/today.xml");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            ButikUnGUI.Admin Admin = new ButikUnGUI.Admin();

            Admin.ShowDialog();
        }
        public static int parentX, parentY;
        private void progresscagir()
        {
            loading lo = new loading();
            lo.ShowDialog();
        }
    }
}
