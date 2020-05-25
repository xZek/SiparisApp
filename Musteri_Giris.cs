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
    public partial class Musteri_Giris : Form
    {  
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public static string Siparis_No;
        public Musteri_Giris()
        {  
            InitializeComponent();
            // VERITABANI BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            // VERITABANI BAGLANTISI 
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt_siparisno.Text = "Siparis No";
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Siparis_No = txt_siparisno.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            //SIPARIS NO CEKMEK ICIN GEREKEN SORGU
            cmd.CommandText = "SELECT * FROM siparisler where Siparis_No='" + txt_siparisno.Text + "'";
            //SIPARIS NO CEKMEK ICIN GEREKEN SORGU
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Siparişe Aktarılıyorsunuz");
                Musteri_Panel sorgula = new Musteri_Panel();
                this.Hide();
                sorgula.Show();
            
            }
            else if (txt_siparisno.Text == "")
            {
                MessageBox.Show("Sipariş Numarası Giriniz");
            }
            else
            {
                MessageBox.Show("Sipariş Numarası Hatalı");
            }
            con.Close();
        }
        private void lnk_adm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yetkili_Giris panel = new Yetkili_Giris();
            this.Hide();
            panel.Show();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            KayitOl kayitol = new KayitOl();
            this.Hide();
            kayitol.Show();
        }

      

      

       
        }
     
    }

