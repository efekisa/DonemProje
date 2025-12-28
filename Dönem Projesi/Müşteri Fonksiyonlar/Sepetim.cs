using Kisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urun;

namespace Dönem_Projesi
{
    public partial class Sepetim : Form
    {

        int toplamTutar = 0;
        private Musteri aktifMusteri;
        public Sepetim(Musteri musteri)
        {
            this.aktifMusteri = musteri;
            InitializeComponent();
        }

        public void Sepetim_Load(object sender, EventArgs e)
        {
            // ListBox'ı temizleyelim (üst üste binmesin)
            listBox1.Items.Clear();


            foreach (var urun in aktifMusteri.sepetim)
            {
                listBox1.Items.Add((urun.UrunAdi +urun.Fiyat +  "TL"));

                toplamTutar += (int)urun.Fiyat;
            }
            label2.Text = ("Toplam" + toplamTutar.ToString() + "TL");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktifMusteri.sepetim.Count > 0)
            {
                foreach (var urun in aktifMusteri.sepetim)
                {
                    // Ürünleri listeye geri koydum
                    if (urun is Urun.Kalemlik)
                        Urunler.kalemlikler.Add((Urun.Kalemlik)urun);
                    else if (urun is Urun.Masa)
                        Urunler.masalar.Add((Urun.Masa)urun);
                    else if (urun is Urun.Pano)
                        Urunler.panolar.Add((Urun.Pano)urun);
                    else if (urun is Urun.Kalem)
                        Urunler.kalemler.Add((Urun.Kalem)urun);
                    else if (urun is Urun.Sandalye)
                        Urunler.sandalyeler.Add((Urun.Sandalye)urun);
                }
                aktifMusteri.sepetim.Clear();

            }
            MüşteriEkran yeniEkran = new MüşteriEkran(aktifMusteri);
            yeniEkran.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın alındı.");
            MüşteriEkran yeniEkran = new MüşteriEkran(aktifMusteri);
            yeniEkran.Show();
            this.Close();
        }
        bool kuponUygulandiMi = false;
        private void button3_Click(object sender, EventArgs e)
        {
            string girilenKod = textBox1.Text.Trim().ToUpper();

            var bulunanKupon = Kuponlar.kuponlar.FirstOrDefault(k =>k.KuponKodu.Trim().Equals(girilenKod, StringComparison.OrdinalIgnoreCase));

            
            if (kuponUygulandiMi) 
            {
                MessageBox.Show("Bu sepette zaten kupon kullanıldı.");
                return;
            }
            if (bulunanKupon != null)
            {
                if (bulunanKupon.KuponMiktarı > 0)
                {
                    kuponUygulandiMi = true;
                    int indirimOrani = bulunanKupon.KuponIndirimMiktari;
                    toplamTutar = toplamTutar - (toplamTutar * indirimOrani / 100);

                    bulunanKupon.KuponMiktarı--;

                    label2.Text = toplamTutar.ToString() + " TL";


                    if (bulunanKupon.KuponMiktarı == 0)
                    {
                        Kuponlar.kuponlar.Remove(bulunanKupon);

                    }
                }
                else
                {
                    MessageBox.Show("Bu kuponun kullanım limiti dolmuştur!");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kupon bulunamadı!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listedeki kupon sayısı: " + Kuponlar.kuponlar.Count);
            foreach (var k in Kuponlar.kuponlar)
            {
                // Kupon kodunu parantez içinde gösteriyoruz ki başında-sonunda boşluk var mı görelim
                MessageBox.Show("Sistemdeki Kod"+k.KuponKodu);
            }
        }
    }
}
