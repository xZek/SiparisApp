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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        private void KayitOl_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Normal Kullanici");
            comboBox1.Items.Add("Admin Kullanici");
          
 
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Box_String;
            int Box_Int;
            Box_String = comboBox1.Text;
            Box_Int = comboBox1.SelectedIndex;
        
            ///////////////////////////////////////////////////////////////////////////////
            string Baglan_Db = "datasource=localhost;port=3306;username=root;password=;";
            string Veri_Gönder = "INSERT INTO siparis_takip.users(Name,Password,Mail,Perm) VALUES('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox4.Text + "','" + Box_Int + "') ;";
            ///////////////////////////////////////////////////////////////////////////////
            MySqlConnection Db = new MySqlConnection(Baglan_Db);
            MySqlCommand cmdDatabase = new MySqlCommand(Veri_Gönder, Db);
            MySqlDataReader DataReader;
            try
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                    Db.Close();
                }
                else
                {
                    Db.Open();
                    DataReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Kaydiniz Tamamlanmiştir Giriş Sayfasına Yönlendiriliyorsunuz.", "BİLDİRİ");
                    Yetkili_Giris girisyap = new Yetkili_Giris();
                    this.Hide();
                    girisyap.Show();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri_Giris form1 = new Musteri_Giris();
            this.Hide();
            form1.Show();
        }

      
    }
}
