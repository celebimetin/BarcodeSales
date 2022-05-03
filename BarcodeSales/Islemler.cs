using System;
using System.Globalization;
using System.Linq;

namespace BarcodeSales
{
    static class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out sonuc);
            return Math.Round(sonuc, 2);
        }

        public static void StokAzalt(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var urunBilgisi = db.Uruns.SingleOrDefault(x => x.Barkod == barkod);
                    urunBilgisi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }

        public static void StokArttir(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var urunBilgisi = db.Uruns.SingleOrDefault(x => x.Barkod == barkod);
                    urunBilgisi.Miktar += miktar;
                    db.SaveChanges();
                }
            }
        }
    }
}