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
    public partial class HesapDuzenle : Form
    {
        XmlYoneticisi xmlYonetici;

        public HesapDuzenle()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
            xmlYonetici.HesaplariCek(hesapListesi_lb);
            if (hesapListesi_lb.Items.Count > 0)
            { sil_btn.Enabled = true; }
        }

        private void Hesaplar_Load(object sender, EventArgs e)
        {

        }

        private void hesapListesi_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hesapListesi_lb.SelectedIndex >= 0)
            {
                Goster((Hesap)hesapListesi_lb.SelectedItem);
                guncelle_gb.Enabled = true;
                guncelle_btn.Enabled = true;
            }
        }

        private void Goster(Hesap hesap)
        {
            mailAdres_tb.Text = hesap.MailAdresi;
            sifre_tb.Text = hesap.MailSifresi;
            portNo_tb.Text = hesap.Port.ToString();
            ssl_cb.Checked = hesap.SSL;
            server_tb.Text = hesap.ServerAdres;
            hesapAdi_tb.Text = hesap.HesapAdi;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (hesapListesi_lb.SelectedIndex >= 0)
            {
                xmlYonetici.HesapSil(((Hesap)hesapListesi_lb.SelectedItem).Id);
                xmlYonetici.HesaplariCek(hesapListesi_lb);

                if (hesapListesi_lb.Items.Count <= 0)
                {
                    guncelle_gb.Enabled = false;
                    guncelle_btn.Enabled = false;
                    sil_btn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Sileceğiniz Hesabı Seçin!", "Mertkan özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Hesabınız Başarıyla Silindi!", "Mertkan özdilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            if (hesapListesi_lb.Items.Count > 0)
            {
                string[] mailList = new string[hesapListesi_lb.Items.Count];
                for (int i = 0; i < hesapListesi_lb.Items.Count; i++)
                { mailList[i] = (string)hesapListesi_lb.Items[i]; }

                xmlYonetici.HesapBilgiGuncelle((
                    (Hesap)hesapListesi_lb.SelectedItem).Id,
                    hesapAdi_tb.Text,
                    mailAdres_tb.Text,
                    sifre_tb.Text,
                    server_tb.Text,
                    int.Parse(portNo_tb.Text),
                    ssl_cb.Checked);

                Temizle();
                xmlYonetici.HesaplariCek(hesapListesi_lb);
            }
            else
            {
                MessageBox.Show("Güncellenecek Kişi Listesi Yok!", "Mertkan özdilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Kişi Listeniz Başarıyla Güncellendi!", "Mertkan özdilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Temizle()
        {
            mailAdres_tb.Clear(); 
            sifre_tb.Clear();
            portNo_tb.Clear();
            ssl_cb.Checked = true;
            server_tb.Clear();
            hesapAdi_tb.Clear();
        }
    }
}