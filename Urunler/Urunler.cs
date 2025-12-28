namespace Urun
{
    
    public abstract class Urunler
    {
        public static List<Urun.Kalem> kalemler = new List<Urun.Kalem>();
        public static List<Urun.Masa> masalar = new List<Urun.Masa>();
        public static List<Urun.Sandalye> sandalyeler = new List<Urun.Sandalye>();
        public static List<Urun.Kalemlik> kalemlikler = new List<Urun.Kalemlik>();
        public static List<Urun.Pano> panolar = new List<Urun.Pano>();

        private int fiyat;
        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public string UrunKodu { get; set; }

        private int adet;
        public int Adet 
        { 
            get { return adet; } 
            set { adet = value; } 
        }
        public string UrunAdi {  get; set; }

    }
}
