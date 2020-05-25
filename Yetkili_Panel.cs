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
    public partial class Yetkili_Panel : Form
    {
       
        public Yetkili_Panel()
        {
            InitializeComponent();
         
        }

        private void Yetkili_Panel_Load(object sender, EventArgs e)
        {

           
            timer1.Enabled = true;
            MySqlConnection con;
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter tablo = new MySqlDataAdapter(cmd);
           
            // MYSQL SERVER BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            con.Open();
           
            // VERITABANI BAGLANTISI  
            cmd.CommandText = "SELECT * FROM users  where Name='" + Yetkili_Giris.Ad + "'";
            cmd.Connection = con;
            // VERITABANI BAGLANTISI 
           
          
            
       
            ///////////                 TOPLAM SIPARISI CEKMEK ICIN GEREKEN SORGU             /////////////////////////////
           
            DataTable siparis_getir = new DataTable();
            DataSet siparis_tablo = new DataSet();
            cmd.CommandText = "SELECT * FROM siparisler";
            siparis_tablo.Clear();
            tablo.Fill(siparis_tablo, "siparisler");
            lbl_siparis.Text = siparis_tablo.Tables["siparisler"].Rows.Count.ToString();

            ///////////                 TOPLAM SIPARISI CEKMEK ICIN GEREKEN SORGU             /////////////////////////////



            ///////////                 TOPLAM TICKETLARI CEKMEK ICIN GEREKEN SORGU             /////////////////////////////
          
            DataTable ticket_getir = new DataTable();
            DataSet ticket_tablo = new DataSet();
            cmd.CommandText = "SELECT * FROM ticket";
            siparis_tablo.Clear();
            tablo.Fill(siparis_tablo, "ticket");
            lbl_ticketx.Text = siparis_tablo.Tables["ticket"].Rows.Count.ToString();

            ///////////                 TOPLAM TICKETLARI CEKMEK ICIN GEREKEN SORGU             /////////////////////////////



            lbl_title.Text = Yetkili_Giris.Ad;
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yetkili_Panel2 siparis = new Yetkili_Panel2();
           this.Hide();
            siparis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere");
            Yetkili_Giris girisyap = new Yetkili_Giris();
            this.Hide();
            girisyap.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            lbl_saat.Text = saat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yetkili_Panel3 ticketlar = new Yetkili_Panel3();
            this.Hide();
            ticketlar.Show();
        }
    }
}
