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
    public partial class KullanıcıUrunler : Form
    {
        private Musteri aktifMusteri;
        public KullanıcıUrunler(Musteri musteri)
        {
            InitializeComponent();
            this.aktifMusteri = musteri;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Urunler.kalemlikler.Count; 
            numericUpDown2.Maximum = Urunler.panolar.Count; 
            numericUpDown3.Maximum = Urunler.kalemler.Count; 
            numericUpDown4.Maximum = Urunler.masalar.Count;   
            numericUpDown5.Maximum = Urunler.sandalyeler.Count; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int miktarkalemlik = (int)numericUpDown1.Value;

            if (miktarkalemlik > 0 && Urunler.kalemlikler.Count >= miktarkalemlik)
            {
                for (int i = 0; i < miktarkalemlik; i++)
                {
                    var secilenUrun = Urunler.kalemlikler.Last();

                    aktifMusteri.sepetim.Add(secilenUrun);

                    Urunler.kalemlikler.Remove(secilenUrun);
                }

                numericUpDown1.Maximum = Urunler.kalemlikler.Count;
            }
            else if (miktarkalemlik > Urunler.kalemlikler.Count)
            {
                MessageBox.Show("Stokta yeterli kalemlik bulunmamaktadır!");
            }
            int miktarpanolar = (int)numericUpDown2.Value;

            if (miktarpanolar > 0 && Urunler.panolar.Count >= miktarpanolar)
            {
                for (int i = 0; i < miktarpanolar; i++)
                {
                    var secilenUrun2 = Urunler.panolar.Last();

                    aktifMusteri.sepetim.Add(secilenUrun2);

                    Urunler.panolar.Remove(secilenUrun2);
                }

                numericUpDown2.Maximum = Urunler.panolar.Count;
            }
            else if (miktarpanolar > Urunler.panolar.Count)
            {
                MessageBox.Show("Stokta yeterli pano bulunmamaktadır!");
            }
            int miktarkalemler = (int)numericUpDown3.Value;

            if (miktarkalemler > 0 && Urunler.kalemler.Count >= miktarkalemler)
            {
                for (int i = 0; i < miktarkalemler; i++)
                {
                    var secilenUrun3 = Urunler.kalemler.Last();

                    aktifMusteri.sepetim.Add(secilenUrun3);

                    Urunler.kalemler.Remove(secilenUrun3);
                }

                numericUpDown3.Maximum = Urunler.kalemler.Count;
            }
            else if (miktarkalemler > Urunler.kalemler.Count)
            {
                MessageBox.Show("Stokta yeterli kalem bulunmamaktadır!");
            }
            int miktarmasalar = (int)numericUpDown4.Value;

            if (miktarmasalar > 0 && Urunler.masalar.Count >= miktarmasalar)
            {
                for (int i = 0; i < miktarmasalar; i++)
                {
                    var secilenUrun4 = Urunler.masalar.Last();

                    aktifMusteri.sepetim.Add(secilenUrun4);

                    Urunler.masalar.Remove(secilenUrun4);
                }

            }
            else if (miktarmasalar > Urunler.masalar.Count)
            {
                MessageBox.Show("Stokta yeterli masa bulunmamaktadır!");
            }
            int miktarsandalye = (int)numericUpDown5.Value;

            if (miktarsandalye > 0 && Urunler.sandalyeler.Count >= miktarsandalye)
            {
                for (int i = 0; i < miktarsandalye; i++)
                {
                    var secilenUrun5 = Urunler.sandalyeler.Last();

                    aktifMusteri.sepetim.Add(secilenUrun5);

                    Urunler.sandalyeler.Remove(secilenUrun5);
                }

                numericUpDown5.Maximum = Urunler.sandalyeler.Count;
            }
            else if (miktarsandalye > Urunler.sandalyeler.Count)
            {
                MessageBox.Show("Stokta yeterli sandalye bulunmamaktadır!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepetim yeniEkran = new Sepetim(aktifMusteri);
            yeniEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriEkran yeniEkran = new MüşteriEkran(aktifMusteri);
            yeniEkran.Show();
            this.Hide();

        }

        
    }
}
