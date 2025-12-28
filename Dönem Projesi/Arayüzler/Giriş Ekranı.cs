using Kisi;

namespace Dönem_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            HesapOlusturmaEkranı yeniEkran = new HesapOlusturmaEkranı();
            yeniEkran.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == Yonetici.Bilgiler.Id && textBox2.Text.ToLower() == Yonetici.Bilgiler.Sifre)
            {
                YoneticiDashboard yeniEkran = new YoneticiDashboard();
                yeniEkran.Show();
                this.Hide();
            }
            else if (PersonelEkle.calisanlar.Any(c => c.Isim.ToLower() == textBox1.Text.ToLower() && (c.SoyIsim.ToLower() + c.Id) == textBox2.Text.ToLower()))
            {
                var girisYapanKullanici = PersonelEkle.calisanlar.FirstOrDefault(c => c.Isim.ToLower() == textBox1.Text.ToLower() && (c.SoyIsim.ToLower() + c.Id) == textBox2.Text.ToLower());
                CalisanDashboard yeniEkran = new CalisanDashboard(girisYapanKullanici);
                yeniEkran.Show();
                this.Hide();

            }
            else if (HesapOlusturmaEkranı.musteriler.Any(c => c.KullaniciAdi.ToLower() == textBox1.Text.ToLower() && (c.Sifre == textBox2.Text))) 
            {
                var girisyapanKullanici = HesapOlusturmaEkranı.musteriler.FirstOrDefault(c => c.KullaniciAdi.ToLower() == textBox1.Text.ToLower() && (c.Sifre == textBox2.Text));
                MüşteriEkran yeniEkran = new MüşteriEkran(girisyapanKullanici);
                yeniEkran.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
