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
    public partial class TabloAdiSor : Form
    {
        public string tabloAdi = "";

        public TabloAdiSor()
        { InitializeComponent(); }

        private void tmm_btn_Click(object sender, EventArgs e)
        { tabloAdi = tabloAdi_tb.Text; this.Close(); }

        private void iptal_btn_Click(object sender, EventArgs e)
        { tabloAdi = ""; this.Close(); }
    }
}
