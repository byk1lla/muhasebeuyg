using butikunmuhasebe.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butikunmuhasebe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        Main ma = new Main();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginUsr();

        }
        private void loginUsr()
        {
            string log = Login.checkLogin(usname.Text, passwd.Text);

            if (log == "basarili")
            {
                Log.vtyekaydet("User logged in",usname.Text);
                Log.dosyayaKaydet($"User Logged in - {usname.Text}", "Login Activity");
                MessageBox.Show("Giriş Başarılı!\nMenüye Yönlendiriliyorsunuz...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();


                ma.Show();
            }
            
            else
            {
                MessageBox.Show(log, $"{this.Text} - Butik Un Dünyası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwd.Text = string.Empty;
                usname.Text = string.Empty;
            }
        }
        private void usname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (usname.Text == "")
                {
                    usname.Focus();
                }
                else
                {
                    passwd.Focus();
                }
            }
        }

        private void passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (usname.Text == "")
                {
                    usname.Focus();
                }
                else
                {
                    loginUsr();
                }
            }
        }
    }
}
