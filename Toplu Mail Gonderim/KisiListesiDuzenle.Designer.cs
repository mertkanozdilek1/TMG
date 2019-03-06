namespace Toplu_Mail_Gonderim
{
    partial class KisiListesiDuzenle
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
            this.mailAdiList_lb = new System.Windows.Forms.ListBox();
            this.guncelle_gb = new System.Windows.Forms.GroupBox();
            this.kisiSil_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.mailList_lb = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.mailAdres_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kisiListesiAdi_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kisiListesiSil_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guncelle_gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mailAdiList_lb
            // 
            this.mailAdiList_lb.FormattingEnabled = true;
            this.mailAdiList_lb.Location = new System.Drawing.Point(8, 17);
            this.mailAdiList_lb.Name = "mailAdiList_lb";
            this.mailAdiList_lb.Size = new System.Drawing.Size(133, 199);
            this.mailAdiList_lb.TabIndex = 0;
            this.mailAdiList_lb.SelectedIndexChanged += new System.EventHandler(this.mailAdiList_lb_SelectedIndexChanged);
            // 
            // guncelle_gb
            // 
            this.guncelle_gb.Controls.Add(this.kisiSil_btn);
            this.guncelle_gb.Controls.Add(this.guncelle_btn);
            this.guncelle_gb.Controls.Add(this.mailList_lb);
            this.guncelle_gb.Controls.Add(this.label5);
            this.guncelle_gb.Controls.Add(this.ekle_btn);
            this.guncelle_gb.Controls.Add(this.mailAdres_tb);
            this.guncelle_gb.Controls.Add(this.label3);
            this.guncelle_gb.Controls.Add(this.kisiListesiAdi_tb);
            this.guncelle_gb.Controls.Add(this.label2);
            this.guncelle_gb.Enabled = false;
            this.guncelle_gb.Location = new System.Drawing.Point(174, 12);
            this.guncelle_gb.Name = "guncelle_gb";
            this.guncelle_gb.Size = new System.Drawing.Size(249, 266);
            this.guncelle_gb.TabIndex = 2;
            this.guncelle_gb.TabStop = false;
            // 
            // kisiSil_btn
            // 
            this.kisiSil_btn.Location = new System.Drawing.Point(163, 161);
            this.kisiSil_btn.Name = "kisiSil_btn";
            this.kisiSil_btn.Size = new System.Drawing.Size(80, 27);
            this.kisiSil_btn.TabIndex = 9;
            this.kisiSil_btn.Text = "Sil";
            this.kisiSil_btn.UseVisualStyleBackColor = true;
            this.kisiSil_btn.Click += new System.EventHandler(this.kisiSil_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Enabled = false;
            this.guncelle_btn.Location = new System.Drawing.Point(6, 228);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(237, 27);
            this.guncelle_btn.TabIndex = 9;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // mailList_lb
            // 
            this.mailList_lb.FormattingEnabled = true;
            this.mailList_lb.Location = new System.Drawing.Point(6, 127);
            this.mailList_lb.Name = "mailList_lb";
            this.mailList_lb.Size = new System.Drawing.Size(151, 95);
            this.mailList_lb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mail Adresi;";
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(185, 74);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(58, 23);
            this.ekle_btn.TabIndex = 6;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // mailAdres_tb
            // 
            this.mailAdres_tb.Location = new System.Drawing.Point(6, 77);
            this.mailAdres_tb.Name = "mailAdres_tb";
            this.mailAdres_tb.Size = new System.Drawing.Size(161, 20);
            this.mailAdres_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kişi Listesi:";
            // 
            // kisiListesiAdi_tb
            // 
            this.kisiListesiAdi_tb.Location = new System.Drawing.Point(6, 32);
            this.kisiListesiAdi_tb.Name = "kisiListesiAdi_tb";
            this.kisiListesiAdi_tb.Size = new System.Drawing.Size(237, 20);
            this.kisiListesiAdi_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kişi Listesi Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kisiListesiSil_btn);
            this.groupBox2.Controls.Add(this.mailAdiList_lb);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Listesi";
            // 
            // kisiListesiSil_btn
            // 
            this.kisiListesiSil_btn.Enabled = false;
            this.kisiListesiSil_btn.Location = new System.Drawing.Point(8, 228);
            this.kisiListesiSil_btn.Name = "kisiListesiSil_btn";
            this.kisiListesiSil_btn.Size = new System.Drawing.Size(133, 27);
            this.kisiListesiSil_btn.TabIndex = 9;
            this.kisiListesiSil_btn.Text = "KİŞİ LİSTESİNİ SİL";
            this.kisiListesiSil_btn.UseVisualStyleBackColor = true;
            this.kisiListesiSil_btn.Click += new System.EventHandler(this.kisiListesiSil_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KisiListesiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(435, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guncelle_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "KisiListesiDuzenle";
            this.Text = "Kişi Listesi Düzenle";
            this.Load += new System.EventHandler(this.KisiListesiDuzenle_Load);
            this.guncelle_gb.ResumeLayout(false);
            this.guncelle_gb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mailAdiList_lb;
        private System.Windows.Forms.GroupBox guncelle_gb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kisiListesiAdi_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.TextBox mailAdres_tb;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.ListBox mailList_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kisiListesiSil_btn;
        private System.Windows.Forms.Button kisiSil_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}