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
    public partial class KuponTanımla : Form
    {
        private Calisan aktifKullanici;
        public KuponTanımla(Calisan calisan)

        {
            this.aktifKullanici = calisan;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Kuponlar kupon = new Kuponlar();
            if (int.TryParse(textBox2.Text, out int miktar))
            {
                kupon.KuponMiktarı = miktar;
            }
            else    
            {     
                MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
                return;
            }
            if (DateTime.TryParse(textBox3.Text, out DateTime sure))
            {
                kupon.KuponBitisTarihi = sure;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tarih giriniz.");
                return;
            }
            if (int.TryParse(textBox5.Text, out int oran))
                if (oran >= 0 && oran <= 100) 
                {
                    kupon.KuponIndirimMiktari = oran;
                    kupon.KuponKodu = textBox1.Text;
                    Kuponlar.kuponlar.Add(kupon);
                }
                else
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında bir sayı giriniz.");
                    return;
                }
                else
                { 
                    MessageBox.Show("Lütfen bir indirim oranı giriniz.");
                    return;
                }
        }
                
                
        


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CalisanDashboard Anaekran = new CalisanDashboard(aktifKullanici);
            Anaekran.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
