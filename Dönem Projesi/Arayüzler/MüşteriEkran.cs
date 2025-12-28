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
    public partial class MüşteriEkran : Form
    {
        private Musteri aktifmusteri;
        public MüşteriEkran(Musteri musteri)
        {
            InitializeComponent();
            this.aktifmusteri = musteri;
            label2.Text = aktifmusteri.Isim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıUrunler yeniEkran = new KullanıcıUrunler(aktifmusteri);
            this.Hide();
            yeniEkran.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepetim yeniEkran = new Sepetim(aktifmusteri);
            yeniEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 anaEkran = new Form1();
            anaEkran.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MüşteriEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
