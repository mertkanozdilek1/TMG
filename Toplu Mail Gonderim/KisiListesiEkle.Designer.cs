namespace Toplu_Mail_Gonderim
{
    partial class KisiListesiEkle
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
            this.tmm_btn = new System.Windows.Forms.Button();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.mailListesi_lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklemek İstediğiniz Kişi Listesini Seçin";
            // 
            // tmm_btn
            // 
            this.tmm_btn.Location = new System.Drawing.Point(49, 129);
            this.tmm_btn.Name = "tmm_btn";
            this.tmm_btn.Size = new System.Drawing.Size(75, 23);
            this.tmm_btn.TabIndex = 2;
            this.tmm_btn.Text = "Tamam";
            this.tmm_btn.UseVisualStyleBackColor = true;
            this.tmm_btn.Click += new System.EventHandler(this.tmm_btn_Click);
            // 
            // iptal_btn
            // 
            this.iptal_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal_btn.Location = new System.Drawing.Point(146, 129);
            this.iptal_btn.Name = "iptal_btn";
            this.iptal_btn.Size = new System.Drawing.Size(75, 23);
            this.iptal_btn.TabIndex = 2;
            this.iptal_btn.Text = "Iptal";
            this.iptal_btn.UseVisualStyleBackColor = true;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // mailListesi_lb
            // 
            this.mailListesi_lb.FormattingEnabled = true;
            this.mailListesi_lb.Location = new System.Drawing.Point(0, 28);
            this.mailListesi_lb.Name = "mailListesi_lb";
            this.mailListesi_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.mailListesi_lb.Size = new System.Drawing.Size(270, 95);
            this.mailListesi_lb.TabIndex = 3;
            // 
            // KisiListesiEkle
            // 
            this.AcceptButton = this.tmm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.iptal_btn;
            this.ClientSize = new System.Drawing.Size(270, 163);
            this.Controls.Add(this.mailListesi_lb);
            this.Controls.Add(this.iptal_btn);
            this.Controls.Add(this.tmm_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KisiListesiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kişi Listesi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tmm_btn;
        private System.Windows.Forms.Button iptal_btn;
        private System.Windows.Forms.ListBox mailListesi_lb;
    }
}