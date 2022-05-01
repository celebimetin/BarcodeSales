using System.Globalization;

namespace BarcodeSales
{
    static class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out sonuc);
            return sonuc;
        }
    }
}