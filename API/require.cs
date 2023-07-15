using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Xml;

#region API
namespace butikunmuhasebe.API.Modules
{
        #region Rastgele Numara Oluşturma Sınıfı
    public class NumberG
    {
        public static string Generate()
        {
            Random random = new Random();
            DateTime now = DateTime.Now;

            string randomNumber = now.ToString("MMddyyyyHHmmss") + random.Next(10, 100);

            return randomNumber;
        }
    }
    #endregion;

        #region Fatura Sınıfı
    public class order
    {
        private static string connectionString;
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        public static string Add(string musteri,string faturano,string urun,double fiyat,DateTime date,string aciklama = null)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO [dbo].[fatura]([firma_adi],[fatura_no],[tarih],[tutar],[urunler],[aciklama])" +
                        "VALUES(@firmaadi,@faturano,@tarih,@tutar,@urunler,@aciklama)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firmaadi", musteri);
                        command.Parameters.AddWithValue("@faturano", faturano);
                        command.Parameters.AddWithValue("@tarih", date);
                        command.Parameters.AddWithValue("@urunler", urun);
                        command.Parameters.AddWithValue("@tutar", fiyat);
                        command.Parameters.AddWithValue("@aciklama", aciklama);
                        command.ExecuteNonQuery();
                    }
                    Log.dosyayaKaydet("Fatura Kaydı Eklendi!\nFatura No ->" + faturano, "UserActivity");
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;



                }
            }
            }

        public static string delete(string id)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM fatura WHERE fatura_no=" + id;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        Log.dosyayaKaydet("Ürün Kaydı Silindi!\nID: " + id, "UserActivity");
                        command.ExecuteNonQuery();
                    }
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    Log.error(sql.Message, "SqlError");
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;


                }
            }
        }
    }
#endregion;

        #region AutoCompleteHelper Sınıfı
    public class ACH
    {
        private static AutoCompleteStringCollection autoCompleteCollection;
        private static string connectionString;
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        public static void customerTextBox(TextBox textBox)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            autoCompleteCollection = new AutoCompleteStringCollection();
            string query = "SELECT company FROM musteri";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string company = reader.GetString(0);
                        autoCompleteCollection.Add(company);
                    }
                }

                reader.Close();
            }

            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
        }public static void customerComboBox(ComboBox comboBox)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            autoCompleteCollection = new AutoCompleteStringCollection();
            string query = "SELECT company FROM musteri";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string company = reader.GetString(0);
                        autoCompleteCollection.Add(company);
                        comboBox.Items.Add(company);
                    }
                }

                reader.Close();
            }

            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox.AutoCompleteCustomSource = autoCompleteCollection;
        }public static void productComboBox(ComboBox comboBox)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            autoCompleteCollection = new AutoCompleteStringCollection();
            string query = "SELECT urun_adi FROM urun";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string company = reader.GetString(0);
                        autoCompleteCollection.Add(company);
                        comboBox.Items.Add(company);
                    }
                }

                reader.Close();
            }

            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox.AutoCompleteCustomSource = autoCompleteCollection;
        }
    }
    #endregion;

        #region Gerekli String İfadeler Sınıfı
    public class reqstr
    {
        public static string Email { get; set; }
        public static string connectionstring { get; set; }


    }
    #endregion;

        #region Ürün Sınıfı
    public class product
    {
        private static string connectionString;
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        public static string add(float fiyat, string urunadi, int cap, string tur)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO urun (urun_adi, fiyat,cap,tur) VALUES (@name, @price,@cap,@tur)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", urunadi);
                        command.Parameters.AddWithValue("@price", fiyat);
                        command.Parameters.AddWithValue("@cap", cap);
                        command.Parameters.AddWithValue("@tur", tur);


                        command.ExecuteNonQuery();
                    }
                    Log.dosyayaKaydet("Ürün Kaydı Eklendi!\nÜrün Adı: " + urunadi + "\nFiyatı: " + fiyat + "\nÇapı: " + cap + "\nSusamlı/Susamsız: " + tur, "UserActivity");
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;


                }
            }

        }
        public static string delete(string id)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM urun WHERE id=" + id;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        Log.dosyayaKaydet("Ürün Kaydı Silindi!\nID: " + id, "UserActivity");
                        command.ExecuteNonQuery();
                    }
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    Log.error(sql.Message, "SqlError");
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;


                }
            }
        }

    }
    #endregion;

        #region Excel Sınıfı
    public static class Excel
    {
        public static void Export(this System.Data.DataTable DataTable, string ExcelFilePath = null)
        {
            try
            {
                int ColumnsCount;
                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                object[] Header = new object[ColumnsCount];
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                if (ExcelFilePath == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelFilePath = saveFileDialog.FileName;
                    }
                    else
                    {
                        Excel.Quit();
                        return;
                    }
                }

                try
                {
                    Worksheet.SaveAs(ExcelFilePath);
                    Excel.Quit();
                    DialogResult res = MessageBox.Show($"Dosya {ExcelFilePath}\nKonumuna Kaydedildi!\nAçmak İstiyormusunuz?", "Dosya Kaydedildi!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        Process.Start(ExcelFilePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosyayı Kaydederken Bir Hata Oluştu!\n" + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.error(ex.Message, "ExcelException");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.error(ex.Message, "ExcelException");
            }
        }
    }
    #endregion;
   
        #region Müşteri Sınıfı
    public class customer
    {
        private static string connectionString;
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        public static string add(string sube, string ad, string soyad, string firma, string extaddr)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO musteri (sube, musteri_adi, musteri_soyadı,company,extaddr) VALUES (@sube, @ad, @soyad,@firma,@extaddr)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sube", sube);
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@firma", firma);
                        command.Parameters.AddWithValue("@extaddr", extaddr);
                        command.ExecuteNonQuery();
                    }
                    Log.dosyayaKaydet("Müşteri Kaydı Eklendi!\nFirma Adı: " + firma + "\nŞube: " + sube, "UserActivity");
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;


                }
            }
        }
        public static string Delete(string id)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM musteri WHERE id=" + id;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        Log.dosyayaKaydet("Müşteri Kaydı Silindi!\nID: " + id, "UserActivity");
                        command.ExecuteNonQuery();
                    }
                    return "basarili";
                }
                catch (SqlException sql)
                {
                    Log.error(sql.Message, "SqlError");
                    return sql.Message;
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SysError");
                    return ex.Message;


                }
            }
        }
    }
