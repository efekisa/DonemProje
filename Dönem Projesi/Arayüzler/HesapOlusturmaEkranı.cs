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
    public partial class HesapOlusturmaEkranı : Form
    {
        public HesapOlusturmaEkranı()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public static List<Kisi.Musteri> musteriler = new List<Kisi.Musteri>();
        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Isim = textBox1.Text;
            musteri.SoyIsim = textBox6.Text;
            musteri.KullaniciAdi = textBox3.Text;
            if (textBox4.Text== textBox5.Text)
            {
                musteri.Sifre=textBox5.Text;
                musteriler.Add(musteri);
                MessageBox.Show("Hesap Başarıyla Oluşturulmuştur");
                this.Close();
                Form1 Anaekran = new Form1();
                Anaekran.Show();
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar deneyiniz.");
            }

            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Anaekran = new Form1();
            Anaekran.Show();
        }
    }
}
