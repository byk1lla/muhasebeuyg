using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using butikunmuhasebe.Admin;
using butikunmuhasebe.API.Modules;

namespace butikunmuhasebe.ButikUnGUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            siparisData.Text = api.siparisCount().ToString();
            urunData.Text = api.urunCount().ToString();
            userData.Text = api.usersCount().ToString();
            musteriData.Text = api.musteriCount().ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            adduser add = new adduser();
            add.ShowDialog();
        }
    }
}
