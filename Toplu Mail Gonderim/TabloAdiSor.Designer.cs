namespace Toplu_Mail_Gonderim
{
    partial class TabloAdiSor
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
            this.tabloAdi_tb = new System.Windows.Forms.TextBox();
            this.tmm_btn = new System.Windows.Forms.Button();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Listenizin Bulunduğu Çalışma \r\nSayfasının Adını Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabloAdi_tb
            // 
            this.tabloAdi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabloAdi_tb.Location = new System.Drawing.Point(35, 52);
            this.tabloAdi_tb.Multiline = true;
            this.tabloAdi_tb.Name = "tabloAdi_tb";
            this.tabloAdi_tb.Size = new System.Drawing.Size(248, 27);
            this.tabloAdi_tb.TabIndex = 1;
            this.tabloAdi_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmm_btn
            // 
            this.tmm_btn.Location = new System.Drawing.Point(73, 85);
            this.tmm_btn.Name = "tmm_btn";
            this.tmm_btn.Size = new System.Drawing.Size(75, 23);
            this.tmm_btn.TabIndex = 2;
            this.tmm_btn.Text = "Tamam";
            this.tmm_btn.UseVisualStyleBackColor = true;
            this.tmm_btn.Click += new System.EventHandler(this.tmm_btn_Click);
            // 
            // iptal_btn
            // 
            this.iptal_btn.Location = new System.Drawing.Point(170, 85);
            this.iptal_btn.Name = "iptal_btn";
            this.iptal_btn.Size = new System.Drawing.Size(75, 23);
            this.iptal_btn.TabIndex = 2;
            this.iptal_btn.Text = "İptal";
            this.iptal_btn.UseVisualStyleBackColor = true;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // TabloAdiSor
            // 
            this.AcceptButton = this.tmm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.iptal_btn;
            this.ClientSize = new System.Drawing.Size(318, 116);
            this.Controls.Add(this.iptal_btn);
            this.Controls.Add(this.tmm_btn);
            this.Controls.Add(this.tabloAdi_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TabloAdiSor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tablo Adı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabloAdi_tb;
        private System.Windows.Forms.Button tmm_btn;
        private System.Windows.Forms.Button iptal_btn;
    }
}