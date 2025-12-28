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
    public partial class YoneticiDashboard : Form
    {
        public YoneticiDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle yeniEkran = new UrunEkle();
            yeniEkran.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelEkle yeniEkran = new PersonelEkle();
            yeniEkran.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelSorgula yeniEkran = new PersonelSorgula();
            yeniEkran.Show();
            this.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Anaekran = new Form1();
            Anaekran.Show();

        }

        private void YoneticiDashboard_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(HesapOlusturmaEkranı.musteriler.Count);

            listBox2.Items.Clear();
            listBox2.Items.Add("Kalemler"+Urunler.kalemler.Count);
            listBox2.Items.Add("Panolar" + Urunler.panolar.Count);
            listBox2.Items.Add("Kalemlikler" + Urunler.kalemlikler.Count);
            listBox2.Items.Add("Masalar" + Urunler.masalar.Count);
            listBox2.Items.Add("Sandalyeler" + Urunler.sandalyeler.Count);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
