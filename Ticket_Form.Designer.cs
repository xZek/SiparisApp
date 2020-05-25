namespace Sipariş_Takip
{
    partial class Ticket_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_siparisno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mesaj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(294, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "TICKET OLUSTUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siparis Numaranız : ";
            // 
            // txt_siparisno
            // 
            this.txt_siparisno.Location = new System.Drawing.Point(413, 179);
            this.txt_siparisno.Name = "txt_siparisno";
            this.txt_siparisno.Size = new System.Drawing.Size(204, 20);
            this.txt_siparisno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(317, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad : ";
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(413, 214);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(204, 20);
            this.txt_adsoyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(329, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-Posta : ";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(413, 251);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(203, 20);
            this.txt_eposta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sorununuzu Birkaç Kelimeyle Belirtiniz : ";
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(413, 277);
            this.txt_mesaj.Multiline = true;
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(203, 64);
            this.txt_mesaj.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "GÖNDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 339);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Ticket_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_adsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_siparisno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Takip App";
            this.Load += new System.EventHandler(this.Ticket_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_siparisno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}