using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace Toplu_Mail_Gonderim
{
    public partial class Form1 : Form
    {
        XmlYoneticisi xmlYonetici;
        public Form1()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
            xmlYonetici.HesaplariCek(hesapAdi_cb);
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            int noktaIsaretSiraNo = mailAdres_tb.Text.IndexOf('.');
            int atIsaretSiraNo = mailAdres_tb.Text.IndexOf('@');
            if (((noktaIsaretSiraNo < 0) || (atIsaretSiraNo < 0)) && mailAdres_tb.Text.Length <= 0)
            {
                errorProvider1.SetError(mailAdres_tb, "Geçersiz Mail Adresi");
                return;
            }

            mailList_lb.Items.Add(mailAdres_tb.Text);
            mailAdres_tb.Text = "";
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            mailList_lb.Items.Clear();
        }

        private void hesapTanimla_tsmi_Click(object sender, EventArgs e)
        {
            HesapTanimla frm = new HesapTanimla();
            frm.ShowDialog();
            xmlYonetici.HesaplariCek(hesapAdi_cb);
        }

        private void mailListesiOlustur_tsmi_Click(object sender, EventArgs e)
        {
            KisiListesiOlustur frm = new KisiListesiOlustur();
            frm.ShowDialog();
        }

        private void kisiSil_btn_Click(object sender, EventArgs e)
        {
            mailList_lb.Items.Remove(mailList_lb.SelectedItem);
        }

        private void kisiListesiEkle_btn_Click(object sender, EventArgs e)
        {
            KisiListesiEkle frm = new KisiListesiEkle();
            frm.ShowDialog();
            if (frm.kisiListesiId == null)
            { return; }

            mailList_lb.Items.AddRange(xmlYonetici.MailListesi(frm.kisiListesiId));
        }

        private void mailListesiDuzenle_tsmi_Click(object sender, EventArgs e)
        {
            KisiListesiDuzenle frm = new KisiListesiDuzenle();
            frm.ShowDialog();
        }

        private void hesaplar_tsmi_Click(object sender, EventArgs e)
        {
            HesapDuzenle frm = new HesapDuzenle();
            frm.ShowDialog();
            xmlYonetici.HesaplariCek(hesapAdi_cb);
        }

        private void gonder_btn_Click(object sender, EventArgs e)
        {
            MailMessage MailGonder = new MailMessage();
            MailGonder.From = new MailAddress(((Hesap)hesapAdi_cb.SelectedItem).MailAdresi);

            for (int i = 0; i < mailList_lb.Items.Count; i++)
            {
                MailGonder.To.Add((string)mailList_lb.Items[i]);
            }
            

            MailGonder.Subject = konu_tb.Text;

            Attachment data = new Attachment(openFile.FileName);

            MailGonder.Attachments.Add(data);

            MailGonder.Priority = MailPriority.High;
            MailGonder.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            MailGonder.Body = mesaj_rtb.Text;

            SmtpClient Yolla = new SmtpClient();
            Yolla.SendCompleted += new SendCompletedEventHandler(Yolla_SendCompleted);
            Yolla.Credentials = new System.Net.NetworkCredential(((Hesap)hesapAdi_cb.SelectedItem).MailAdresi, ((Hesap)hesapAdi_cb.SelectedItem).MailSifresi);
            Yolla.Host = ((Hesap)hesapAdi_cb.SelectedItem).ServerAdres;
            Yolla.Timeout = 5000;
            Yolla.DeliveryMethod = SmtpDeliveryMethod.Network;
            Yolla.Port = ((Hesap)hesapAdi_cb.SelectedItem).Port;
            Yolla.EnableSsl = ((Hesap)hesapAdi_cb.SelectedItem).SSL;

            siteAdres_tssl.Text = "Mail Gönderiliyor...";
            siteAdres_tssl.BackColor = Color.Yellow;
            gonder_btn.Enabled = false;
            this.Refresh();
            Yolla.SendAsync(MailGonder, "Mail Gönderiliyor...");
        }

        private void Yolla_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string Durum = (string)e.UserState;

            if (e.Cancelled == true)
            {
                MessageBox.Show("İşlem İptal Edildi", "www.burakozkan.net", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.Error != null)
            {
                siteAdres_tssl.Text = "Hata...";
                siteAdres_tssl.BackColor = Color.Red;
                MessageBox.Show("Hata Durumu = " + e.Error.ToString());
            }
            else
            {
                siteAdres_tssl.Text = "Mail Gönderildi...";
                siteAdres_tssl.BackColor = Color.Green;
                MessageBox.Show("Mail Başarıyla Gönderildi", "www.burakozkan.net", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gonder_btn.Enabled = true;
            }
        }

        private void dosyaEkle_btn_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() != DialogResult.OK)
            { return; }
            dosyaIsim_tb.Text = openFile.SafeFileName;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda frm = new Hakkinda();
            frm.ShowDialog();
        }

    }
}
