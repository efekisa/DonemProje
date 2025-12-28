using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi
{
    public class Yonetici : Kisiler
    {
        private static Yonetici Instance;
        private Yonetici()
        {
            Id = "admin";
            Sifre = "12345";

        }
        public static Yonetici Bilgiler
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Yonetici();
                }
                return Instance;
            }
        }
    }
}
