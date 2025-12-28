using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dönem_Projesi
{
    public partial class PersonelSorgula : Form
    {
        public PersonelSorgula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var girisYapanKullanici = PersonelEkle.calisanlar.FirstOrDefault(c => c.Id.ToLower() == textBox6.Text.ToLower());
            if (girisYapanKullanici != null)
            {
                listBox3.Items.Add(girisYapanKullanici.Izinhakki);
                label1.Text = girisYapanKullanici.Isim + "Kişisinin Bilgileri";
            }
            else
            {
                MessageBox.Show("Belirtilen ID ile eşleşen kullanıcı bulunamadı.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiDashboard Anaekran = new YoneticiDashboard();
            Anaekran.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
