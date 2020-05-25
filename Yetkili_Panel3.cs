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
    public partial class Yetkili_Panel3 : Form
    {

        public Yetkili_Panel3()
        {
            InitializeComponent();

        }
        private MySqlDataAdapter da;        // Data Adapter
        private DataSet ds;                 // Dataset
        private string sTable = "ticket";  // Table Name

        MySqlConnection con;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        private void Yetkili_Panel_Load(object sender, EventArgs e)
        {

            // VERITABANI BAGLANTISI
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
            // VERITABANI BAGLANTISI 


            lbl_title.Text = Yetkili_Giris.Ad;

            dataGridView1.DataSource = tabloyapisi();


            try
            {

                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM ticket;", con);
                ds = new DataSet();
                da.Fill(ds, sTable);
                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Refresh();

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = sTable;

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

            }
        }
        DataTable tabloyapisi()
        {
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("select * from ticket", con);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            con.Close();
            return tablo;
        }
        private void button_anasayfa_Click(object sender, EventArgs e)
        {
            Yetkili_Panel anasayfa = new Yetkili_Panel();
            this.Hide();
            anasayfa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere");
            Yetkili_Giris girisyap = new Yetkili_Giris();
            this.Hide();
            girisyap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yetkili_Panel2 siparis = new Yetkili_Panel2();
            this.Hide();
            siparis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_silx.Text == "")
            {
                MessageBox.Show("Lütfen Siparis No Giriniz.");
            }
            int gelenden = 0;
            gelenden = Convert.ToInt32(txt_silx.Text);
            cmd.Connection = con;
            cmd.CommandText = "delete from ticket Where Siparis_No=" + txt_silx.Text + " ";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(gelenden + " " + "Siparis Nolu Siparis Silindi.");
            Yetkili_Panel3 yenile = new Yetkili_Panel3();
            this.Hide();
            yenile.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(da);

            da.Update(ds, sTable);

            dataGridView1.DataSource = ds;     

            }

     

        }
   
}

        
        
    