#endregion;
    
        #region API Sınıfı
    public class api
    {
        private static string connectionString;
        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;
        public static bool checkConnect()
        {

            try
            {
                TcpClient kontrol_client = new TcpClient("www.google.com", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int siparisCount()
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM fatura";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }
        public static int musteriCount()
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM musteri";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }
        public static int urunCount()
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM urun";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }

        }

        public static int usersCount()
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }
        public static string getYetki(string username)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT auth FROM users WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    bool auth = (bool)command.ExecuteScalar();

                    if (auth)
                    {
                        return "admin";
                    }
                    else
                    {
                        return "user";
                    }
                }
            }
        }
        
        public static float dolar()
        {
            string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            float usdp = float.Parse(usd);
            return usdp;
        }
        public static float euro()
        {
            string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string eur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            float eurp = float.Parse(eur);
            return eurp;
        }
    }
    #endregion;
    
        #region Login Sınıfı
    public class Login
    {
        public static jsconfig Config;

        private static string connectionString;

        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static string checkLogin(string username, string password)
        {

            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [dbo].[users] WHERE [username] = @Username AND [passwd] = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {

                            return "basarili";
                        }
                        else
                        {
                            return "Kullanıcı Adı Veya Şifre Hatalı!\nLütfen Tekrar Deneyin.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.error(ex.Message, "SystemErr");
                    return "Bir Hata Oluştu - " + ex.Message;


                }
            }

        }
    }
#endregion;
    
        #region Log Kaydetme Sınıfı
    public class Log
    {

        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static jsconfig Config;

        private static string not = DateTime.Now.ToString("MM/dd/yyyy");
        private static string fileName = $"logs/log-{not}.log";
        private static string connectionString;

        public static void error(string activity, string activitytype)
        {
            string fileNameerr = $"logs/errors/error-{not}.log";
            string log = $"[{DateTime.Now}] {activitytype} - {activity}";
            string klasor = Path.GetDirectoryName(fileNameerr);
            if (!Directory.Exists(klasor))
            {
                Directory.CreateDirectory(klasor);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileNameerr, true))
                    {
                        sw.WriteLine(log);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    error(fileName, $"[{DateTime.Now}] SystemError - {ex.Message}");

                }
            }
        }


        public static void dosyayaKaydet(string activity, string activitytype)
        {
            string log = $"[{DateTime.Now}] {activitytype} - {activity}";
            string klasor = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(klasor))
            {
                Directory.CreateDirectory(klasor);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName, true))
                    {
                        sw.WriteLine(log);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    error(fileName, $"[{DateTime.Now}] SystemError - {ex.Message}");

                }
            }
        }
        public static void vtyekaydet(string activity, string userid)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO UserActivity (usr_id, activity, activity_date) VALUES (@UserId, @Activity, @ActivityTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userid);
                        command.Parameters.AddWithValue("@Activity", activity);
                        command.Parameters.AddWithValue("@ActivityTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    error(ex.Message, "SysError");
                }
            }
        }
    }
