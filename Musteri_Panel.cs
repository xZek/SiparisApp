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
    public partial class    Musteri_Panel : Form
    {
        MySqlConnection con;

        public Musteri_Panel()
        {
            InitializeComponent();
            // VERITABANI BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            // VERITABANI BAGLANTISI 
        }

        private void Musteri_Panel_Load(object sender, EventArgs e)
        {



            lbl_buttonil.Visible = false;



            ///////////////////////
            String Urun_TakipNo;
            String Urun_Adi;
            String Urun_Fiyati;
            String Urun_Adeti;
            String Urun_Sahibi;
            String Urun_Nerde;
            String Urun_Teslim;
            String Urun_Iletisim;
            String Urun_Ulasildimi;
            ///////////////////////


            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            //SIPARIS NO CEKMEK ICIN GEREKEN SORGU
            cmd.CommandText = "SELECT * FROM siparisler  where Siparis_No='" + Musteri_Giris.Siparis_No + "'";
            //SIPARIS NO CEKMEK ICIN GEREKEN SORGU
            cmd.ExecuteNonQuery();
            MySqlDataReader veri = cmd.ExecuteReader();
            if ((veri.Read()))
            {
                //////////////////////////////////////////////////////////////
                Urun_TakipNo    = veri["Siparis_No"].ToString();
                Urun_Adi        = veri["Urun_Adi"].ToString();
                Urun_Fiyati     = veri["Urun_Fiyati"].ToString();
                Urun_Adeti      = veri["Urun_Adeti"].ToString();
                Urun_Sahibi     = veri["Urun_Sahibi"].ToString();
                Urun_Nerde      = veri["Urun_Nerde"].ToString();
                Urun_Teslim     = veri["Urun_TeslimTarihi"].ToString();
                Urun_Iletisim   = veri["Urun_Iletisim"].ToString();
                Urun_Ulasildimi = veri["Urun_Ulasildimi"].ToString();
                //////////////////////////////////////////////////////////////             
                lbl_numara.Text = Urun_TakipNo;
                lbl_urunadı.Text = Urun_Adi;
                lbl_urunfiyati.Text = Urun_Fiyati + " TL";
                lbl_urunsahibi.Text = Urun_Sahibi;
                lbl_urunadeti.Text = Urun_Adeti;
                lbl_urunnerde.Text = Urun_Nerde;
                lbl_urunteslim.Text = Urun_Teslim;
                lbl_buttonil.Text = Urun_Iletisim;
                lbl_ulasıldımı.Text = Urun_Ulasildimi;
                /////////////////////////////////////////////////////////// 
            }
            if (lbl_ulasıldımı.Text == "0")
            {
               lbl_ulasıldımı.Text = "Ürün Henüz Ulaşılmadı";
            }
            else if (lbl_ulasıldımı.Text == "1") 
            {
                lbl_ulasıldımı.Text = "Ürün Teslim Edildi";
            }
           
        }

        private void lbl_siparisno_Click(object sender, EventArgs e)
        {

        }

        private void lbl_urunnerde_Click(object sender, EventArgs e)
        {

        }
        private void btn_info1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_buttonil.Text, "ILETISIM BILGILERI");
        }

        private void btn_info2_Click(object sender, EventArgs e)
        {
            Ticket_Form ticket = new Ticket_Form();
            
            ticket.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere");
            Musteri_Giris girisyap = new Musteri_Giris();
            this.Hide();
            girisyap.Show();
        }
    }
}
