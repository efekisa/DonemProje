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


            // aktifMusteri'nin sepetindeki her bir ürünü dönüyoruz
            foreach (var urun in aktifMusteri.sepetim)
            {
                // ListBox'a ürün adı ve fiyatını ekle
                listBox1.Items.Add((urun.UrunAdi, +urun.Fiyat, "TL"));

                // Toplam tutara ekle
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
                    // Ürünün tipine göre doğru listeye geri iade ediyoruz
                    if (urun is Urun.Kalemlik)
                        UrunEkle.kalemlikler.Add((Urun.Kalemlik)urun);
                    else if (urun is Urun.Masa)
                        UrunEkle.masalar.Add((Urun.Masa)urun);
                    else if (urun is Urun.Pano)
                        UrunEkle.panolar.Add((Urun.Pano)urun);
                    else if (urun is Urun.Kalem)
                        UrunEkle.kalemler.Add((Urun.Kalem)urun);
                    else if (urun is Urun.Sandalye)
                        UrunEkle.sandalyeler.Add((Urun.Sandalye)urun);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string girilenKod = textBox1.Text;

            var bulunanKupon = Kuponlar.kupon.FirstOrDefault(k => k.KuponKodu == girilenKod);

            if (bulunanKupon != null)
            {
                if (bulunanKupon.KuponMiktarı > 0)
                {
                    int indirimOrani = bulunanKupon.KuponIndirimMiktari;
                    toplamTutar = toplamTutar * indirimOrani / 100;

                    bulunanKupon.KuponMiktarı--;

                    label2.Text = toplamTutar.ToString() + " TL";


                    if (bulunanKupon.KuponMiktarı == 0)
                    {
                        Kuponlar.kupon.Remove(bulunanKupon);
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
    }
}
