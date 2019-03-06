namespace Toplu_Mail_Gonderim
{
    partial class HesapTanimla
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mailAdres_tb = new System.Windows.Forms.TextBox();
            this.mailSifre_tb = new System.Windows.Forms.TextBox();
            this.mailServer_tb = new System.Windows.Forms.TextBox();
            this.hesapEkle_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hesapAdi_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hizliAyar_cb = new System.Windows.Forms.ComboBox();
            this.ssl_cb = new System.Windows.Forms.CheckBox();
            this.portNo_tb = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mail Adresiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifreniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SMTP Server:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port:";
            // 
            // mailAdres_tb
            // 
            this.mailAdres_tb.Location = new System.Drawing.Point(89, 64);
            this.mailAdres_tb.Name = "mailAdres_tb";
            this.mailAdres_tb.Size = new System.Drawing.Size(230, 20);
            this.mailAdres_tb.TabIndex = 5;
            // 
            // mailSifre_tb
            // 
            this.mailSifre_tb.Location = new System.Drawing.Point(89, 91);
            this.mailSifre_tb.Name = "mailSifre_tb";
            this.mailSifre_tb.Size = new System.Drawing.Size(230, 20);
            this.mailSifre_tb.TabIndex = 7;
            // 
            // mailServer_tb
            // 
            this.mailServer_tb.Location = new System.Drawing.Point(89, 118);
            this.mailServer_tb.Name = "mailServer_tb";
            this.mailServer_tb.Size = new System.Drawing.Size(230, 20);
            this.mailServer_tb.TabIndex = 9;
            // 
            // hesapEkle_btn
            // 
            this.hesapEkle_btn.Location = new System.Drawing.Point(14, 192);
            this.hesapEkle_btn.Name = "hesapEkle_btn";
            this.hesapEkle_btn.Size = new System.Drawing.Size(328, 29);
            this.hesapEkle_btn.TabIndex = 1;
            this.hesapEkle_btn.Text = "HESAP EKLE";
            this.hesapEkle_btn.UseVisualStyleBackColor = true;
            this.hesapEkle_btn.Click += new System.EventHandler(this.hesapEkle_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hesapAdi_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hizliAyar_cb);
            this.groupBox1.Controls.Add(this.ssl_cb);
            this.groupBox1.Controls.Add(this.portNo_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mailServer_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mailSifre_tb);
            this.groupBox1.Controls.Add(this.mailAdres_tb);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hesap Adı:";
            // 
            // hesapAdi_tb
            // 
            this.hesapAdi_tb.Location = new System.Drawing.Point(89, 38);
            this.hesapAdi_tb.Name = "hesapAdi_tb";
            this.hesapAdi_tb.Size = new System.Drawing.Size(230, 20);
            this.hesapAdi_tb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hızlı Ayar:";
            // 
            // hizliAyar_cb
            // 
            this.hizliAyar_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hizliAyar_cb.FormattingEnabled = true;
            this.hizliAyar_cb.Items.AddRange(new object[] {
            "",
            "Hotmail",
            "Gmail",
            "Yahoo"});
            this.hizliAyar_cb.Location = new System.Drawing.Point(198, 11);
            this.hizliAyar_cb.Name = "hizliAyar_cb";
            this.hizliAyar_cb.Size = new System.Drawing.Size(121, 21);
            this.hizliAyar_cb.TabIndex = 1;
            this.hizliAyar_cb.SelectedIndexChanged += new System.EventHandler(this.hizliAyar_cb_SelectedIndexChanged);
            // 
            // ssl_cb
            // 
            this.ssl_cb.AutoSize = true;
            this.ssl_cb.Checked = true;
            this.ssl_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ssl_cb.Location = new System.Drawing.Point(234, 149);
            this.ssl_cb.Name = "ssl_cb";
            this.ssl_cb.Size = new System.Drawing.Size(85, 17);
            this.ssl_cb.TabIndex = 12;
            this.ssl_cb.Text = "Güvenli SSL";
            this.ssl_cb.UseVisualStyleBackColor = true;
            // 
            // portNo_tb
            // 
            this.portNo_tb.Location = new System.Drawing.Point(89, 146);
            this.portNo_tb.Name = "portNo_tb";
            this.portNo_tb.Size = new System.Drawing.Size(100, 20);
            this.portNo_tb.TabIndex = 11;
            this.portNo_tb.Text = "587";
            // 
            // HesapTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(357, 233);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hesapEkle_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HesapTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hesap Tanımla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailAdres_tb;
        private System.Windows.Forms.TextBox mailSifre_tb;
        private System.Windows.Forms.TextBox mailServer_tb;
        private System.Windows.Forms.Button hesapEkle_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox portNo_tb;
        private System.Windows.Forms.CheckBox ssl_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hizliAyar_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hesapAdi_tb;
    }
}