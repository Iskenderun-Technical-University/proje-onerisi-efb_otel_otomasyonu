using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace otel_deneme_1
{
    class veritabani
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        
        public static string SqlCon = "Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True";
        

        public static bool baglantidurum()
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    System.Windows.Forms.MessageBox.Show("Veri Tabanı Bağlantısı Gerçekleşti.");
                    return true;

                }
                catch (SqlException exx)

                {
                    System.Windows.Forms.MessageBox.Show("Veri Tabanı Bağlanamadı.");
                    return false;



                }


            }

        }
        public static DataGridView GridDoldur(DataGridView gridim, string SqlSelectSorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(SqlSelectSorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, SqlSelectSorgu);

            gridim.DataSource = ds.Tables[SqlSelectSorgu];
            con.Close();

            return gridim;

        }
        public static string MD5Ssifrele(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            //dizi yani girilen metnin ya da rakamların değeri çıkartılıyor
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public static bool LoginKontrol(string password)
        {
            string sorgu = "select * from tbl_giris where password=@pass";
           
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@pass", veritabani.MD5Ssifrele(password));

            con.Open();

            dr = cmd.ExecuteReader();
            //Eğer veri geldiyse

            if (dr.Read())
            {
                Form1.kullanicimsession = dr["username"].ToString();

                con.Close();
                return true;
                MessageBox.Show("Tebrikler.Giriş Yaptınız..");
            }
            else
            {
                con.Close();
                return false;

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");


            }

        }
        //datagrid stun renklerini değişir boş odaysa yeşil dolu odaysa kı
        //oda bilgilerinde dolu veya boş olmasının kontrol edilmesi
        public static void updates(ComboBox combo_odano2)
        {
            con = new SqlConnection(SqlCon);
            string sql3 = "update tbl_odabilgi set odabosdolu=@odabos where odanumarası = @odano ";
            con.Open();
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@odabos", "Bos");
            cmd.Parameters.AddWithValue("@odano", combo_odano2.Text);
            cmd.Connection = con;
            cmd.CommandText = sql3;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //Odanın Bilgilerinin güncellenebildiği kısım
        public static void oda_update(ComboBox combo_odano2)
        {

            con = new SqlConnection(SqlCon);
            string sql2 = "update tbl_odabilgi set odabosdolu=@odabos where odanumarası = @odano ";
            con.Open();
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@odabos", "Dolu");
            cmd.Parameters.AddWithValue("@odano", combo_odano2.Text);
            cmd.Connection = con;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
            con.Close();
            combo_odano2.Items.Remove(combo_odano2.SelectedItem);


        }
        static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True");

        // Dolu olan odaları Comboya ekleme Fonksiyonu
        public static void comboyagetir(ComboBox combo_odano2)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select *from tbl_odabilgi where odanumarası =@oda and odabosdolu = 'Dolu'  ", baglanti);
            komut4.Parameters.AddWithValue("@oda", combo_odano2.Text);
            SqlDataReader read4 = komut4.ExecuteReader();
            while (read4.Read())
            {

                combo_odano2.Items.Add(read4["odanumarası"]);


            }
            baglanti.Close();

        }
        // Error provider çağırma fonksiyonu.
        public static void errorperovidergetir(TextBox text, ErrorProvider erpr)
        {
            if (text.Text.Trim() == "")
                erpr.SetError(text, "Bu Alan Boş Geçilmez!!");
            else
                erpr.SetError(text, "");

        }

        public static void toplamgunhesapla(TextBox dateTime_cikis, TextBox dateTime_giris)
        {

            TimeSpan fark;
            fark = DateTime.Parse(dateTime_cikis.Text) - DateTime.Parse(dateTime_giris.Text);
           


        }
    }
}
