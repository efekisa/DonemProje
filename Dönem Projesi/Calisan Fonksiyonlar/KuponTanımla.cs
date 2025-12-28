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
            if (int.TryParse(textBox2.Text, out int kodmiktar))
            {
                string hatalar = "";
                kupon.KuponMiktarı = kodmiktar;
                if (!int.TryParse(textBox2.Text, out _))
                    hatalar += "- Miktar sayı olmalı.\n";

                if (!DateTime.TryParse(textBox3.Text, out _))
                    hatalar += "- Tarih formatı hatalı.\n";

                if (hatalar != "")
                {
                    MessageBox.Show("Lütfen şu hataları düzeltin:\n" + hatalar);
                }
                else
                {
                    // Tüm veriler doğru, kayıt işlemini yap
                }
            }
        }
            


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CalisanDashboard Anaekran = new CalisanDashboard(aktifKullanici);
            Anaekran.Show();
        }
    }
}
