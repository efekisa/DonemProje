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
    public partial class StokDurum : Form
    {
        private Calisan aktifKullanici;
        public StokDurum(Calisan calisan)
        {
            this.aktifKullanici = calisan;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CalisanDashboard Anaekran = new CalisanDashboard(aktifKullanici);
            Anaekran.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Lütfen ürün seçiniz.");
                return;
            }
            string SecilenSatir = listBox1.SelectedItem.ToString();
            string[] parca = SecilenSatir.Split(" ");
            string urun= parca[0];
            string kod = parca[1];
            if (urun == "Kalem")
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    var tur = UrunEkle.kalemler.FirstOrDefault(k => k.UrunKodu == kod);
                    if (tur != null) { tur.Adet = int.Parse(textBox1.Text); }
                    MessageBox.Show("Stok başarıyla güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün Miktarı 0 dan az olamaz.");
                }
            }
            else if (urun == "Masa")
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    var tur = UrunEkle.masalar.FirstOrDefault(k => k.UrunKodu == kod);
                    if (tur != null) { tur.Adet = int.Parse(textBox1.Text); }
                    MessageBox.Show("Stok başarıyla güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün Miktarı 0 dan az olamaz.");
                }
            }
            else if (urun == "Sandalye")
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    var tur = UrunEkle.sandalyeler.FirstOrDefault(k => k.UrunKodu == kod);
                    if (tur != null) { tur.Adet = int.Parse(textBox1.Text); }
                    MessageBox.Show("Stok başarıyla güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün Miktarı 0 dan az olamaz.");
                }
            }
            else if (urun == "Kalemlik")
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    var tur = UrunEkle.kalemlikler.FirstOrDefault(k => k.UrunKodu == kod);
                    if (tur != null) { tur.Adet = int.Parse(textBox1.Text); }
                    MessageBox.Show("Stok başarıyla güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün Miktarı 0 dan az olamaz.");
                }
            }
            else if (urun == "Pano")
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    var tur = UrunEkle.panolar.FirstOrDefault(k => k.UrunKodu == kod);
                    if (tur != null) { tur.Adet = int.Parse(textBox1.Text); }
                    MessageBox.Show("Stok başarıyla güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün Miktarı 0 dan az olamaz.");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aranan = textBox5.Text.ToLower();
            listBox1.Items.Clear(); 

            var bulunanKalemler = UrunEkle.kalemler.Where(k => k.UrunKodu.ToLower().Contains(aranan)).ToList();
            foreach (var k in bulunanKalemler)
            {
                listBox1.Items.Add($"Kalem {k.UrunKodu} - Stok: {k.Adet}");
            }

            var bulunanMasalar = UrunEkle.masalar.Where(m => m.UrunKodu.ToLower().Contains(aranan)).ToList();
            foreach (var m in bulunanMasalar)
            {
                listBox1.Items.Add($"Masa {m.UrunKodu} - Stok: {m.Adet}");
            }

            var bulunanSandalyeler = UrunEkle.sandalyeler.Where(d => d.UrunKodu.ToLower().Contains(aranan)).ToList();
            foreach (var d in bulunanSandalyeler)
            {
                listBox1.Items.Add($"Sandalye {d.UrunKodu} - Stok: {d.Adet}");
            }

            var bulunanKalemlikler = UrunEkle.kalemlikler.Where(d => d.UrunKodu.ToLower().Contains(aranan)).ToList();
            foreach (var d in bulunanKalemlikler)
            {
                listBox1.Items.Add($"Kalemlik {d.UrunKodu} - Stok: {d.Adet}");
            }

            var bulunanPanolar = UrunEkle.panolar.Where(d => d.UrunKodu.ToLower().Contains(aranan)).ToList();
            foreach (var d in bulunanPanolar)
            {
                listBox1.Items.Add($"Pano {d.UrunKodu} - Stok: {d.Adet}");
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Hiçbir listede uygun ürün bulunamadı.");
            }
        }
    }
}
