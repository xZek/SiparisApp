namespace Sipariş_Takip
{
    partial class Musteri_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri_Giris));
            this.lbl_takpno = new System.Windows.Forms.Label();
            this.txt_siparisno = new System.Windows.Forms.TextBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_takpno
            // 
            this.lbl_takpno.AutoSize = true;
            this.lbl_takpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_takpno.Location = new System.Drawing.Point(83, 243);
            this.lbl_takpno.Name = "lbl_takpno";
            this.lbl_takpno.Size = new System.Drawing.Size(293, 24);
            this.lbl_takpno.TabIndex = 1;
            this.lbl_takpno.Text = "Siparis Takip Numarasıını Giriniz : ";
            // 
            // txt_siparisno
            // 
            this.txt_siparisno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_siparisno.Location = new System.Drawing.Point(382, 241);
            this.txt_siparisno.Multiline = true;
            this.txt_siparisno.Name = "txt_siparisno";
            this.txt_siparisno.Size = new System.Drawing.Size(282, 33);
            this.txt_siparisno.TabIndex = 2;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.FlatAppearance.BorderSize = 0;
            this.btn_sorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorgula.Image = ((System.Drawing.Image)(resources.GetObject("btn_sorgula.Image")));
            this.btn_sorgula.Location = new System.Drawing.Point(670, 241);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(58, 33);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIPARIS TAKIP UYGULAMASI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(406, 307);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(120, 27);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.Location = new System.Drawing.Point(532, 307);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(120, 27);
            this.btn_kayitol.TabIndex = 6;
            this.btn_kayitol.Text = "Kayit Ol";
            this.btn_kayitol.UseVisualStyleBackColor = true;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // Musteri_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 438);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_sorgula);
            this.Controls.Add(this.txt_siparisno);
            this.Controls.Add(this.lbl_takpno);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Takip App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_takpno;
        private System.Windows.Forms.TextBox txt_siparisno;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kayitol;

    }
}

