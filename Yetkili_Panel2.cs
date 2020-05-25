using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Takip
{
    public partial class Yetkili_Panel2 : Form
    {
        public Yetkili_Panel2()
        {
            InitializeComponent();
        }
      

        MySqlConnection con;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        private void Yetkili_Panel2_Load(object sender, EventArgs e)
        {
            // VERITABANI BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            // VERITABANI BAGLANTISI 


            lbl_title.Text = Yetkili_Giris.Ad;

            dataGridView1.DataSource = tabloyapisi();


        }
        DataTable tabloyapisi()
        {
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("select * from siparisler", con);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            con.Close();
            return tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yetkili_Panel3 gec = new Yetkili_Panel3();
            this.Hide();
            gec.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere");
            Yetkili_Giris girisyap = new Yetkili_Giris();
            this.Hide();
            girisyap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();

            int Urun_ID, musteri_ID, Siparis_No;

             Urun_ID     = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
             musteri_ID =  Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_ID"].Value);
             Siparis_No = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Siparis_No"].Value);


            /////////////////////////////////////////////////////////////////////////////
           
            string Urun_Fiyati, Urun_Adi,Urun_Adeti,Urun_Sahibi,Urun_Nerde,Urun_TeslimTarihi,Urun_Iletisim,Urun_Ulasildimi;
            
            Urun_Fiyati = dataGridView1.CurrentRow.Cells["Urun_Fiyati"].Value.ToString();
            Urun_Adi    = dataGridView1.CurrentRow.Cells["Urun_Adi"].Value.ToString();
            Urun_Adeti  = dataGridView1.CurrentRow.Cells["Urun_Adeti"].Value.ToString();
            Urun_Sahibi = dataGridView1.CurrentRow.Cells["Urun_Sahibi"].Value.ToString();
            Urun_Nerde  = dataGridView1.CurrentRow.Cells["Urun_Nerde"].Value.ToString();
            Urun_TeslimTarihi = dataGridView1.CurrentRow.Cells["Urun_TeslimTarihi"].Value.ToString();
            Urun_Iletisim = dataGridView1.CurrentRow.Cells["Urun_iletisim"].Value.ToString();
            Urun_Ulasildimi = dataGridView1.CurrentRow.Cells["Urun_Ulasildimi"].Value.ToString();
            //////////////////////////////////////////////////////////////////////////////////

            string sql = "update siparisler set musteri_ID='" + musteri_ID + "', Siparis_No='" + Siparis_No +
            "', Urun_Adi='" + Urun_Adi + "', Urun_Fiyati='" + Urun_Fiyati + "',Urun_Adeti='" + Urun_Adeti + 
            "', Urun_Sahibi='" + Urun_Sahibi + "', Urun_Nerde='" + Urun_Nerde + "', Urun_TeslimTarihi = '"
            + Urun_TeslimTarihi + "', Urun_iletisim='" + Urun_Iletisim + "', Urun_Ulasildimi='" + Urun_Ulasildimi +
            "'where ID=" + Urun_ID;
          //  string sql = "update siparisler set Urun_Fiyati='" + Urun_Fiyati + "' where ID=" + Urun_ID;
            MySqlCommand komut = new MySqlCommand(sql , con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            con.Close();
        }

        private void button_anasayfa_Click(object sender, EventArgs e)
        {
            Yetkili_Panel anasayfa = new Yetkili_Panel();
            this.Hide();
            anasayfa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_silx.Text == "")
            {

                MessageBox.Show("Lütfen Siparis No Giriniz.");
            }
            else
            {
                int gelenden = 0;
                gelenden = Convert.ToInt32(txt_silx.Text);
                cmd.Connection = con;
                cmd.CommandText = "delete from siparisler Where Siparis_No=" + txt_silx.Text + " ";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(gelenden + " " + "Siparis Nolu Siparis Silindi.");
                Yetkili_Panel2 yenile = new Yetkili_Panel2();
                this.Hide();
                yenile.Show();
            }
            }
    }
}
