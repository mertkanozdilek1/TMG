namespace Toplu_Mail_Gonderim
{
    partial class HesapDuzenle
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
            this.guncelle_gb = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hesapAdi_tb = new System.Windows.Forms.TextBox();
            this.ssl_cb = new System.Windows.Forms.CheckBox();
            this.portNo_tb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.server_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sifre_tb = new System.Windows.Forms.TextBox();
            this.mailAdres_tb = new System.Windows.Forms.TextBox();
            this.hesapListesi_lb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sil_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.guncelle_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // guncelle_gb
            // 
            this.guncelle_gb.Controls.Add(this.label6);
            this.guncelle_gb.Controls.Add(this.hesapAdi_tb);
            this.guncelle_gb.Controls.Add(this.ssl_cb);
            this.guncelle_gb.Controls.Add(this.portNo_tb);
            this.guncelle_gb.Controls.Add(this.label2);
            this.guncelle_gb.Controls.Add(this.label3);
            this.guncelle_gb.Controls.Add(this.label4);
            this.guncelle_gb.Controls.Add(this.server_tb);
            this.guncelle_gb.Controls.Add(this.label7);
            this.guncelle_gb.Controls.Add(this.sifre_tb);
            this.guncelle_gb.Controls.Add(this.mailAdres_tb);
            this.guncelle_gb.Enabled = false;
            this.guncelle_gb.Location = new System.Drawing.Point(125, 25);
            this.guncelle_gb.Name = "guncelle_gb";
            this.guncelle_gb.Size = new System.Drawing.Size(328, 151);
            this.guncelle_gb.TabIndex = 2;
            this.guncelle_gb.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hesap Adı:";
            // 
            // hesapAdi_tb
            // 
            this.hesapAdi_tb.Location = new System.Drawing.Point(89, 15);
            this.hesapAdi_tb.Name = "hesapAdi_tb";
            this.hesapAdi_tb.Size = new System.Drawing.Size(230, 20);
            this.hesapAdi_tb.TabIndex = 1;
            // 
            // ssl_cb
            // 
            this.ssl_cb.AutoSize = true;
            this.ssl_cb.Location = new System.Drawing.Point(234, 125);
            this.ssl_cb.Name = "ssl_cb";
            this.ssl_cb.Size = new System.Drawing.Size(85, 17);
            this.ssl_cb.TabIndex = 10;
            this.ssl_cb.Text = "Güvenli SSL";
            this.ssl_cb.UseVisualStyleBackColor = true;
            // 
            // portNo_tb
            // 
            this.portNo_tb.Location = new System.Drawing.Point(89, 123);
            this.portNo_tb.Name = "portNo_tb";
            this.portNo_tb.Size = new System.Drawing.Size(100, 20);
            this.portNo_tb.TabIndex = 9;
            this.portNo_tb.Text = "587";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail Adresiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifreniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP Server:";
            // 
            // server_tb
            // 
            this.server_tb.Location = new System.Drawing.Point(89, 95);
            this.server_tb.Name = "server_tb";
            this.server_tb.Size = new System.Drawing.Size(230, 20);
            this.server_tb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Port:";
            // 
            // sifre_tb
            // 
            this.sifre_tb.Location = new System.Drawing.Point(89, 68);
            this.sifre_tb.Name = "sifre_tb";
            this.sifre_tb.Size = new System.Drawing.Size(230, 20);
            this.sifre_tb.TabIndex = 5;
            // 
            // mailAdres_tb
            // 
            this.mailAdres_tb.Location = new System.Drawing.Point(89, 41);
            this.mailAdres_tb.Name = "mailAdres_tb";
            this.mailAdres_tb.Size = new System.Drawing.Size(230, 20);
            this.mailAdres_tb.TabIndex = 3;
            // 
            // hesapListesi_lb
            // 
            this.hesapListesi_lb.FormattingEnabled = true;
            this.hesapListesi_lb.Location = new System.Drawing.Point(0, 30);
            this.hesapListesi_lb.Name = "hesapListesi_lb";
            this.hesapListesi_lb.Size = new System.Drawing.Size(120, 212);
            this.hesapListesi_lb.TabIndex = 1;
            this.hesapListesi_lb.SelectedIndexChanged += new System.EventHandler(this.hesapListesi_lb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesaplar:";
            // 
            // sil_btn
            // 
            this.sil_btn.Enabled = false;
            this.sil_btn.Location = new System.Drawing.Point(148, 197);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(145, 33);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Enabled = false;
            this.guncelle_btn.Location = new System.Drawing.Point(299, 197);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(145, 33);
            this.guncelle_btn.TabIndex = 4;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // HesapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(465, 242);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapListesi_lb);
            this.Controls.Add(this.guncelle_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HesapDuzenle";
            this.Text = "Hesap Düzenle";
            this.Load += new System.EventHandler(this.Hesaplar_Load);
            this.guncelle_gb.ResumeLayout(false);
            this.guncelle_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox guncelle_gb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hesapAdi_tb;
        private System.Windows.Forms.CheckBox ssl_cb;
        private System.Windows.Forms.MaskedTextBox portNo_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sifre_tb;
        private System.Windows.Forms.TextBox mailAdres_tb;
        private System.Windows.Forms.ListBox hesapListesi_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button guncelle_btn;
    }
}