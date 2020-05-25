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

    public partial class Yetkili_Giris : Form
    {
        public static string Ad;
        public static string Yetki;
        public static string ID;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Yetkili_Giris()
        {
            InitializeComponent();
            // VERITABANI BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            // VERITABANI BAGLANTISI 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //TEXTBOXA YAZILAN DEGERI PUBLIC AD DEĞERINE EŞITLIYOR BU SAYEDE DIGER FORMLARDA KULLANICI ADINI CEKEBILIYORUM
            Ad = txt_name.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            // KULLANICI ADI VE SIFRE KONTROLU
            cmd.CommandText = "SELECT * FROM users where Name='" + txt_name.Text + "' AND Password='" + txt_pass.Text + "'";
            // KULLANICI ADI VE SIFRE KONTROLU
            dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                //ID BILGISINI GETIRIYOR DIGER FORMLAR ICIN GEREKLI
                ID = dr["ID"].ToString();
                
                //YETKI BILGISINI GETIRIYOR
                Yetki = dr["Perm"].ToString();

                //EGERKI YETKI 0 ISE NORMAL KULLANICI FORMUNA YONLENDIRIYOR
                if (Yetki == "0")
                {
                    MessageBox.Show("Giriş Başarılı Yönlendiriliyorsunuz...", "BASARI");
                    Kpanel gec = new Kpanel();
                    this.Hide();
                    gec.Show();
                }
                    //BASKA BIR DEGERSE (1) YETKILI PANELINE YONLENDIRIYOR
                else {
                    MessageBox.Show("Giriş Başarılı Yönlendiriliyorsunuz...", "BASARI");
                    Yetkili_Panel gec = new Yetkili_Panel();
                    this.Hide();
                    gec.Show();
                }
            }
                //KULLANICI ADI VEYA SIFRE BOS ISE HATA MESAJINI EKRANDA GOSTERIYOR
            else if (txt_name.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("Lütfen Boş Kalan Alanları Doldurunuz", "HATA");
            }
            else
                //BU DONGUDEN CIKARSA DIGER BIR HATA SAYFASI GETIRIYOR
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.", "HATA");
            }
            con.Close();

        }

        //KAYIT OL EKRANINI ACAR
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            this.Hide();
            kayit.Show();
        }

        private void Yetkili_Giris_Load(object sender, EventArgs e)
        {

        }
        
    }
}
