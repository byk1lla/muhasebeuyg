using butikunmuhasebe.API;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using butikunmuhasebe.API.Modules;

namespace butikunmuhasebe
{
    public partial class musteriler : Form
    {
        public musteriler()
        {
            InitializeComponent();
        }
        public void search(string soyad = "", string sube = "")
        {
            string connectionString = reqstr.connectionstring;


            string query;

            if (string.IsNullOrEmpty(soyad) && string.IsNullOrEmpty(sube))
            {
                query = "SELECT * FROM musteri";
            }
            else if(string.IsNullOrEmpty(soyad))
            {
                query = $"SELECT * FROM musteri WHERE sube = '{sube}'";
            }
            else if(string.IsNullOrEmpty(sube)) {
                query = $"SELECT * FROM musteri WHERE company LIKE '%{soyad}%'";
            }
            else
            {
                query = $"SELECT * FROM musteri WHERE company LIKE '%{soyad}%' AND sube = '{sube}'";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch(SqlException sql)
                    {
                        MessageBox.Show(sql.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
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

                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        public void FillComboBox()
        {
            subeCB.Items.Clear();
            string connectionString = reqstr.connectionstring;
            string query = "SELECT DISTINCT sube FROM musteri";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    subeCB.Items.Add(reader["sube"].ToString());
                }
            }
        }
        private void musteriler_Load(object sender, EventArgs e)
        {
            FillComboBox();
            subeCB.Text = "Şube Seçin...";
            FillCustomerTable();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            addcustomer customer = new addcustomer();
            customer.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adText.Text))
            {
                search("", subeCB.Text);
            }
            else if (string.IsNullOrEmpty(subeCB.Text) || subeCB.Text == "Şube Seçin...")
            {
                search(adText.Text, "");
            }
            else
            {
                search(adText.Text, subeCB.Text);

            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adText.Text))
            {
                search("", subeCB.Text);
            }

            else if (string.IsNullOrEmpty(adText.Text) && string.IsNullOrEmpty(subeCB.Text) || subeCB.Text == "Şube Seçin...")
            {
                MessageBox.Show("Lütfen Arama Yapmadan Önce Bu Alanları Doldurun.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(subeCB.Text) || subeCB.Text == "Şube Seçin...")
            {
                search(adText.Text,"");
            }
            else
            {
                search(adText.Text, subeCB.Text);

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            FillComboBox();
            FillCustomerTable();
            subeCB.Text = "Şube Seçin...";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataRowView dataRow = (DataRowView)selectedRow.DataBoundItem;
                string id = dataRow.Row["id"].ToString();
                string res = customer.Delete(id);

                if (res == "basarili")
                {
                    MessageBox.Show("Müşteri Kaydı Silindi!","Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FillCustomerTable();
                    FillComboBox();
                }
                else
                {
                    MessageBox.Show(res,"Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
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

        private void adText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adText.Text))
            {
                search("", subeCB.Text);
            }
            else if (string.IsNullOrEmpty(subeCB.Text) || subeCB.Text == "Şube Seçin...")
            {
                search(adText.Text, "");
            }
            else
            {
                search(adText.Text, subeCB.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            subeCB.Items.Clear();
            subeCB.Items.Add("Şube Seçin...");
            adText.Clear();
        }
    }
}
