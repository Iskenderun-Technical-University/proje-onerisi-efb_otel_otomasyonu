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
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public string SqlCon = "Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True";

        public static string kullanicimsession = "";

        public string headtext = "Otel Golden";
        int s = 0;

        public void Login()
        {
            string sorgu = "select * from tbl_giris where  password=@sifre";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@sifre", txtpingir.Text);

            con.Open();

            dr = cmd.ExecuteReader();
            //Eğer veri geldiyse

            if (dr.Read())
            {
                MessageBox.Show("Tebrikler.Giriş Yaptınız..");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
                txtpingir.Clear();
                txtpingir.Focus();

            }
            con.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }
        public int denemesayisi = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            if (veritabani.LoginKontrol(txtpingir.Text))
            {

                Resepsiyonekran a = new Resepsiyonekran();
                this.Hide();
                a.Show();
              
            }
            else
            {
                denemesayisi++;
                if (denemesayisi == 3)
                {
                    MessageBox.Show("3 defa hatalı giriş yaptınız");
                    Application.Exit();
                }
               
            }
        }

        private void kulekle_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();



        }

        private void Form1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpingir.Text.Length == 4)
                {

                }
                else
                {
                    Button btn = (Button)sender;
                    txtpingir.Text += btn.Text;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Bir İşlem Yaptınız.");
                
            }

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Text = DateTime.Now.ToLongTimeString();
            
            s = s + 1;

            label2.Text = headtext.Substring(0, s);

            if (s > headtext.Length - 1)
            {
                s = 0;

            }

        }

    }
}

