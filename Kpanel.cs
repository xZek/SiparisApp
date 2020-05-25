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
    public partial class Kpanel : Form
    {
        MySqlConnection con;
        public Kpanel()
        {
            InitializeComponent();

            // MYSQL SERVER BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
   

       
        }
      
        private void Kpanel_Load(object sender, EventArgs e)
        {
            lbl_title.Text = Yetkili_Giris.Ad;
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter data = new MySqlDataAdapter();
            con.Open();
            cmd.Connection = con;
            string sqlsorgusu = "SELECT * FROM siparisler where musteri_ID='" + Yetkili_Giris.ID + "'";
            DataTable tablo = new DataTable();
            cmd.CommandText = sqlsorgusu;

            data.SelectCommand = cmd;
            data.Fill(tablo);
            con.Close();
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["musteri_ID"].Visible = false;
            dataGridView1.Columns["Siparis_No"].ReadOnly = true;
            dataGridView1.Columns["Urun_Adi"].ReadOnly = true;
            dataGridView1.Columns["Urun_Fiyati"].ReadOnly = true;
            dataGridView1.Columns["Urun_Adeti"].ReadOnly = true;
            dataGridView1.Columns["Urun_Sahibi"].ReadOnly = true;
            dataGridView1.Columns["Urun_Nerde"].ReadOnly = true;
            dataGridView1.Columns["Urun_TeslimTarihi"].ReadOnly = true;
            dataGridView1.Columns["Urun_iletisim"].ReadOnly = true;
            dataGridView1.Columns["Urun_Ulasildimi"].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kpanel_TicketForm ticket = new Kpanel_TicketForm();
            this.Hide();
            ticket.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere", "CIKIS");
            Musteri_Giris login = new Musteri_Giris();
            this.Hide();
            login.Show();
        }
    }
}
