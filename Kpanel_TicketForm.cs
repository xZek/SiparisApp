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
    public partial class Kpanel_TicketForm : Form
    {
        MySqlConnection con;
        public Kpanel_TicketForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=siparis_takip;user=root;Pwd=;SslMode=none");
   
        }
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter data = new MySqlDataAdapter();
        private void Kpanel_TicketForm_Load(object sender, EventArgs e)
        {
            lbl_title.Text = Yetkili_Giris.Ad;
           
            con.Open();
            cmd.Connection = con;
            string sqlsorgusu = "SELECT * FROM ticket where muster_ID='" + Yetkili_Giris.ID + "'";
            DataTable tablo = new DataTable();
            cmd.CommandText = sqlsorgusu;

            data.SelectCommand = cmd;
            data.Fill(tablo);
            con.Close();
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["muster_ID"].Visible = false;
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.Columns["Siparis_No"].ReadOnly = true;
            dataGridView1.Columns["Ad_Soyad"].ReadOnly = true;
            dataGridView1.Columns["Eposta"].ReadOnly = true;
            dataGridView1.Columns["Mesaj"].ReadOnly = true;
            dataGridView1.Columns["Yanit"].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kpanel siparisler = new Kpanel();
            this.Hide();
            siparisler.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Kpanel_TicketForm yenile = new Kpanel_TicketForm();
            this.Hide();
            yenile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket_FormEkle ekle = new Ticket_FormEkle();
            ekle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            int gelenden = 0;
            gelenden = Convert.ToInt32(txt_id.Text);
            cmd.Connection = con;
            cmd.CommandText = "delete from ticket Where ID=" + txt_id.Text + " ";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(gelenden + " " + "Siparis Nolu Sipariş Silindi.");
            Kpanel_TicketForm yenile = new Kpanel_TicketForm();
            this.Hide();
            yenile.Show();
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
