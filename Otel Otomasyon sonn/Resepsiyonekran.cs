using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otel_deneme_1
{
    public partial class Resepsiyonekran : Form
    {
        public Resepsiyonekran()
        {
            InitializeComponent();
            label7.Text = Form1.kullanicimsession.ToString();
            veritabani.GridDoldur(bildirim_datagrid,"select * from tbl_bildirimler");
            veritabani.GridDoldur(musteribilgi_dataGrid, "select * from tbl_musterikayit1");
        }
        
        // Veri Tabanı Bağlantıları.

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True");
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd2,cmd3;
        DataSet ds;
        public string SqlCon = "Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True";



            private void Resepsiyonekran_Load(object sender, EventArgs e)


        {
            //// TODO: Bu kod satırı 'otelotomasyonDataSet28.tbl_bildirimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_bildirimlerTableAdapter2.Fill(this.otelotomasyonDataSet28.tbl_bildirimler);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet27.tbl_bildirimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //// this.tbl_bildirimlerTableAdapter1.Fill(this.otelotomasyonDataSet27.tbl_bildirimler);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet211.tbl_bildirimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_bildirimlerTableAdapter.Fill(this.otelotomasyonDataSet211.tbl_bildirimler);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet18.tbl_musterikayit1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_musterikayit1TableAdapter2.Fill(this.otelotomasyonDataSet18.tbl_musterikayit1);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet16.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter5.Fill(this.otelotomasyonDataSet16.tbl_odabilgi);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet15.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter4.Fill(this.otelotomasyonDataSet15.tbl_odabilgi);

    
            // // TODO: Bu kod satırı 'otelotomasyonDataSet14.tbl_musterikayit1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.tbl_musterikayit1TableAdapter1.Fill(this.otelotomasyonDataSet14.tbl_musterikayit1);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet13.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter3.Fill(this.otelotomasyonDataSet13.tbl_odabilgi);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet12.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter2.Fill(this.otelotomasyonDataSet12.tbl_odabilgi);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet9.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            ////this.tbl_odabilgiTableAdapter2.Fill(this.otelotomasyonDataSet9.tbl_odabilgi);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet8.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter1.Fill(this.otelotomasyonDataSet8.tbl_odabilgi);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet7.tbl_musterikayit1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_musterikayit1TableAdapter.Fill(this.otelotomasyonDataSet7.tbl_musterikayit1);
            //// TODO: Bu kod satırı 'otelotomasyonDataSet6.tbl_odabilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_odabilgiTableAdapter.Fill(this.otelotomasyonDataSet6.tbl_odabilgi);

           


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Ulkeler ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo_ulkeler.Items.Add(read["UlkeAD"]);

            }
            baglanti.Close();

            //Oda Numaralarını Dolu olanları comboboxdan siler

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from tbl_odabilgi where odabosdolu = 'Bos'  ", baglanti);
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {

                combo_odano2.Items.Add(read1["odanumarası"]);

            }
            baglanti.Close();






            // Ödeme Türlerini veri tabanından çekme 

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from tbl_odemetur ", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                combo_odemesekli.Items.Add(read2["odemetur"]);
                

            }
            baglanti.Close();
            

            bildirim_datagrid.Columns[0].Visible = false;

            bildirim_datagrid.Columns[1].HeaderText = "Oda Numarası";
            bildirim_datagrid.Columns[2].HeaderText = "Gelen Bildirim";
            bildirim_datagrid.Columns[3].HeaderText = "Bildirim Tarihi";
            bildirim_datagrid.Columns[2].Width = 260;
            bildirim_datagrid.Columns[3].Width = 100;
            bildirim_datagrid.Columns[1].Width = 60;
           


            //Müşteri Bilgilerinin Olduğu Data Ekranının Düzenlenmesi.
            musteribilgi_dataGrid.Columns[0].Visible = false;
            //sütün isimlerini tablodan bağımsız görüntüde değiştirmek için kullanılır
            musteribilgi_dataGrid.Columns[1].HeaderText = "İsim";
            musteribilgi_dataGrid.Columns[2].HeaderText = "Soysim";
            musteribilgi_dataGrid.Columns[3].HeaderText = "Kimlik No";
            musteribilgi_dataGrid.Columns[4].HeaderText = "Cep Telefonu";
            musteribilgi_dataGrid.Columns[5].HeaderText = "Hes Kodu";
            musteribilgi_dataGrid.Columns[6].HeaderText = "Uyruk";
            musteribilgi_dataGrid.Columns[7].HeaderText = "Oda Numarası";
            musteribilgi_dataGrid.Columns[8].HeaderText = "Giriş Tarihi";
            musteribilgi_dataGrid.Columns[9].HeaderText = "Çıkış Tarihi";
            musteribilgi_dataGrid.Columns[10].HeaderText = " Günlük Ücret";
            musteribilgi_dataGrid.Columns[11].HeaderText = " Toplam Ücret";
            musteribilgi_dataGrid.Columns[12].HeaderText = "Ödeme Şekli";
            //Müşteri Bilgileri Görüntüleme Ekranı Düzenlenmesi
            for (int i = 1; i < 13; i++)
            {
                musteribilgi_dataGrid.Columns[i].Width = 82;
            }

            


           // Set the MinDate and MaxDate.
           dateTime_cikis.MaxDate = new DateTime(2030, 6, 20);
            dateTime_cikis.MinDate = new DateTime(2021, 5, 27 );

            dateTime_giris.MaxDate = new DateTime(2030, 6, 20);
            dateTime_giris.MinDate = new DateTime(2021, 5, 27);



        }

          //Oda Sat butonunun işlevleri (Veri Ekleme )
        private void odasat_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql1 = "insert into tbl_musterikayit2(namee,surnamee,idenitynoo,mobilnoo,hescodee,uyrukk,odanoo,entrydatee,leavingdatee,payy,totalpayy,paykindd,islemyapann)values(@nameee,@surnameee,@idenitynooo,@mobilnooo,@hescodeee,@uyrukkk,@odanooo,@entrydateee,@leavingdateee,@payyy,@totalpayyy,@paykinddd,@islemyapannn)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nameee", txtmstad.Text);
            cmd.Parameters.AddWithValue("@surnameee", txtmstsoyad.Text);
            cmd.Parameters.AddWithValue("@idenitynooo", txtmsttc.Text);
            cmd.Parameters.AddWithValue("@mobilnooo", txtmsttel.Text);
            cmd.Parameters.AddWithValue("@hescodeee", txtmsthes.Text);
            cmd.Parameters.AddWithValue("@uyrukkk", combo_ulkeler.SelectedItem);
            cmd.Parameters.AddWithValue("@odanooo", combo_odano2.Text);
            cmd.Parameters.AddWithValue("@entrydateee", dateTime_giris.Value);
            cmd.Parameters.AddWithValue("@leavingdateee", dateTime_cikis.Value);
            cmd.Parameters.AddWithValue("@payyy", txt_gunlukucret.Text);
            cmd.Parameters.AddWithValue("@totalpayyy", txt_toplamucret.Text);
            cmd.Parameters.AddWithValue("@paykinddd", combo_odemesekli.SelectedItem);
            cmd.Parameters.AddWithValue("@islemyapannn", label7.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql1;
            cmd.ExecuteNonQuery();
            


            con.Close();


            //Kalıcı Olarak Kontol Edilmesi İçin Müşteri Kayıt Bilgisinin Tutulması

            con = new SqlConnection(SqlCon);
            string sql = "insert into tbl_musterikayit1(name,surname,idenityno,mobilno,hescode,uyruk,odano,entrydate,leavingdate,pay,totalpay,paykind)values(@namee,@surnamee,@idenitynoo,@mobilnoo,@hescodee,@uyrukk,@odanoo,@entrydatee,@leavingdatee,@payy,@totalpayy,@paykindd)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@namee", txtmstad.Text);
            cmd.Parameters.AddWithValue("@surnamee", txtmstsoyad.Text);
            cmd.Parameters.AddWithValue("@idenitynoo", txtmsttc.Text);
            cmd.Parameters.AddWithValue("@mobilnoo", txtmsttel.Text);
            cmd.Parameters.AddWithValue("@hescodee", txtmsthes.Text);
            cmd.Parameters.AddWithValue("@uyrukk", combo_ulkeler.SelectedItem);
            cmd.Parameters.AddWithValue("@odanoo", combo_odano2.Text);
            cmd.Parameters.AddWithValue("@entrydatee", dateTime_giris.Value);
            cmd.Parameters.AddWithValue("@leavingdatee", dateTime_cikis.Value);
            cmd.Parameters.AddWithValue("@payy", txt_gunlukucret.Text);
            cmd.Parameters.AddWithValue("@totalpayy", txt_toplamucret.Text);
            cmd.Parameters.AddWithValue("@paykindd", combo_odemesekli.SelectedItem);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Oda Satıldı...");
            con.Close();
            veritabani.oda_update(combo_odano2);

            veritabani.GridDoldur(musteribilgi_dataGrid, "select * from tbl_musterikayit1");

    

        }

        //Müşteri Bilgilerini Günceller


        private void odaguncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(SqlCon);
            string sql = "update tbl_musterikayit1 set name =@namee,surname=@surnamee,idenityno=@idenitynoo,mobilno=@mobilnoo,hescode=@hescodee,uyruk=@uyrukk,odano=@odanoo,entrydate=@entrydatee,leavingdate=@leavingdatee,pay=@payy,totalpay=@totalpayy,paykind=@paykindd where customID=@cid";
            cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(label9.Text));
            cmd.Parameters.AddWithValue("@namee", txtmstad.Text);
            cmd.Parameters.AddWithValue("@surnamee", txtmstsoyad.Text);
            cmd.Parameters.AddWithValue("@idenitynoo", txtmsttc.Text);
            cmd.Parameters.AddWithValue("@mobilnoo", txtmsttel.Text);
            cmd.Parameters.AddWithValue("@hescodee", txtmsthes.Text);
            cmd.Parameters.AddWithValue("@uyrukk", combo_ulkeler.SelectedItem);
            cmd.Parameters.AddWithValue("@odanoo", combo_odano2.Text);
            cmd.Parameters.AddWithValue("@entrydatee", dateTime_giris.Value);
            cmd.Parameters.AddWithValue("@leavingdatee", dateTime_cikis.Value);
            cmd.Parameters.AddWithValue("@payy", txt_gunlukucret.Text);
            cmd.Parameters.AddWithValue("@totalpayy", txt_toplamucret.Text);
            cmd.Parameters.AddWithValue("@paykindd", combo_odemesekli.SelectedItem);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            veritabani.oda_update(combo_odano2);
            
            veritabani.GridDoldur(musteribilgi_dataGrid, "select *from tbl_musterikayit1");
            MessageBox.Show("Müşteri Kaydı Güncellendi.");


        }



        
        
       
        //Otelde konaklayan müşterilerin bilgilerinin datagride tıklanıldığı yerden textbox ve comboboxlara alınması için gerekli kod bloğu.
        private void musteribilgi_dataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = musteribilgi_dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtmstad.Text = musteribilgi_dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtmstsoyad.Text = musteribilgi_dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtmsttc.Text = musteribilgi_dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtmsttel.Text = musteribilgi_dataGrid.CurrentRow.Cells[4].Value.ToString();
            txtmsthes.Text = musteribilgi_dataGrid.CurrentRow.Cells[5].Value.ToString();
            combo_ulkeler.Text = musteribilgi_dataGrid.CurrentRow.Cells[6].Value.ToString();
            combo_odano2.Text = musteribilgi_dataGrid.CurrentRow.Cells[7].Value.ToString();
            dateTime_giris.Text = musteribilgi_dataGrid.CurrentRow.Cells[8].Value.ToString();
            dateTime_cikis.Text = musteribilgi_dataGrid.CurrentRow.Cells[9].Value.ToString();
            txt_gunlukucret.Text = musteribilgi_dataGrid.CurrentRow.Cells[10].Value.ToString();
            txt_toplamucret.Text = musteribilgi_dataGrid.CurrentRow.Cells[11].Value.ToString();
            combo_odemesekli.Text = musteribilgi_dataGrid.CurrentRow.Cells[12].Value.ToString();
        }

        // Müşterinin otelden Çıkış İşlemi 
        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "delete from tbl_musterikayit1 where name=@namee and customID=@cid";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(label9.Text));
            cmd.Parameters.AddWithValue("@namee", txtmstad.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Çıkışı Yapıldı.");
            veritabani.comboyagetir(combo_odano2);
            veritabani.updates(combo_odano2);
            //veritabani.GridDoldur(odabilgi_dataGrid, "select *from tbl_odabilgi");
            veritabani.GridDoldur(musteribilgi_dataGrid, "select *from tbl_musterikayit1");

        }

        // Oda satış ekranında ki bilgileri(textbox vs) temizleme 
        private void btn_temizle_Click(object sender, EventArgs e)
        {

            txtmstad.Clear();
            txtmstsoyad.Clear();
            txtmsttc.Clear();
            txtmsttel.Clear();
            txtmsthes.Clear();
            combo_odano2.Text = "";
            combo_odemesekli.Text = "";
            combo_ulkeler.Text = "";
            dateTime_giris.Value = DateTime.Now;
            dateTime_cikis.Value = DateTime.Now;
            txt_gunlukucret.Text="0";
            txt_toplamucret.Text="0";

        }

        // ErrorProvider işlemleri
       

        private void txtmstad_Validated(object sender, EventArgs e)
        {

            veritabani.errorperovidergetir(txtmstad, errorProvider1);
            
        }

        private void txtmstsoyad_Validated(object sender, EventArgs e)
        {
            veritabani.errorperovidergetir(txtmstsoyad, errorProvider1);
        }

        private void txtmsttel_Validated(object sender, EventArgs e)
        {
            veritabani.errorperovidergetir(txtmsttel, errorProvider1);
        }

    

        private void txt_gunlukucret_Validated(object sender, EventArgs e)
        {
            veritabani.errorperovidergetir(txtmstad, errorProvider1);
        }

        private void txt_toplamucret_Validated(object sender, EventArgs e)
        {
            veritabani.errorperovidergetir(txt_toplamucret, errorProvider1);
        }

        private void dateTime_cikis_ValueChanged(object sender, EventArgs e)
        {
            toplamgunhesapla();
        }

        private void txt_gunlukucret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_toplamgun.Text != "")
                {
                    txt_toplamucret.Text = (int.Parse(txt_gunlukucret.Text) * int.Parse(txt_toplamgun.Text)).ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Türde Değer Girdiniz.");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void toplamgunhesapla()
        {

            TimeSpan fark;
            fark = DateTime.Parse(dateTime_cikis.Text) - DateTime.Parse(dateTime_giris.Text);
            txt_toplamgun.Text = fark.TotalDays.ToString();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Formu Hareket Ettirmek İçin oluşturulan tanımlamalar

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);

        private void Resepsiyonekran_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Resepsiyonekran_MouseMove(object sender, MouseEventArgs e)
        {

            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Resepsiyonekran_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void btn_odabildirimekranagit_Click(object sender, EventArgs e)
        {
            BildirimEkran a = new BildirimEkran();
            a.ShowDialog();
        }

       

        private void btnkayıtgit_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        //Giriş Ekranına Gidilmesini Sağlayan Buton

        private void btngirisekranı_Click(object sender, EventArgs e)
        {

                Form1 a = new Form1();
                this.Hide();
                a.ShowDialog();
                this.Dispose();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            veritabani.GridDoldur(bildirim_datagrid, "select *from tbl_bildirimler");

        }

        private void btnodadurumgit_Click_1(object sender, EventArgs e)
        {
            OdaDurumKontrol a = new OdaDurumKontrol();
            a.ShowDialog();
        }



        //Oda Bilgilerini Görüntülemek için buton kodu
        private void btn_odagoruntule_Click(object sender, EventArgs e)
        {
            OdaDurumKontrol a = new OdaDurumKontrol();
            a.ShowDialog();
        }



    }
}
