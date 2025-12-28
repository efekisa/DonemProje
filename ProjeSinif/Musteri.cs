using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urun;

namespace Kisi
{
    
    public class Musteri:Kisiler
    {

        public List<Urunler> sepetim;
        public Musteri() 
        {
            sepetim = new List<Urunler>();
        }
        
    }
}
