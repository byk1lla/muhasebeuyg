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
            //string lastact = User.getlastactivity();
            //string lastlog = User.getlastlogin();
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

            string not = Not.Getir();

            noteArea.Text = not;

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
            }
            else
            {
                newNotebtn.Text = "Yeni Not";
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
            Settings set = new Settings();
            set.ShowDialog();
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
            MessageBox.Show("Program Kapatılıyor...",baslik,MessageBoxButtons.OK,MessageBoxIcon.Information);

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
            }
            else
            {
                newNotebtn.Text = "Düzenle";
                Not.Kaydet(noteArea.Text);
            }


        }

        private void klasorAcBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe","notes");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
