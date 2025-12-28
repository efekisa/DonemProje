using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi
{
    public abstract class Kisiler
    {
        public string Isim {  get; set; }
        public string SoyIsim {  get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }

        private string sifre;
        
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public string Id { get; set; }
        
            
        public DateTime DogumTarihi {  get; set; }
        
        
            
    }
}
