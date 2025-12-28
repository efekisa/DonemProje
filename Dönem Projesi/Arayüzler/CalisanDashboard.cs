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

            if (Urunler.kalemlikler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Kalemlik "+Urunler.kalemlikler.Count);
            }

            if (Urunler.panolar.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Pano" + Urunler.panolar.Count);
            }

            if (Urunler .kalemler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Kalem "+Urunler.kalemler.Count);
            }

            if (Urunler.masalar.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Masa "+Urunler.masalar.Count);
            }

            if (Urunler.sandalyeler.Count < altLimit)
            {
                listBox2.Items.Add("Kalan Sandalye" +Urunler.sandalyeler.Count);
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
            int kalemsayi = Urunler.kalemler.Count;
            int kalemliksayi=Urunler.kalemlikler.Count;
            int masasayi=Urunler.masalar.Count;
            int panosayi=Urunler.panolar.Count;
            int sandalyesayi=Urunler.sandalyeler.Count;

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
