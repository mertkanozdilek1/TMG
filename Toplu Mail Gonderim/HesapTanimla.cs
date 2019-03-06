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
    public partial class HesapTanimla : Form
    {

        XmlYoneticisi xmlYonetici;
        public HesapTanimla()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
        }

        private void hizliAyar_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hizliAyar_cb.SelectedIndex == 1)
            {
                mailServer_tb.Text = "smtp.live.com";
            }
            else if (hizliAyar_cb.SelectedIndex == 3)
            {
                mailServer_tb.Text = "smtp.mail.yahoo.com";
            }
            else if (hizliAyar_cb.SelectedIndex == 2)
            {
                mailServer_tb.Text = "smtp.gmail.com";
            }
            else
            {
                mailServer_tb.Text = "";
            }
        }

        private void hesapEkle_btn_Click(object sender, EventArgs e)
        {
            if (!GirisKontrol())
            { return; }
            else
            {
                xmlYonetici.HesapEkle(xmlYonetici.HesapEnBuyukId() + 1, hesapAdi_tb.Text, mailAdres_tb.Text, mailSifre_tb.Text, mailServer_tb.Text, int.Parse(portNo_tb.Text), ssl_cb.Checked);
                //xmlYnt.Ekle(EnBuyuk() + 1, txtAd.Text, float.Parse(txtFiyat.Text), lstYazarlar, DateTime.Parse(txtBasim.Text));
            }

            MessageBox.Show("Hesap Başarıyla Tanımlandı!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void Temizle()
        {
            mailAdres_tb.Text = "";
            mailServer_tb.Text = "";
            mailSifre_tb.Text = "";
            hesapAdi_tb.Text = "";
            hizliAyar_cb.SelectedIndex = 0;
        }

        private bool GirisKontrol()
        {
            if ((hesapAdi_tb.Text == "") || (mailAdres_tb.Text == "") || (mailSifre_tb.Text == "") || (mailServer_tb.Text == "") || (portNo_tb.Text == ""))
            {
                MessageBox.Show("Eksik Giriş!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int noktaIsaretSiraNo = mailAdres_tb.Text.IndexOf('.');
            int atIsaretSiraNo = mailAdres_tb.Text.IndexOf('@');
            if (((noktaIsaretSiraNo < 0) || (atIsaretSiraNo < 0)) && mailAdres_tb.Text.Length <= 0)
            {
                MessageBox.Show("Geçersiz Mail Adresi!", "Mertkan Özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
