using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butikunmuhasebe.API
{
    public class Login
    {
        private static string connectionString = "Data Source=byk1lla;Initial Catalog=butikun;Integrated Security=True;";

        public static string checkLogin(string username, string password)
        {
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
                    return "Bir Hata Oluştu" + ex.Message;
                }
            }

        }
    }
    public class Log
    {
        private static string not = DateTime.Now.ToString("dd/MM/yyyy-HH:mm:ss");
        private static string fileName = $"logs/log-{not}.log";
        private static string connectionString = "Data Source=byk1lla;Initial Catalog=butikun;Integrated Security=True;";

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
                    File.WriteAllText(fileName, log);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    File.WriteAllText(fileName, $"[{DateTime.Now}] SystemError - {ex.Message}");

                }
            }
        }
        public static void vtyekaydet(string activity, string userid)
        {

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
                    MessageBox.Show("Veritabanına veri eklenirken bir hata oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    public class Not
    {
        private static string not = DateTime.Now.ToString("dd/MM/yyyy");
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
                    File.WriteAllText(fileName, Metin);

                }
                catch (Exception ex)
                {
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
                Log.dosyayaKaydet(sql.Message, "SqlError");
                return sql.Message;
            }
            catch (SystemException ex)
            {
                Log.dosyayaKaydet(ex.Message, "SystemError");
                return ex.Message;
            }
        }
    }
    public class User
    {
        public static string getlastactivity(string username)
        {
            return DateTime.Now.ToString(); ;
        }
        public static string getlastlogin(string username)
        {
            return DateTime.Now.ToString();
        }
    }
    public class Admin
    {
        private static string connectionString = "Data Source=byk1lla;Initial Catalog=butikun;Integrated Security=True;";
        public static void addUser(string ad, string soyad, string username, string passwd, int auth, DateTime? lastActivity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO [dbo].[users] ([ad], [soyad], [username], [passwd], [auth], [last_activity]) " +
                                   "VALUES (@Ad, @Soyad, @Username, @Passwd, @Auth, @LastActivity)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Passwd", passwd);
                        command.Parameters.AddWithValue("@Auth", auth);
                        command.Parameters.AddWithValue("@LastActivity", lastActivity);

                        command.ExecuteNonQuery();
                        string yet;
                        MessageBox.Show("Kullanıcı eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (auth > 0)
                        {
                            yet = "Admin";
                        }
                        else
                        {
                            yet = "User";
                        }
                        Log.dosyayaKaydet("Yeni Bir Kullanıcı Eklendi!\n" +
                            $"Adı : {ad}\n" +
                            $"Soyadı : {soyad}\n" +
                            $"E-Posta Adresi : {username}\n" +
                            $"Yetkisi : {yet} \n", "SystemActivity");
                    }
                }
                catch (SqlException sql)
                {
                    Log.dosyayaKaydet(sql.Message, "SqlError");
                    return sql.Message;
                }
                catch (SystemException ex)
                {
                    Log.dosyayaKaydet(ex.Message, "SystemError");
                    return ex.Message;
                }

            }
        }
        public static string deleteUser(string username)
        {
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

                        Log.dosyayaKaydet($"{username} - Kullanıcı Silindi.","SystemActivity");

                        return "basarili";
                    }
                }
                catch (SqlException sql)
                {
                    Log.dosyayaKaydet(sql.Message, "SqlError");
                    return sql.Message;
                }
                catch (SystemException ex)
                {
                    Log.dosyayaKaydet(ex.Message, "SystemError");
                    return ex.Message;
                }

            }
            
        }

    }
}
