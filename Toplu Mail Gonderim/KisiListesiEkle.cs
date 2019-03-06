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
    public partial class KisiListesiEkle : Form
    {
        XmlYoneticisi xmlYonetici;
        public int[] kisiListesiId;
        public KisiListesiEkle()
        {
            InitializeComponent();
            xmlYonetici = new XmlYoneticisi();
            xmlYonetici.MailListiCek(mailListesi_lb);
            kisiListesiId = null;
        }

        private void tmm_btn_Click(object sender, EventArgs e)
        {
            if (mailListesi_lb.SelectedIndices.Count == 0)
            { this.Close(); }

            kisiListesiId = new int[mailListesi_lb.SelectedIndices.Count];

            for (int i = 0; i < mailListesi_lb.SelectedIndices.Count; i++)
            {
                kisiListesiId[i] = ((KisiListesi)mailListesi_lb.Items[mailListesi_lb.SelectedIndices[i]]).Id;
            }
            this.Close();
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