#endregion;
    
        #region Not Defteri Sınıfı
    public class Not
    {

        private static string not = DateTime.Now.ToString("MM/dd/yyyy");
        private static string fileName = $"notes/note-{not}.txt";

        public static void Kaydet(string Metin)
        {
            string klasor = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(klasor))
            {
                Directory.CreateDirectory(klasor);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.WriteLine(Metin);

                    }

                }
                catch (SystemException ex)
                {
                    Log.error(ex.Message, "SystemError");
                    MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static string Getir()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string metin = File.ReadAllText(fileName);
                    return metin;
                }
                else
                {
                    MessageBox.Show("Not dosyası bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.dosyayaKaydet($"{fileName} Adlı Dosya Bulunamadı!", "NotFoundError");
                    return $"{fileName} Adlı Dosya Bulunamadı!";
                }
            }
            catch (SqlException sql)
            {
                Log.error(sql.Message, "SqlError");
                return sql.Message;
            }
            catch (SystemException ex)
            {
                Log.error(ex.Message, "SystemError");
                return ex.Message;
            }

        }
    }
    #endregion;
    
        #region Kullanıcı Yönetim Sınıfı
    public class User
    {
        public static jsconfig Config;
        private static string connectionString;

        private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
        public static string getlastactivity(string username)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT TOP 1 last_activity FROM users WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime lastActivity = reader.GetDateTime(0);
                            return lastActivity.ToString("dd MMMM yyyy dddd - HH:mm:ss");
                        }
                    }
                }
            }
            return null;
        }


        public static void updateLastActivity(string username, DateTime date)
        {
            using (var fs = File.OpenRead(JSONPath))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                string json = sr.ReadToEnd();
                Config = JsonConvert.DeserializeObject<jsconfig>(json);
                connectionString = Config.connectionString;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE users " +
                        "SET last_activity = @Date " +
                        "WHERE username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Username", username);


                        command.ExecuteNonQuery();


                        Log.dosyayaKaydet($"Last Activity Updated! -> {username}", "SystemActivity");
                    }
                }
                catch (SqlException sql)
                {
                    Log.error(sql.Message, "SqlError");
                    MessageBox.Show(sql.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SystemException ex)
                {
                    Log.error(ex.Message, "SystemError");
                    MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
#endregion
    
        #region Admin Sınıfı
        public class Admin
        {
            public static jsconfig Config;
            private static string connectionString;

            private static string JSONPath = ConfigurationManager.AppSettings["JSON"];
            public static void addUser(string ad, string soyad, string username, string passwd, bool auth)
            {
                using (var fs = File.OpenRead(JSONPath))
                using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                {
                    string json = sr.ReadToEnd();
                    Config = JsonConvert.DeserializeObject<jsconfig>(json);
                    connectionString = Config.connectionString;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO [dbo].[users] ([ad], [soyad], [username], [passwd], [auth]) " +
                                       "VALUES (@Ad, @Soyad, @Username, @Passwd, @Auth)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Ad", ad);
                            command.Parameters.AddWithValue("@Soyad", soyad);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Passwd", passwd);
                            command.Parameters.AddWithValue("@Auth", auth);


                            command.ExecuteNonQuery();
                            string yet;
                            MessageBox.Show("Kullanıcı eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (auth)
                            {
                                yet = "Admin";
                            }
                            else
                            {
                                yet = "User";
                            }
                            Log.dosyayaKaydet("Yeni Bir Kullanıcı Eklendi!\n" +
                                $"\tAdı : {ad}\n" +
                                $"\tSoyadı : {soyad}\n" +
                                $"\tE-Posta Adresi : {username}\n" +
                                $"\tYetkisi : {yet} \n", "AdminActivity");
                        }
                    }
                    catch (SqlException sql)
                    {
                        Log.error(sql.Message, "SqlError");
                        MessageBox.Show(sql.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SystemException ex)
                    {
                        Log.error(ex.Message, "SystemError");
                        MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            public static string deleteUser(string username)
            {
                using (var fs = File.OpenRead(JSONPath))
                using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                {
                    string json = sr.ReadToEnd();
                    Config = JsonConvert.DeserializeObject<jsconfig>(json);
                    connectionString = Config.connectionString;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = $"DELETE FROM [dbo].[users] WHERE user_id = '{username}'";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();

                            MessageBox.Show("Kullanıcı silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Log.dosyayaKaydet($"{username} - Kullanıcı Silindi.", "SystemActivity");

                            return "basarili";
                        }
                    }
                    catch (SqlException sql)
                    {
                        Log.error(sql.Message, "SqlError");
                        return sql.Message;
                    }
                    catch (SystemException ex)
                    {
                        Log.error(ex.Message, "SystemError");
                        return ex.Message;
                    }

                }

            }

        }
        #endregion;
    }
}
#endregion;
