using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    public class Kuponlar
    {

        public static List<Kuponlar> kuponlar = new List<Kuponlar>();
        public string KuponKodu;
        public int KuponMiktarı;
        public DateTime KuponBitisTarihi;
        public int KuponIndirimMiktari;
    }
}
