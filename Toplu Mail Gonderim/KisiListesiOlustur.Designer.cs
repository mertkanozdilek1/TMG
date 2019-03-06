namespace Toplu_Mail_Gonderim
{
    partial class KisiListesiOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.kisiListesiAdi_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailList_lb = new System.Windows.Forms.ListBox();
            this.dosyadanEkle_btn = new System.Windows.Forms.Button();
            this.metinDosyasi_rb = new System.Windows.Forms.RadioButton();
            this.excel_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kisiListesiKayit_btn = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.sil_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Listesi Adı:";
            // 
            // kisiListesiAdi_tb
            // 
            this.kisiListesiAdi_tb.Location = new System.Drawing.Point(13, 29);
            this.kisiListesiAdi_tb.Name = "kisiListesiAdi_tb";
            this.kisiListesiAdi_tb.Size = new System.Drawing.Size(204, 20);
            this.kisiListesiAdi_tb.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sil_btn);
            this.groupBox1.Controls.Add(this.mailList_lb);
            this.groupBox1.Location = new System.Drawing.Point(15, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Listesi";
            // 
            // mailList_lb
            // 
            this.mailList_lb.FormattingEnabled = true;
            this.mailList_lb.Location = new System.Drawing.Point(11, 20);
            this.mailList_lb.Name = "mailList_lb";
            this.mailList_lb.Size = new System.Drawing.Size(205, 121);
            this.mailList_lb.TabIndex = 4;
            // 
            // dosyadanEkle_btn
            // 
            this.dosyadanEkle_btn.Location = new System.Drawing.Point(15, 42);
            this.dosyadanEkle_btn.Name = "dosyadanEkle_btn";
            this.dosyadanEkle_btn.Size = new System.Drawing.Size(196, 23);
            this.dosyadanEkle_btn.TabIndex = 0;
            this.dosyadanEkle_btn.Text = "Dosyadan Ekle";
            this.dosyadanEkle_btn.UseVisualStyleBackColor = true;
            this.dosyadanEkle_btn.Click += new System.EventHandler(this.dosyadanEkle_btn_Click);
            // 
            // metinDosyasi_rb
            // 
            this.metinDosyasi_rb.AutoSize = true;
            this.metinDosyasi_rb.Checked = true;
            this.metinDosyasi_rb.Location = new System.Drawing.Point(15, 19);
            this.metinDosyasi_rb.Name = "metinDosyasi_rb";
            this.metinDosyasi_rb.Size = new System.Drawing.Size(91, 17);
            this.metinDosyasi_rb.TabIndex = 1;
            this.metinDosyasi_rb.TabStop = true;
            this.metinDosyasi_rb.Text = "Metin Dosyası";
            this.metinDosyasi_rb.UseVisualStyleBackColor = true;
            // 
            // excel_rb
            // 
            this.excel_rb.AutoSize = true;
            this.excel_rb.Location = new System.Drawing.Point(120, 19);
            this.excel_rb.Name = "excel_rb";
            this.excel_rb.Size = new System.Drawing.Size(91, 17);
            this.excel_rb.TabIndex = 1;
            this.excel_rb.Text = "Excel Dosyası";
            this.excel_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dosyadanEkle_btn);
            this.groupBox2.Controls.Add(this.excel_rb);
            this.groupBox2.Controls.Add(this.metinDosyasi_rb);
            this.groupBox2.Location = new System.Drawing.Point(15, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosyadan Ekle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kisiListesiAdi_tb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // kisiListesiKayit_btn
            // 
            this.kisiListesiKayit_btn.Location = new System.Drawing.Point(15, 347);
            this.kisiListesiKayit_btn.Name = "kisiListesiKayit_btn";
            this.kisiListesiKayit_btn.Size = new System.Drawing.Size(227, 36);
            this.kisiListesiKayit_btn.TabIndex = 5;
            this.kisiListesiKayit_btn.Text = "KİŞİ LİSTESİNİ OLUŞTUR";
            this.kisiListesiKayit_btn.UseVisualStyleBackColor = true;
            this.kisiListesiKayit_btn.Click += new System.EventHandler(this.kisiListesiKayit_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(11, 147);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(205, 23);
            this.sil_btn.TabIndex = 5;
            this.sil_btn.Text = "Seçili Kişiyi Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // KisiListesiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(254, 386);
            this.Controls.Add(this.kisiListesiKayit_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "KisiListesiOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kişi Listesi Oluştur";
            this.Load += new System.EventHandler(this.KisiListesiOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kisiListesiAdi_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton excel_rb;
        private System.Windows.Forms.RadioButton metinDosyasi_rb;
        private System.Windows.Forms.Button dosyadanEkle_btn;
        private System.Windows.Forms.ListBox mailList_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kisiListesiKayit_btn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button sil_btn;
    }
}