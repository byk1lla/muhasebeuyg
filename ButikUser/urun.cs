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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }
        public void search(string sube = "")
        {
            string connectionString = reqstr.connectionstring;


            string query;

            if (string.IsNullOrEmpty(sube))
            {
                query = "SELECT * FROM urun";
            }
            else
            {
                query = "SELECT * FROM urun WHERE urun_adi = @Sube";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Sube", sube);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (SqlException sql)
                    {
                        MessageBox.Show(sql.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void FillCustomerTable()
        {
            string connectionString = reqstr.connectionstring;
            string query = "SELECT * FROM urun";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }


        public void FillComboBox()
        {
            subeCB.Items.Clear();
            string connectionString = reqstr.connectionstring;
            string query = "SELECT DISTINCT urun_adi FROM urun";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    subeCB.Items.Add(reader[0].ToString());
                }
            }
        }
        private void urun_Load(object sender, EventArgs e)
        {

            subeCB.Text = "Ürün Seçin...";
            FillCustomerTable();
            dataGridView1.Columns["fiyat"].DefaultCellStyle.Format = "0.##";
            FillComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            subeCB.Text = "Ürün Seçin...";
            FillComboBox();
            FillCustomerTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addproduct pr = new addproduct();
            pr.ShowDialog();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataRowView dataRow = (DataRowView)selectedRow.DataBoundItem;
                string id = dataRow.Row["id"].ToString();
                string res = product.delete(id);

                if (res == "basarili")
                {
                    MessageBox.Show("Ürün Kaydı Silindi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillCustomerTable();
                    FillComboBox();
                }
                else
                {
                    MessageBox.Show(res, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            search(subeCB.Text);
        }

        private void subeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            search(subeCB.Text);
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                deleteBtn.Enabled = true;
            }
            else
            {
                deleteBtn.Enabled = false;
                
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
        }

        private void excelBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            Excel.Export(dt);
        }
    }
}
