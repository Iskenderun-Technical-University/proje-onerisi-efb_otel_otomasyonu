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
    public partial class BildirimEkran : Form
    {
        public BildirimEkran()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True");
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public string SqlCon = "Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True";

    

        private void BildirimEkran_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tbl_odabilgi ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["odanumarası"]);

            }
            baglanti.Close();
        }
        //Bildirimler Adlı DataGride Veri Gönderme İşlemi 
        private void button13_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "insert into tbl_bildirimler(OdaNo,Bildirimler,BildirimTarihi)values(@OdaNoo,@Bildirimlerr,@BildirimTarihii)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@OdaNoo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Bildirimlerr", txt_bildirim.Text);
            cmd.Parameters.AddWithValue("@BildirimTarihii", dateTimePicker1.Value);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bildirim Gönderildi.");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             txt_bildirim.Text = button1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button2.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button12.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button6.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_bildirim.Text = button7.Text;
        }
    }
}
