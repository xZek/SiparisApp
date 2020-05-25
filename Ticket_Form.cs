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
    public partial class Ticket_Form : Form
    {
        
        public Ticket_Form()
        {
            InitializeComponent();
           
        }

        private void Ticket_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////
            string Baglan_Db = "datasource=localhost;port=3306;username=root;password=;";
            string Veri_Gönder = "INSERT INTO siparis_takip.ticket(muster_ID,siparis_No,Ad_Soyad,Eposta,Mesaj) VALUES('" + Yetkili_Giris.ID + "','" + this.txt_siparisno.Text + "','" + this.txt_adsoyad.Text + "','" + this.txt_eposta.Text + "','" + this.txt_mesaj.Text + "') ;";
            ///////////////////////////////////////////////////////////////////////////////
           MySqlConnection Db = new MySqlConnection(Baglan_Db);
            MySqlCommand cmdDatabase = new MySqlCommand(Veri_Gönder, Db);
            MySqlDataReader DataReader;
            try
            {

                if (txt_siparisno.Text == "" || txt_adsoyad.Text == "" || txt_eposta.Text == "" || txt_mesaj.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                    Db.Close(); 
                }
                else
                {
                    Db.Open();
                    DataReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Şikayetiniz alınmıştır bildirdiğiniz için teşekkür ederiz. Mail yoluyla geri dönüş sağlancaktır.", "BİLDİRİ");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        
        }
    }
}
