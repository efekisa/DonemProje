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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dönem_Projesi
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        { 
        
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiDashboard Anaekran = new YoneticiDashboard();
            Anaekran.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string arananUrun = textBox4.Text.ToLower();

            // Boş hepsini içerdiği için tüm listeyi silmemesi adına
            if (!string.IsNullOrEmpty(arananUrun))
            {
                if (UrunEkle.kalemler.RemoveAll(c => c.UrunKodu.Contains(arananUrun)) > 0)
                {
                    MessageBox.Show("Ürün başarıyla kaldırılmıştır.");
                    this.Close();
                    YoneticiDashboard Anaekran = new YoneticiDashboard();
                    Anaekran.Show();
                }
                else if (UrunEkle.masalar.RemoveAll(c => c.UrunKodu.Contains(arananUrun)) > 0)
                {
                    MessageBox.Show("Ürün başarıyla kaldırılmıştır.");
                    this.Close();
                    YoneticiDashboard Anaekran = new YoneticiDashboard();
                    Anaekran.Show();
                }
                else if (UrunEkle.sandalyeler.RemoveAll(c => c.UrunKodu.Contains(arananUrun)) > 0)
                {
                    MessageBox.Show("Ürün başarıyla kaldırılmıştır.");
                    this.Close();
                    YoneticiDashboard Anaekran = new YoneticiDashboard();
                    Anaekran.Show();
                }
                else if (UrunEkle.kalemlikler.RemoveAll(c => c.UrunKodu.Contains(arananUrun)) > 0)
                {
                    MessageBox.Show("Ürün başarıyla kaldırılmıştır.");
                    this.Close();
                    YoneticiDashboard Anaekran = new YoneticiDashboard();
                    Anaekran.Show();
                }
                else if (UrunEkle.panolar.RemoveAll(c => c.UrunKodu.Contains(arananUrun)) > 0)
                {
                    MessageBox.Show("Ürün başarıyla kaldırılmıştır.");
                    this.Close();
                    YoneticiDashboard Anaekran = new YoneticiDashboard();
                    Anaekran.Show();
                }
                else
                {
                    MessageBox.Show("Ürün kodunu yanlış girdiniz.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen ürün kodu giriniz.");
            }

        }
        public static List<Urun.Kalem> kalemler = new List<Urun.Kalem>();
        public static List<Urun.Masa> masalar = new List<Urun.Masa>();
        public static List<Urun.Sandalye> sandalyeler = new List<Urun.Sandalye>();
        public static List<Urun.Kalemlik> kalemlikler = new List<Urun.Kalemlik>();
        public static List<Urun.Pano> panolar = new List<Urun.Pano>();
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower()== "kalem")
            {
                Kalem kalem = new Kalem();
                kalem.UrunKodu=textBox5.Text.ToLower();
                kalem.Adet=int.Parse(textBox2.Text);
                kalem.Fiyat=int.Parse(textBox3.Text);
                kalemler.Add(kalem);

            }
            else if (textBox1.Text.ToLower() == "masa")
            {
                Masa masa = new Masa();
                masa.UrunKodu = textBox5.Text.ToLower();
                masa.Adet = int.Parse(textBox2.Text);
                masa.Fiyat = int.Parse(textBox3.Text);
                masalar.Add(masa);
            }
            else if (textBox1.Text.ToLower() == "sandalye")
            {
                Sandalye sandalye = new Sandalye();
                sandalye.UrunKodu = textBox5.Text.ToLower();
                sandalye.Adet = int.Parse(textBox2.Text);
                sandalye.Fiyat = int.Parse(textBox3.Text);
                sandalyeler.Add(sandalye);
            }
            else if (textBox1.Text.ToLower() == "kalemlik")
            {
                Kalemlik kalemlik = new Kalemlik();
                kalemlik.UrunKodu = textBox5.Text.ToLower();
                kalemlik.Adet = int.Parse(textBox2.Text);
                kalemlik.Fiyat = int.Parse(textBox3.Text);
                kalemlikler.Add(kalemlik);
            }
            else if (textBox1.Text.ToLower() == "pano")
            {
                Pano pano = new Pano();
                pano.UrunKodu = textBox5.Text.ToLower();
                pano.Adet = int.Parse(textBox2.Text);
                pano.Fiyat = int.Parse(textBox3.Text);
                panolar.Add(pano);
            }
            else
            {
                MessageBox.Show("Eklemeye çalıştığınız ürün, ürün yelpazesinde bulunmamaktadır.");
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
