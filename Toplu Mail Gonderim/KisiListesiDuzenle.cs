using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toplu_Mail_Gonderim
{
    public partial class KisiListesiDuzenle : Form
    {
        XmlYoneticisi xmlYonetici;

        public KisiListesiDuzenle()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
            xmlYonetici.MailListiCek(mailAdiList_lb);
            if (mailAdiList_lb.Items.Count > 0)
            { kisiListesiSil_btn.Enabled = true; }
        }

        private void KisiListesiDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void mailAdiList_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mailAdiList_lb.SelectedIndex >= 0)
            {
                Goster((KisiListesi)mailAdiList_lb.SelectedItem);
                guncelle_gb.Enabled = true;
                guncelle_btn.Enabled = true;
            }
        }

        private void Goster(KisiListesi kisiListesi)
        {
            if (kisiListesi != null)
            {
                kisiListesiAdi_tb.Text = kisiListesi.KisiListesiAdi;

                mailList_lb.Items.Clear();
                mailList_lb.Items.AddRange(kisiListesi.MailListesi);
            }
            else
            { return; }
        }

        private void kisiSil_btn_Click(object sender, EventArgs e)
        {
            if (mailList_lb.SelectedIndex > 0)
            { mailList_lb.Items.Remove(mailList_lb.SelectedItem); }
            else
            {
                MessageBox.Show("Sileceğiniz Mail Adresini Seçin!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kisiListesiSil_btn_Click(object sender, EventArgs e)
        {
            if (mailAdiList_lb.SelectedIndex >= 0)
            {
                xmlYonetici.KisiListesiSil(((KisiListesi)mailAdiList_lb.SelectedItem).Id);
                xmlYonetici.MailListiCek(mailAdiList_lb);
                Temizle();

                if (mailAdiList_lb.Items.Count == 0)
                {
                    guncelle_btn.Enabled = false;
                    kisiListesiSil_btn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Sileceğiniz Kişi Listesini Seçin!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Kişi Listeniz Başarıyla Silindi!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Temizle()
        {
            mailAdres_tb.Text = "";
            mailList_lb.Items.Clear();
            kisiListesiAdi_tb.Text = "";
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            if (mailAdiList_lb.Items.Count > 0)
            {
                string[] mailList = new string[mailList_lb.Items.Count];
                for (int i = 0; i < mailList_lb.Items.Count; i++)
                { mailList[i] = (string)mailList_lb.Items[i]; }

                xmlYonetici.KisiListesiBilgiGuncelle(((KisiListesi)mailAdiList_lb.SelectedItem).Id, kisiListesiAdi_tb.Text, mailList);
                Temizle();
                xmlYonetici.MailListiCek(mailAdiList_lb);
            }
            else
            {
                MessageBox.Show("Güncellenecek Kişi Listesi Yok!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Kişi Listeniz Başarıyla Güncellendi!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
