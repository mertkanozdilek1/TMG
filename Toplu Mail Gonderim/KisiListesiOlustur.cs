using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Toplu_Mail_Gonderim
{
    public partial class KisiListesiOlustur : Form
    {
        private XmlYoneticisi xmlYonetici;

        public KisiListesiOlustur()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
        }

        private void dosyadanEkle_btn_Click(object sender, EventArgs e)
        {
            if (metinDosyasi_rb.Checked)
            {
                //MessageBox.Show("Metin Dosyasının Doğru Formatta Olduğuna Emin Olunuz!\r\nÖrnek Metin Dosyası İçin Yardım Menüsüne Bakın", "www.burakozkan.net", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openFile.Filter = "TXT Dosyaları(*.TXT)|*.TXT|RTF Dosyları(*.RTF)|*.RTF";
                openFile.FilterIndex = 0;
                if (openFile.ShowDialog() != DialogResult.OK)
                { return; }

                FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string[] mailAdres = sr.ReadToEnd().Split(new char[] { ';', ' ', '\r', '\n' });
                foreach (string adres in mailAdres)
                {
                    if (mailAdresKontrol(adres))
                    {
                        mailList_lb.Items.Add(adres);
                    }
                }
            }
            else
            {
                openFile.Filter = "XLS Dosyaları(*.XLS)|*.XLS";
                openFile.FilterIndex = 0;
                if (openFile.ShowDialog() != DialogResult.OK)
                { return; }

                TabloAdiSor frm = new TabloAdiSor();
                frm.ShowDialog();
                if (frm.tabloAdi == "")
                { return; }


                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + openFile.FileName + ";Extended Properties=Excel 8.0;");
                baglanti.Open();
                string sorgu = "SELECT * FROM [" + frm.tabloAdi + "$]";
                OleDbDataAdapter data_adp = new OleDbDataAdapter(sorgu, baglanti);
                DataTable mailTablo = new DataTable();
                data_adp.Fill(mailTablo);

                //mailTablo.Columns
                int test = mailTablo.Columns[1].MaxLength;

                foreach (DataRow row in mailTablo.Rows)
                {
                    foreach (DataColumn column in mailTablo.Columns)
                    {
                        if (row[column] != System.DBNull.Value)
                        {
                            if (mailAdresKontrol((string)row[column]))
                            {
                                mailList_lb.Items.Add((string)row[column]);
                            }
                        }
                    }
                }

                baglanti.Close();
            }
        }

        private bool mailAdresKontrol(string adres)
        {
            int noktaIsaretSiraNo = adres.IndexOf('.');
            int atIsaretSiraNo = adres.IndexOf('@');
            if (((noktaIsaretSiraNo < 0) || (atIsaretSiraNo < 0)) && adres.Length <= 0)
            { return false; }

            return true;
        }

        private void KisiListesiOlustur_Load(object sender, EventArgs e)
        {
            //openFile.Filter = "TXT Dosyaları(*.TXT)|*.TXT|RTF Dosyları(*.RTF)|*.RTF";
            //openFile.Filter = "XLS Dosyaları(*.XLS)|*.XLS";
            //openFile.FilterIndex = 0;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            mailList_lb.Items.Remove(mailList_lb.SelectedItem);
        }

        private void kisiListesiKayit_btn_Click(object sender, EventArgs e)
        {
            if (!GirisKontrol())
            { return; }
            else
            {
                string[] mailList = new string[mailList_lb.Items.Count];
                for (int i = 0; i < mailList_lb.Items.Count; i++)
                { mailList[i] = (string)mailList_lb.Items[i]; }

                xmlYonetici.KisiListesiEkle(xmlYonetici.KisiListesiEnBuyukId() + 1, kisiListesiAdi_tb.Text, mailList);
            }

            MessageBox.Show("Kişi Listesi Başarıyla Oluşturuldu!", "Mertkan Ödilek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void Temizle()
        {
            mailList_lb.Items.Clear();
            kisiListesiAdi_tb.Text = "";

        }

        private bool GirisKontrol()
        {
            if (kisiListesiAdi_tb.Text == "")
            {
                MessageBox.Show("Lütfen Kişi Listesi Adını Giriniz!", "Mertkan Ödilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(mailList_lb.Items.Count <= 0)
            {
                MessageBox.Show("Lütfen En Az Bir Mail Adresi Giriniz!", "Mertkan Ödilek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
