using butikunmuhasebe.API;
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

namespace butikunmuhasebe.ButikUnGUI
{
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }
        private void filterByTime(string time)
        {
            DateTime startDate;
            DateTime endDate = DateTime.Now;

            switch (time)
            {
                case "Bugün":
                    startDate = DateTime.Today;
                    break;
                case "Dün":
                    startDate = DateTime.Today.AddDays(-1);
                    break;
                case "1 Hafta Önce":
                    startDate = DateTime.Today.AddDays(-7);
                    break;
                case "1 Ay Önce":
                    startDate = DateTime.Today.AddMonths(-1);
                    break;
                case "1 Yıl Önce":
                    startDate = DateTime.Today.AddYears(-1);
                    break;
                case "Tüm Zamanlar":
                    startDate = DateTime.Parse("1/1/1753 00:00:00");
                    break;
                default:
                    startDate = DateTime.Parse("1/1/1753 00:00:00");
                    break;
            }

            string connectionString = reqstr.connectionstring;
            string query = "SELECT * FROM fatura WHERE tarih BETWEEN @StartDate AND @EndDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        public void FillCustomerTable()
        {
            string connectionString = reqstr.connectionstring;
            string query = "SELECT * FROM musteri";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);            }
        }
        private void siparis_Load(object sender, EventArgs e)
        {
            filterByTime("Tüm Zamanlar");

        }

        private void siparisGB_Enter(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addorder order = new addorder();
            order.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            filterByTime("Tüm Zamanlar");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void openBtn_Click(object sender, EventArgs e)
        {

        }

        private void tarihCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tarihCB.Text != "Bir Tarih Seçin...")
            {
                filterByTime(tarihCB.SelectedText);
            }

            
        }
    }
}
