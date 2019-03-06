using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Toplu_Mail_Gonderim
{
    class XmlYoneticisi
    {
        XmlDocument m_HesapXml;
        XmlDocument m_KisiListXml;

        #region Yapıcı Metod(lar)
        /// <summary>
        /// 
        /// </summary>
        public XmlYoneticisi()
        {
            m_HesapXml = new XmlDocument();
            m_KisiListXml = new XmlDocument();

            if (!File.Exists("Hesap.xml"))
            {
                XmlProcessingInstruction instructor = m_HesapXml.CreateProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                // Oluşturulan processing instruction XmlDocument nesne örneğine eklenir.
                m_HesapXml.AppendChild((XmlNode)instructor);
                // root element oluşturulur
                XmlNode rootNode = m_HesapXml.CreateNode(XmlNodeType.Element, "Hesaplar", "");
                // root element XmlDocument nesne örneğine eklenir.
                m_HesapXml.AppendChild(rootNode);

                m_HesapXml.Save("Hesap.xml");
                
            }

            if (!File.Exists("KisiListesi.xml"))
            {
                XmlProcessingInstruction instructor = m_KisiListXml.CreateProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                // Oluşturulan processing instruction XmlDocument nesne örneğine eklenir.
                m_KisiListXml.AppendChild((XmlNode)instructor);
                // root element oluşturulur
                XmlNode rootNode = m_KisiListXml.CreateNode(XmlNodeType.Element, "MailList", "");
                // root element XmlDocument nesne örneğine eklenir.
                m_KisiListXml.AppendChild(rootNode);

                m_KisiListXml.Save("KisiListesi.xml");
            }

            m_KisiListXml.Load("KisiListesi.xml");
            m_HesapXml.Load("Hesap.xml");
        }
        #endregion

        #region Genel Metodlar
        /// <summary>
        /// Herhangi bir Hesap boğumu içerisindeki bilgilerini alıp bir Hesap nesne örneğinde birleştirilmesini sağlar
        /// </summary>
        /// <param name="bogum">Bilgileri alınacak olan Hesap boğumu (node)</param>
        /// <returns>Bogumdaki bilgilerden üretilen Hesap nesne örneği</returns>
        private Hesap HesapBilgileriAl(XmlNode bogum)
        {
            int id;
            string hesapAdi = "", mailAdresi = "", mailSifresi = "", mailServer = "";
            int port = 0;
            bool ssl = false;
            // Hesap Ad elementinin içeriği alınır
            hesapAdi = bogum["HesapAdi"].InnerText;
            // Mail Adresi elementinin içeriği alınır
            mailAdresi = bogum["MailAdresi"].InnerText;
            // Mail Sifresi elementinin içeriği alınır
            mailSifresi = bogum["MailSifresi"].InnerText;
            // Mail Server elementinin içeriği alınır
            mailServer = bogum["MailServer"].InnerText;
            // SSL elementinin içeriği alınır
            ssl = Boolean.Parse(bogum["SSL"].InnerText);
            // Port elementinin içeriği alınır
            port = Int32.Parse(bogum["PortNumarasi"].InnerText);

            // Id niteliğinin değeri Attributes özelliğine indeksleyici operatörü uygulanarak alınır
            id = Int32.Parse(bogum.Attributes["Id"].Value);



            // Elde edilen değişken bilgilerinden Kitap nesne örneği üretilir.
            Hesap hsp = new Hesap(id, hesapAdi, mailAdresi, mailSifresi, mailServer, port, ssl);
            // Üretilen nesne örneği geri döndürülür.
            return hsp;
        }

        /// <summary>
        /// Herhangibir KisiListesi boğumu içerisindeki bilgilerini alıp bir KisiListesi nesne örneğinde birleştirilmesini sağlar
        /// </summary>
        /// <param name="bogum">Bilgileri alınacak olan KisiListesi boğumu (node)</param>
        /// <returns>Bogumdaki bilgilerden üretilen KisiListesi nesne örneği</returns>
        private KisiListesi KisiListesiBilgileriAl(XmlNode bogum)
        {
            int id;
            string listeAdi = "";
            string[] mailListesi = null;
            // Ad elementinin içeriği alınır
            listeAdi = bogum["ListeAdi"].InnerText;

            // Id niteliğinin değeri Attributes özelliğine indeksleyici operatörü uygulanarak alınır
            id = Int32.Parse(bogum.Attributes["Id"].Value);

            // Yazarlar elementi içerisindeki tüm Yazar alt elementlerinin değerleri alınır.
            string mailler = "";
            foreach (XmlNode mail in bogum["Mailler"].ChildNodes)
            { mailler += mail.InnerText + "*"; }

            mailListesi = mailler.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            // Elde edilen değişken bilgilerinden Kitap nesne örneği üretilir.
            KisiListesi kisiListesi = new KisiListesi(id, listeAdi, mailListesi);
            // Üretilen nesne örneği geri döndürülür.
            return kisiListesi;
        }

        /// <summary>
        /// XmlDocument nesne örneğinin işaret ettiği xml dokümanındaki Hesap boğumlarını çeker ve her biri için bir Hesap nesne örneği oluşturup, parametre olarak gelen ListBox kontrolüne yükler.
        /// </summary>
        /// <param name="lst">Windows formundaki liste kontrolü</param>
        public void HesaplariCek(ListBox lst)
        {
            // Önce Liste kutusu içeriği temizlenir
            lst.Items.Clear();
            /* GetElementsByTagName metodu parametre olarak aldığı takı adlarını ilgili xml ağacından çeker ve bir XmlNodeList olarak geri döndürür. */
            XmlNodeList hesaplar = m_HesapXml.GetElementsByTagName("Hesap");
            // Elde edilen node listesindeki her bir XmlNode nesne örneği dolaşılır.
            foreach (XmlNode hesapNode in hesaplar)
            {
                lst.Items.Add(HesapBilgileriAl(hesapNode));
            }
        }

        public void HesaplariCek(ComboBox cb)
        {
            // Önce Liste kutusu içeriği temizlenir
            cb.Items.Clear();
            /* GetElementsByTagName metodu parametre olarak aldığı takı adlarını ilgili xml ağacından çeker ve bir XmlNodeList olarak geri döndürür. */
            XmlNodeList hesaplar = m_HesapXml.GetElementsByTagName("Hesap");
            // Elde edilen node listesindeki her bir XmlNode nesne örneği dolaşılır.
            foreach (XmlNode hesapNode in hesaplar)
            {
                cb.Items.Add(HesapBilgileriAl(hesapNode));
            }
        }

        /// <summary>
        /// XmlDocument nesne örneğinin işaret ettiği xml dokümanındaki MailList boğumlarını çeker ve her biri için bir MailList nesne örneği oluşturup, parametre olarak gelen ListBox kontrolüne yükler.
        /// </summary>
        /// <param name="lst">Windows formundaki liste kontrolü</param>
        public void MailListiCek(ListBox lst)
        {
            // Önce Liste kutusu içeriği temizlenir
            lst.Items.Clear();
            /* GetElementsByTagName metodu parametre olarak aldığı takı adlarını ilgili xml ağacından çeker ve bir XmlNodeList olarak geri döndürür. */
            XmlNodeList mailler = m_KisiListXml.GetElementsByTagName("KisiListesi");
            // Elde edilen node listesindeki her bir XmlNode nesne örneği dolaşılır.
            foreach (XmlNode mailNode in mailler)
            {
                lst.Items.Add(KisiListesiBilgileriAl(mailNode));
            }
        }

        public string[] MailListesi(int[] mailListesiId)
        {
            /* GetElementsByTagName metodu parametre olarak aldığı takı adlarını ilgili xml ağacından çeker ve bir XmlNodeList olarak geri döndürür. */
            string mail = "";
            XmlNodeList mailler = m_KisiListXml.GetElementsByTagName("KisiListesi");
            // Elde edilen node listesindeki her bir XmlNode nesne örneği dolaşılır.
            foreach (XmlNode mailNode in mailler)
            {
                KisiListesi kl = KisiListesiBilgileriAl(mailNode);

                for (int i = 0; i < mailListesiId.Length; i++)
                {
                    if (kl.Id == mailListesiId[i])
                    {
                        for (int k = 0; k < kl.MailListesi.Length; k++)
                        { mail += kl.MailListesi[k] + "*"; }
                    }
                }
            }

            return mail.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Güncel xml ağacında bulunulan elementin elde edilmesini sağlar.
        /// </summary>
        /// <param name="id">Konumu tespit edilecek olan Hesap elementinin Id değeri</param>
        /// <returns></returns>
        private XmlNode HesapSecilenNode(int id)
        {
            /* Id değerine ait XmlNode' unu bulabilmek için XPath sorgusundan faydalanılır. Buna göre Kitaplik root elementi içerisindeki Kitap elementlerinden Id niteliğinin değeri parametre olarak gelen değişken değerine eşit olan Kitap elementi bulunur. */
            XmlNode secilenNode = m_HesapXml.SelectSingleNode("/Hesaplar/Hesap[@Id=" + id + "]");
            return secilenNode;
        }

        /// <summary>
        /// Güncel xml ağacında bulunulan elementin elde edilmesini sağlar.
        /// </summary>
        /// <param name="id">Konumu tespit edilecek olan KisiListesinin elementinin Id değeri</param>
        /// <returns></returns>
        private XmlNode KisiListSecilenNode(int id)
        {
            /* Id değerine ait XmlNode' unu bulabilmek için XPath sorgusundan faydalanılır. Buna göre Kitaplik root elementi içerisindeki Kitap elementlerinden Id niteliğinin değeri parametre olarak gelen değişken değerine eşit olan Kitap elementi bulunur. */
            XmlNode secilenNode = m_KisiListXml.SelectSingleNode("/MailList/KisiListesi[@Id=" + id + "]");
            return secilenNode;
        }

        public int HesapEnBuyukId()
        {
            int deger1 = 0;
            XmlNodeList hesaplar = m_HesapXml.GetElementsByTagName("Hesap");

            foreach (XmlNode hesapNode in hesaplar)
            {
                int deger2 = HesapBilgileriAl(hesapNode).Id;
                if (deger2 > deger1)
                    deger1 = deger2;
            }
            return deger1;
        }

        public int KisiListesiEnBuyukId()
        {
            int deger1 = 0;
            XmlNodeList kisiListesi = m_KisiListXml.GetElementsByTagName("KisiListesi");

            foreach (XmlNode kisiNode in kisiListesi)
            {
                int deger2 = KisiListesiBilgileriAl(kisiNode).Id;
                if (deger2 > deger1)
                    deger1 = deger2;
            }
            return deger1;
        }
        #endregion

        #region Temel Veri Değiştirme Metodları
        /// <summary>
        /// Var olan bir boğumun içeriğin günceller
        /// </summary>
        /// <param name="id">Id değeri</param>
        /// <param name="hesapAdi">Hesabın yeni adı</param>
        /// <param name="mailAdresi">Yeni Mail Adresi</param>
        /// <param name="mailSifresi">Yeni Mail Şifresi</param>
        /// <param name="mailServer">Yeni Mail Server</param>
        /// <param name="portNo">Yeni Port No</param>
        /// <param name="ssl">Yeni SSL Durumu</param>
        public void HesapBilgiGuncelle(int id, string hesapAdi, string mailAdresi, string mailSifresi, string mailServer, int portNo, bool ssl)
        {
            // Önce güncelleme yapılacak olan boğum tespit edilir.
            XmlNode bogum = HesapSecilenNode(id);
            // Boğumun elemanlarına yeni değerleri atanır
            bogum["HesapAdi"].InnerText = hesapAdi;
            bogum["MailAdresi"].InnerText = mailAdresi;
            bogum["MailSifresi"].InnerText = mailSifresi;
            bogum["MailServer"].InnerText = mailServer;
            bogum["PortNumarasi"].InnerText = portNo.ToString();
            bogum["SSL"].InnerText = ssl.ToString();

            // ağaç yapısındaki değişiklikleri son hali ile Xml dosyasına kaydediyoruz.
            m_HesapXml.Save("Hesap.xml");
        }

        /// <summary>
        /// Var olan bir boğumun içeriğin günceller
        /// </summary>
        /// <param name="id">Id değeri</param>
        /// <param name="hesapAdi">Kişi Listesi yeni adı</param>
        /// <param name="mailListesi">Yeni Mail Listesi</param>
        public void KisiListesiBilgiGuncelle(int id, string listeAdi, string[] mailListesi)
        {
            // Önce güncelleme yapılacak olan boğum tespit edilir.
            XmlNode bogum = KisiListSecilenNode(id);
            // Boğumun elemanlarına yeni değerleri atanır
            bogum["ListeAdi"].InnerText = listeAdi;

            // Mailler boğumu bir liste kutusundan geldiği için önce xml ağacındaki yazarlar boğumu kaldırılır.
            bogum.RemoveChild(bogum["Mailler"]);
            // Sonra son hali ile mailler boğumu yeniden oluşturulur. 
            XmlNode mailler = m_KisiListXml.CreateNode(XmlNodeType.Element, "Mailler", "");
            // Oluşturulan mailler boğumu tekrardan ağaç yapısı içerisinde o anki Mail boğumuna eklenir.
            bogum.AppendChild(mailler);

            for (int i = 0; i < mailListesi.Length; i++)
            {
                XmlNode mail = m_KisiListXml.CreateNode(XmlNodeType.Element, "Mail", "");
                mail.InnerText = mailListesi[i];
                bogum["Mailler"].AppendChild(mail);
            }

            // ağaç yapısındaki değişiklikleri son hali ile Xml dosyasına kaydediyoruz.
            m_KisiListXml.Save("KisiListesi.xml");
        }

        /// <summary>
        /// Bir Hesağ boğumunun ağaç yapısından silinmesini sağlar
        /// </summary>
        /// <param name="id">Silinecek Hesap' ın Id değeri</param>
        public void HesapSil(int id)
        {
            XmlNode bogum = HesapSecilenNode(id);
            if (bogum != null)
            {
                // Secilen boğumun ağaç yapısından çıkartılmasını sağlamak için RemoveChild metodu kullanılır.
                m_HesapXml.DocumentElement.RemoveChild(bogum);
                // Son değişiklikler için Save metodu çağırılır
                m_HesapXml.Save("Hesap.xml");
            }
        }

        /// <summary>
        /// Bir KisiListesi boğumunun ağaç yapısından silinmesini sağlar
        /// </summary>
        /// <param name="id">Silinecek KisiListesi' nin Id değeri</param>
        public void KisiListesiSil(int id)
        {
            XmlNode bogum = KisiListSecilenNode(id);
            if (bogum != null)
            {
                // Secilen boğumun ağaç yapısından çıkartılmasını sağlamak için RemoveChild metodu kullanılır.
                m_KisiListXml.DocumentElement.RemoveChild(bogum);
                // Son değişiklikler için Save metodu çağırılır
                m_KisiListXml.Save("KisiListesi.xml");
            }
        }

        /// <summary>
        /// Yeni bir Hesap boğumunun xml içeriğine dahil edilmesini sağlar
        /// </summary>
        /// <param name="hesapAdi">Eklenecek hesabin adı</param>
        /// <param name="mailAdresi">Eklenecek hesabın mail adresi</param>
        /// <param name="mailSifresi">Eklenecek hesabın mail şifresi</param>
        /// <param name="mailServer">Eklenecek hesabın smtp server adresi</param>
        /// <param name="portNo">Eklenecek hesabın port numarası</param>
        /// <param name="ssl">Eklenecek hesabın ssl durumu</param>
        /// <returns>Yeni bilgilerden elde edilen Hesap nesne örneği</returns>
        public Hesap HesapEkle(int yeniId, string hesapAdi, string mailAdresi, string mailSifresi, string mailServer, int portNo, bool ssl)
        {
            // Ağaç yapısı içerisinde yeni bir Hesap boğumu oluşturulur
            XmlElement hesap = m_HesapXml.CreateElement("Hesap");

            // Id niteliği oluşturulur
            XmlAttribute id = m_HesapXml.CreateAttribute("Id");
            // Id niteliğinin değeri verilir

            id.Value = yeniId.ToString();
            // Oluşturulan Id niteliği Hesap boğumuna eklenir
            hesap.Attributes.Append(id);

            // Ad boğumu oluşturulur.
            XmlNode ad = m_HesapXml.CreateNode(XmlNodeType.Element, "HesapAdi", "");
            // Ad boğumuna değeri verilir
            ad.InnerText = hesapAdi;
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(ad);

            // Ad boğumu oluşturulur.
            XmlNode mailAdres = m_HesapXml.CreateNode(XmlNodeType.Element, "MailAdresi", "");
            // Ad boğumuna değeri verilir
            mailAdres.InnerText = mailAdresi;
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(mailAdres);

            // Ad boğumu oluşturulur.
            XmlNode mailSifre = m_HesapXml.CreateNode(XmlNodeType.Element, "MailSifresi", "");
            // Ad boğumuna değeri verilir
            mailSifre.InnerText = mailSifresi;
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(mailSifre);

            // Ad boğumu oluşturulur.
            XmlNode smtpServer = m_HesapXml.CreateNode(XmlNodeType.Element, "MailServer", "");
            // Ad boğumuna değeri verilir
            smtpServer.InnerText = mailServer;
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(smtpServer);

            // Ad boğumu oluşturulur.
            XmlNode port = m_HesapXml.CreateNode(XmlNodeType.Element, "PortNumarasi", "");
            // Ad boğumuna değeri verilir
            port.InnerText = portNo.ToString();
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(port);

            // Ad boğumu oluşturulur.
            XmlNode SSL = m_HesapXml.CreateNode(XmlNodeType.Element, "SSL", "");
            // Ad boğumuna değeri verilir
            SSL.InnerText = ssl.ToString();
            // Ad boğumu Hesap boğumu altına eklenir
            hesap.AppendChild(SSL);

            m_HesapXml.DocumentElement.AppendChild((XmlNode)hesap);
            // Xml ağacı Kitaplık.xml dosyasına kaydedilir
            m_HesapXml.Save("Hesap.xml");
            // Gelen bilgilerden elde edilen Kitap nesne örneği geri döndürülür
            return new Hesap(yeniId, hesapAdi, mailAdresi, mailSifresi, mailServer, portNo, ssl);
        }

        /// <summary>
        /// Yeni bir KişiListesi boğumunun xml içeriğine dahil edilmesini sağlar
        /// </summary>
        /// <param name="listeAdi">Eklenecek kişi listesinin adı</param>
        /// <param name="mailListesi">Eklenecek kişilerin mail listesi</param>
        /// <returns>Yeni bilgilerden elde edilen KisiListesi nesne örneği</returns>
        public KisiListesi KisiListesiEkle(int yeniId, string listeAdi, string[] mailListesi)
        {
            // Ağaç yapısı içerisinde yeni bir Hesap boğumu oluşturulur
            XmlElement kisiListesi = m_KisiListXml.CreateElement("KisiListesi");

            // Id niteliği oluşturulur
            XmlAttribute id = m_KisiListXml.CreateAttribute("Id");
            // Id niteliğinin değeri verilir

            id.Value = yeniId.ToString();
            // Oluşturulan Id niteliği Hesap boğumuna eklenir
            kisiListesi.Attributes.Append(id);

            // Ad boğumu oluşturulur.
            XmlNode ad = m_KisiListXml.CreateNode(XmlNodeType.Element, "ListeAdi", "");
            // Ad boğumuna değeri verilir
            ad.InnerText = listeAdi;
            // Ad boğumu Hesap boğumu altına eklenir
            kisiListesi.AppendChild(ad);

            // Mailler boğumu oluşturulur
            XmlNode mailler = m_KisiListXml.CreateNode(XmlNodeType.Element, "Mailler", "");

            for (int i = 0; i < mailListesi.Length; i++)
            {
                // Gelen liste kutusu kontrolündeki her bir mail için Mail boğumu oluşturulur ve Mailler boğumu altına eklenir
                XmlNode yazar = m_KisiListXml.CreateNode(XmlNodeType.Element, "Mail", "");
                yazar.InnerText = mailListesi[i];
                mailler.AppendChild(yazar);
            }
            kisiListesi.AppendChild(mailler);

            m_KisiListXml.DocumentElement.AppendChild((XmlNode)kisiListesi);
            // Xml ağacı Kitaplık.xml dosyasına kaydedilir
            m_KisiListXml.Save("KisiListesi.xml");
            // Gelen bilgilerden elde edilen Kitap nesne örneği geri döndürülür
            return new KisiListesi(yeniId, listeAdi, mailListesi);
        }
        #endregion
    }
}
