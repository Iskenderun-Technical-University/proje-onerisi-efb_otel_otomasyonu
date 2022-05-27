using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_deneme_1
{
    public partial class OdaDurumKontrol : Form
    {
        public OdaDurumKontrol()
        {
            InitializeComponent();
            veritabani.GridDoldur(dataGridView1, "select * from tbl_odabilgi");
        }

        private void OdaDurumKontrol_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Bos")
                {

                    renk.BackColor = Color.Green;

                }
                else
                {
                    renk.BackColor = Color.Red;

                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }


            //Oda Bilgilerinin Olduğu Data Ekranının Düzenlenmesi.
            // kaçıncı sutun gizlensin = visible
            dataGridView1.Columns[0].Visible = false;
            //sütün isimlerini tablodan bağımsız görüntüde değiştirmek için kullanılır
            dataGridView1.Columns[1].HeaderText = "Oda Numarası";
            dataGridView1.Columns[2].HeaderText = "Bulunuduğu Kat";
            dataGridView1.Columns[3].HeaderText = "Kapasite";
            dataGridView1.Columns[4].HeaderText = "Oda Manzarası";
            dataGridView1.Columns[5].HeaderText = "Oda Durumu";

        }
    }
}
