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

namespace Dönem_Projesi
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiDashboard Anaekran = new YoneticiDashboard();
            Anaekran.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiDashboard Anaekran = new YoneticiDashboard();
            Anaekran.Show();

        }
        public static List<Kisi.Calisan> calisanlar = new List<Kisi.Calisan>();
        public static List<Kisi.Calisan> ayrilanlar = new List<Kisi.Calisan>();

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            string[] adsoyad = textBox1.Text.Split(" ");
            calisan.Isim = adsoyad[0];
            if (adsoyad.Length>1)
            {
                calisan.SoyIsim = adsoyad[1];
            }
            else
            {
                MessageBox.Show("Lütfen Soyisim giriniz.");
                return;
            }
            if(DateTime.Parse(textBox5.Text)>DateTime.Parse(textBox2.Text))// Burada başlangıç tarihi ve doğum tarii arasındaki ilişkiyi kontrol ediyorum.
            {
                calisan.BaslangicTarih = DateTime.Parse(textBox5.Text);
                calisan.DogumTarihi = DateTime.Parse(textBox2.Text);
                calisan.BaslangicTarih = DateTime.Parse(textBox5.Text);
                calisan.DogumTarihi = DateTime.Parse(textBox2.Text);
                calisanlar.Add(calisan);

                MessageBox.Show("Personel başarıyla eklenmiştir. Personel ID:" + calisan.Id);

            }
            else
            {
                MessageBox.Show("İşe Başlangıç tarihi doğum tarihinden eski olamaz.");
            }
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {

            string arananKriter = textBox7.Text.ToLower();
            DateTime ayrilmatarihi = DateTime.Parse(textBox8.Text);
            var personel = PersonelEkle.calisanlar.FirstOrDefault(c => c.Id.ToLower() == arananKriter);
            if (ayrilmatarihi < personel.BaslangicTarih)
            {
                MessageBox.Show("İşten ayrılma tarihi başlama tarihinden önce olamaz.");
                return;
            }

            // Boş hepsini içerdiği için tüm listeyi silmemesi adına
            if (!string.IsNullOrEmpty(arananKriter))
            {
                var tasinacaklar = PersonelEkle.calisanlar.Where(c => c.Id.ToLower().Contains(arananKriter)).ToList();
                foreach (var personel1 in tasinacaklar)
                {
                    //tasinacaklar isimli degiskene idsi eşleşenleri atıp, sonra idsi eşleşenleri calisanlar listesinden silip idsi eşleşenleri ayrilan personeller listesine atıyoruz.
                    personel1.AyrilmaTarihi = ayrilmatarihi;

                    ayrilanlar.Add(personel1);
                }
                PersonelEkle.calisanlar.RemoveAll(c => c.Id.ToLower().Contains(arananKriter));
                MessageBox.Show("Personel başarıyla çıkarıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen ID giriniz.");
            }

            
        }
    }
}
