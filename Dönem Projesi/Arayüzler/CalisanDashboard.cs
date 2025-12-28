using Kisi;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CalisanDashboard : Form
    {
        private Calisan aktifKullanici;
        public CalisanDashboard(Calisan calisan)
        {

            InitializeComponent();
            listBox2.Items.Clear();
            int altLimit = 3;

            if (UrunEkle.kalemlikler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Kalemlik "+UrunEkle.kalemlikler.Count);
            }

            if (UrunEkle.panolar.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Pano" + UrunEkle.panolar.Count);
            }

            if (UrunEkle.kalemler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Kalem "+UrunEkle.kalemler.Count);
            }

            if (UrunEkle.masalar.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Masa "+UrunEkle.masalar.Count);
            }

            if (UrunEkle.sandalyeler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Sandalye" +UrunEkle.sandalyeler.Count);
            }

            if (listBox2.Items.Count == 0)
            {
                listBox2.Items.Add("Stoğu azalan ürün bulunmamaktadır.");
            }
            listBox1.Items.Add(HesapOlusturmaEkranı.musteriler.Count);
            this.aktifKullanici = calisan;
            label4.Text = aktifKullanici.Isim + aktifKullanici.SoyIsim;
            int musterisayi = HesapOlusturmaEkranı.musteriler.Count;
            listBox1.Items.Add(musterisayi);
            int kalemsayi = UrunEkle.kalemler.Count;
            int kalemliksayi=UrunEkle.kalemlikler.Count;
            int masasayi=UrunEkle.masalar.Count;
            int panosayi=UrunEkle.panolar.Count;
            int sandalyesayi=UrunEkle.sandalyeler.Count;
            listBox2.Items.Add("Kalan sandalye sayisi" +sandalyesayi+
                "Kalan kalem sayisi"+kalemsayi+
                "Kalan kalemlik sayisi"+ kalemliksayi+
                "Kalan pano sayisi"+ panosayi+
                "Kalan masa sayisi"+ masasayi );

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokDurum yeniEkran = new StokDurum(aktifKullanici);
            yeniEkran.Show();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            KuponTanımla yeniEkran = new KuponTanımla(aktifKullanici);
            yeniEkran.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            IzinTalep yeniEkran = new IzinTalep(aktifKullanici);
            yeniEkran.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Anaekran = new Form1();
            Anaekran.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
