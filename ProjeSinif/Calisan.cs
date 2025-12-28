using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi
{
    public class Calisan:Kisiler
    {
        private static int idSayac = 0;
        public int idno;
        private int izinhakki = 30;
        public int Izinhakki
        {
            get { return izinhakki; }
            set { izinhakki = value; }
        }

        public Calisan()
        {
            idSayac++;
            this.idno = idSayac;
            this.Id = idSayac.ToString();


        }
        public DateTime BaslangicTarih {  get; set; }
        public DateTime AyrilmaTarihi { get; set; }
    }

}
