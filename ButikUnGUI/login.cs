using butikunmuhasebe.API;
using butikunmuhasebe.API.Modules;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        private void login_Load(object sender, EventArgs e)
        {
            usname.Focus();

            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                reqstr.connectionstring = Config.connectionString;
            }

        }
        Main ma = new Main();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginUsr();
        }
        private void loginUsr()
        {
            reqstr.Email = usname.Text;

            string log = Login.checkLogin(usname.Text, passwd.Text);
            string fileName = $"notes/note-{DateTime.Now.ToString("MM/dd/yyyy")}.txt";

            if (log == "basarili")
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                }
                Log.vtyekaydet("User logged in", usname.Text);
                Log.dosyayaKaydet($"User Logged in -> {usname.Text}", "Login Activity");
                User.updateLastActivity(usname.Text, DateTime.Now);
                MessageBox.Show("Giriş Başarılı!\nMenüye Yönlendiriliyorsunuz...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ma.Show();
            }
            else
            {
                MessageBox.Show(log, $"{this.Text} - Butik Un Dünyası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void usname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (usname.Text == "")
                {
                    usname.Clear();
                    usname.Focus();
                    
                }
                else
                {
                    passwd.Clear();
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
                    passwd.Clear();
                    usname.Clear();
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
