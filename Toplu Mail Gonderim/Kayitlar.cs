using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toplu_Mail_Gonderim
{
    class Hesap
    {
        #region Alanlar(Fields)
        private int m_id;
        private string m_hesapAdi;
        private string m_mailAdresi;
        private string m_mailSifresi;
        private string m_smtpServer;
        private int m_port;
        private bool m_ssl;   
        #endregion

        #region Özellikler(Properties)
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string HesapAdi
        {
            get { return m_hesapAdi; }
            set { m_hesapAdi = value; }
        }
        public string MailAdresi
        {
            get { return m_mailAdresi; }
            set { m_mailAdresi = value; }
        }
        public string MailSifresi
        {
            get { return m_mailSifresi; }
            set { m_mailSifresi = value; }
        }
        public string ServerAdres
        {
            get { return m_smtpServer; }
            set { m_smtpServer = value; }
        }
        public int Port
        {
            get { return m_port; }
            set { m_port = value; }
        }
        public bool SSL
        {
            get { return m_ssl; }
            set { m_ssl = value; }
        }
        #endregion

        public Hesap(int id, string hesapAdi, string mailAdres, string mailSifresi, string mailServer, int port, bool ssl)
        {
            Id = id;
            HesapAdi = hesapAdi;
            MailAdresi = mailAdres;
            MailSifresi = mailSifresi;
            ServerAdres = mailServer;
            Port = port;
            SSL = ssl; 
        }

        public override string ToString()
        {
            return HesapAdi;
        }
    }

    class KisiListesi
    {
        #region Alanlar(Fields)
        private int m_id;
        private string m_kisiListeAdi;
        private string[] m_kisiler;
        #endregion

        #region Özellikler(Properties)
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string KisiListesiAdi
        {
            get { return m_kisiListeAdi; }
            set { m_kisiListeAdi = value; }
        }
        public string[] MailListesi
        {
            get { return m_kisiler; }
            set { m_kisiler = value; }
        }
        #endregion

        public KisiListesi(int id, string kisiListesiAdi, string[] mailListesi)
        {
            Id = id;
            KisiListesiAdi = kisiListesiAdi;
            MailListesi = mailListesi;
        }

        public override string ToString()
        {
            return KisiListesiAdi;
        }
    }
}
