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
    public partial class IzinTalep : Form
    {
        private Calisan aktifKullanici;
        public IzinTalep(Calisan calisan)
        {
            this.aktifKullanici = calisan;

            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(aktifKullanici.Izinhakki);
            if (textBox6.Text != null) 
            {
                if (aktifKullanici.Izinhakki < int.Parse(textBox6.Text))
                {
                    MessageBox.Show("Lütfen izin hakkınız veya izin hakkınızdan daha az miktarda izin talep ediniz.");
                    return;
                }
                else
                {
                    (aktifKullanici.Izinhakki) = aktifKullanici.Izinhakki - (int.Parse(textBox6.Text));
                    MessageBox.Show("Talebiniz başarıyla alınmıştır.");
                    this.Close();
                    CalisanDashboard Anaekran = new CalisanDashboard(aktifKullanici);
                    Anaekran.Show();
                }
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(aktifKullanici.Izinhakki);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
