namespace Toplu_Mail_Gonderim
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapAdi_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gonder_btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dosyaIsim_tb = new System.Windows.Forms.TextBox();
            this.dosyaEkle_btn = new System.Windows.Forms.Button();
            this.bilgi_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.konu_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mesaj_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kisiListesiEkle_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kisiSil_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.mailAdres_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailList_lb = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araclar_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplar_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapTanimla_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mailListesiDuzenle_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mailListesiOlustur_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.durum_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.siteAdres_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapAdi_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gonder_btn);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dosyaIsim_tb);
            this.groupBox1.Controls.Add(this.dosyaEkle_btn);
            this.groupBox1.Controls.Add(this.bilgi_tb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.konu_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mesaj_rtb);
            this.groupBox1.Location = new System.Drawing.Point(294, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // hesapAdi_cb
            // 
            this.hesapAdi_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hesapAdi_cb.FormattingEnabled = true;
            this.hesapAdi_cb.Location = new System.Drawing.Point(163, 19);
            this.hesapAdi_cb.Name = "hesapAdi_cb";
            this.hesapAdi_cb.Size = new System.Drawing.Size(136, 21);
            this.hesapAdi_cb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hesap Adı:";
            // 
            // gonder_btn
            // 
            this.gonder_btn.Location = new System.Drawing.Point(7, 346);
            this.gonder_btn.Name = "gonder_btn";
            this.gonder_btn.Size = new System.Drawing.Size(290, 32);
            this.gonder_btn.TabIndex = 13;
            this.gonder_btn.Text = "Gönder";
            this.gonder_btn.UseVisualStyleBackColor = true;
            this.gonder_btn.Click += new System.EventHandler(this.gonder_btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(7, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 3);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(7, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 3);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dosyaIsim_tb
            // 
            this.dosyaIsim_tb.Location = new System.Drawing.Point(54, 107);
            this.dosyaIsim_tb.Name = "dosyaIsim_tb";
            this.dosyaIsim_tb.Size = new System.Drawing.Size(181, 20);
            this.dosyaIsim_tb.TabIndex = 8;
            // 
            // dosyaEkle_btn
            // 
            this.dosyaEkle_btn.Location = new System.Drawing.Point(241, 105);
            this.dosyaEkle_btn.Name = "dosyaEkle_btn";
            this.dosyaEkle_btn.Size = new System.Drawing.Size(58, 23);
            this.dosyaEkle_btn.TabIndex = 9;
            this.dosyaEkle_btn.Text = "Ekle";
            this.dosyaEkle_btn.UseVisualStyleBackColor = true;
            this.dosyaEkle_btn.Click += new System.EventHandler(this.dosyaEkle_btn_Click);
            // 
            // bilgi_tb
            // 
            this.bilgi_tb.Location = new System.Drawing.Point(54, 81);
            this.bilgi_tb.Name = "bilgi_tb";
            this.bilgi_tb.Size = new System.Drawing.Size(245, 20);
            this.bilgi_tb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dosya:";
            // 
            // konu_tb
            // 
            this.konu_tb.Location = new System.Drawing.Point(54, 55);
            this.konu_tb.Name = "konu_tb";
            this.konu_tb.Size = new System.Drawing.Size(245, 20);
            this.konu_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bilgi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mesaj:";
            // 
            // mesaj_rtb
            // 
            this.mesaj_rtb.Location = new System.Drawing.Point(7, 166);
            this.mesaj_rtb.Name = "mesaj_rtb";
            this.mesaj_rtb.Size = new System.Drawing.Size(290, 174);
            this.mesaj_rtb.TabIndex = 12;
            this.mesaj_rtb.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kisiListesiEkle_btn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.kisiSil_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.temizle_btn);
            this.groupBox2.Controls.Add(this.ekle_btn);
            this.groupBox2.Controls.Add(this.mailAdres_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mailList_lb);
            this.groupBox2.Location = new System.Drawing.Point(11, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderilecekler";
            // 
            // kisiListesiEkle_btn
            // 
            this.kisiListesiEkle_btn.Location = new System.Drawing.Point(6, 65);
            this.kisiListesiEkle_btn.Name = "kisiListesiEkle_btn";
            this.kisiListesiEkle_btn.Size = new System.Drawing.Size(263, 23);
            this.kisiListesiEkle_btn.TabIndex = 3;
            this.kisiListesiEkle_btn.Text = "Kişi Listesi Ekle";
            this.kisiListesiEkle_btn.UseVisualStyleBackColor = true;
            this.kisiListesiEkle_btn.Click += new System.EventHandler(this.kisiListesiEkle_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(7, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 3);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // kisiSil_btn
            // 
            this.kisiSil_btn.Location = new System.Drawing.Point(6, 346);
            this.kisiSil_btn.Name = "kisiSil_btn";
            this.kisiSil_btn.Size = new System.Drawing.Size(263, 32);
            this.kisiSil_btn.TabIndex = 8;
            this.kisiSil_btn.Text = "SEÇİLİ KİŞİYİ SİL";
            this.kisiSil_btn.UseVisualStyleBackColor = true;
            this.kisiSil_btn.Click += new System.EventHandler(this.kisiSil_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mail Adresi;";
            // 
            // temizle_btn
            // 
            this.temizle_btn.Location = new System.Drawing.Point(183, 112);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(86, 23);
            this.temizle_btn.TabIndex = 6;
            this.temizle_btn.Text = "Temizle";
            this.temizle_btn.UseVisualStyleBackColor = true;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(211, 36);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(58, 23);
            this.ekle_btn.TabIndex = 2;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // mailAdres_tb
            // 
            this.mailAdres_tb.Location = new System.Drawing.Point(6, 38);
            this.mailAdres_tb.Name = "mailAdres_tb";
            this.mailAdres_tb.Size = new System.Drawing.Size(176, 20);
            this.mailAdres_tb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gönderilecek Kişiler:";
            // 
            // mailList_lb
            // 
            this.mailList_lb.FormattingEnabled = true;
            this.mailList_lb.Location = new System.Drawing.Point(6, 141);
            this.mailList_lb.Name = "mailList_lb";
            this.mailList_lb.Size = new System.Drawing.Size(263, 199);
            this.mailList_lb.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araclar_tsmi,
            this.hakkinda_tsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araclar_tsmi
            // 
            this.araclar_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesaplar_tsmi,
            this.hesapTanimla_tsmi,
            this.toolStripSeparator1,
            this.mailListesiDuzenle_tsmi,
            this.mailListesiOlustur_tsmi});
            this.araclar_tsmi.Name = "araclar_tsmi";
            this.araclar_tsmi.Size = new System.Drawing.Size(56, 20);
            this.araclar_tsmi.Text = "&Araçlar";
            // 
            // hesaplar_tsmi
            // 
            this.hesaplar_tsmi.Name = "hesaplar_tsmi";
            this.hesaplar_tsmi.Size = new System.Drawing.Size(172, 22);
            this.hesaplar_tsmi.Text = "&Hesaplari Düzenle";
            this.hesaplar_tsmi.Click += new System.EventHandler(this.hesaplar_tsmi_Click);
            // 
            // hesapTanimla_tsmi
            // 
            this.hesapTanimla_tsmi.Name = "hesapTanimla_tsmi";
            this.hesapTanimla_tsmi.Size = new System.Drawing.Size(172, 22);
            this.hesapTanimla_tsmi.Text = "&Hesap Tanımla";
            this.hesapTanimla_tsmi.Click += new System.EventHandler(this.hesapTanimla_tsmi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // mailListesiDuzenle_tsmi
            // 
            this.mailListesiDuzenle_tsmi.Name = "mailListesiDuzenle_tsmi";
            this.mailListesiDuzenle_tsmi.Size = new System.Drawing.Size(172, 22);
            this.mailListesiDuzenle_tsmi.Text = "&Kişi Listesi Düzenle";
            this.mailListesiDuzenle_tsmi.Click += new System.EventHandler(this.mailListesiDuzenle_tsmi_Click);
            // 
            // mailListesiOlustur_tsmi
            // 
            this.mailListesiOlustur_tsmi.Name = "mailListesiOlustur_tsmi";
            this.mailListesiOlustur_tsmi.Size = new System.Drawing.Size(172, 22);
            this.mailListesiOlustur_tsmi.Text = "&Kişi Listesi Oluştur";
            this.mailListesiOlustur_tsmi.Click += new System.EventHandler(this.mailListesiOlustur_tsmi_Click);
            // 
            // hakkinda_tsmi
            // 
            this.hakkinda_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.hakkinda_tsmi.Name = "hakkinda_tsmi";
            this.hakkinda_tsmi.Size = new System.Drawing.Size(69, 20);
            this.hakkinda_tsmi.Text = "&Hakkında";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durum_tssl,
            this.siteAdres_tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // durum_tssl
            // 
            this.durum_tssl.Name = "durum_tssl";
            this.durum_tssl.Size = new System.Drawing.Size(47, 17);
            this.durum_tssl.Text = "Durum:";
            // 
            // siteAdres_tssl
            // 
            this.siteAdres_tssl.Name = "siteAdres_tssl";
            this.siteAdres_tssl.Size = new System.Drawing.Size(93, 17);
            this.siteAdres_tssl.Text = "Mertkan Özdilek";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(610, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Toplu Mail Gönderme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox mesaj_rtb;
        private System.Windows.Forms.TextBox konu_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bilgi_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.TextBox mailAdres_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox mailList_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araclar_tsmi;
        private System.Windows.Forms.ToolStripMenuItem hesaplar_tsmi;
        private System.Windows.Forms.ToolStripMenuItem mailListesiDuzenle_tsmi;
        private System.Windows.Forms.ToolStripMenuItem hesapTanimla_tsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mailListesiOlustur_tsmi;
        private System.Windows.Forms.ToolStripMenuItem hakkinda_tsmi;
        private System.Windows.Forms.TextBox dosyaIsim_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dosyaEkle_btn;
        private System.Windows.Forms.Button kisiListesiEkle_btn;
        private System.Windows.Forms.Button gonder_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel siteAdres_tssl;
        private System.Windows.Forms.ToolStripStatusLabel durum_tssl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ComboBox hesapAdi_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button kisiSil_btn;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

