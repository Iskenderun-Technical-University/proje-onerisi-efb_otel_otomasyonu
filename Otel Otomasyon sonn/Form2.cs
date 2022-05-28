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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            veritabani.baglantidurum();
            veritabani.GridDoldur(dataGridView1, "select * from tbl_giris");
        }


        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public  string SqlCon = "Data Source=LAPTOP-S6N20HE1\\SQLEXPRESS07;Initial Catalog = otelotomasyon; Integrated Security = True";
        

        private void girisgit_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
            this.Dispose();
        }
        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_giris", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_giris");
            dataGridView1.DataSource = ds.Tables["tbl_giris"];

            con.Close();
        }
        public void eklemesorgu(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }
        private void kulkaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "insert into tbl_giris(username,password,thedate)values(@user,@pass,@date)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("user", txtkulad.Text);
            cmd.Parameters.AddWithValue("pass", veritabani.MD5Ssifrele(txtkulpin.Text));
            cmd.Parameters.AddWithValue("date", DateTime.Now);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }
         
        private void btn_ksil_Click(object sender, EventArgs e)
            
        {
          
            con = new SqlConnection(SqlCon);
            string sql = "delete from tbl_giris where username=@user and kID=@kulid";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", txtkulad.Text);
            cmd.Parameters.AddWithValue("@kulid", Convert.ToInt32(txtkıd.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }


        private void Form2_Load(object sender, EventArgs e)

        {
            
            GridDoldur();

           // kaçıncı sutun gizlensin = visible
            dataGridView1.Columns[2].Visible = false;
            //sütün isimlerini tablodan bağımsız görüntüde değiştirmek için kullanılır
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[3].HeaderText = "Son Giriş Tarihi";
            dataGridView1.Columns[0].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[3].Width = 145;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtkıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtkulad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtkulpin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        //kullanıcı Güncelleme işlemi
        private void btn_kulguncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "update tbl_giris set password =@pass  where username = @user and kID =@kulid";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", txtkulad.Text);
            cmd.Parameters.AddWithValue("@pass", veritabani.MD5Ssifrele(txtkulpin.Text));
            cmd.Parameters.AddWithValue("@kulid", Convert.ToInt32(txtkıd.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }
        // Ekranı temizleyen buton
        private void txt_temizle_Click(object sender, EventArgs e)
        {
            txtkulad.Clear();
            txtkulpin.Clear();
            txtkıd.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

       

    }
}
