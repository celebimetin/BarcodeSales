using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

namespace BarcodeSales
{
    public class Yazdir
    {
        public int? IslemNo { get; set; }
        PrintDocument printDocument = new PrintDocument();

        public Yazdir(int? islemNo)
        {
            IslemNo = islemNo;
        }

        public void Yazdirmaİslemi()
        {
            try
            {
                printDocument.PrintPage += PrintDocument_PrintPage;
                printDocument.Print();
            }
            catch
            {
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                var isyeri = db.Sabits.FirstOrDefault();
                var satisListe = db.Satis.Where(x => x.IslemNoId == IslemNo).ToList();
                if (isyeri != null && satisListe != null)
                {
                    Font fontBuyuk = new Font("Calibri", 10, FontStyle.Bold);
                    Font fontSabit = new Font("Calibri", 8, FontStyle.Bold);
                    Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);
                    StringFormat stringFormat = new StringFormat(StringFormatFlags.FitBlackBox);
                    stringFormat.Alignment = StringAlignment.Center;
                    RectangleF rectangleF = new RectangleF(0, 20, 220, 20);

                    e.Graphics.DrawString(isyeri.Unvan, fontBuyuk, Brushes.Black, rectangleF, stringFormat);
                    e.Graphics.DrawString("İşlem No : " + IslemNo.ToString(), fontSabit, Brushes.Black, new Point(5, 45));
                    e.Graphics.DrawString("Tarih : " + DateTime.Now, fontSabit, Brushes.Black, new Point(5, 60));
                    e.Graphics.DrawString("----------------------------------------", fontSabit, Brushes.Black, new Point(5, 75));

                    e.Graphics.DrawString("Ürün Adı", fontIcerikBaslik, Brushes.Black, new Point(5, 90));
                    e.Graphics.DrawString("Miktar", fontIcerikBaslik, Brushes.Black, new Point(100, 90));
                    e.Graphics.DrawString("Fiyat", fontIcerikBaslik, Brushes.Black, new Point(150, 90));
                    e.Graphics.DrawString("Tutar", fontIcerikBaslik, Brushes.Black, new Point(200, 90));

                    int yukseklik = 120;
                    double genelToplam = 0;
                    foreach (var item in satisListe)
                    {
                        e.Graphics.DrawString(item.UrunAdi, fontSabit, Brushes.Black, new Point(5, yukseklik));
                        e.Graphics.DrawString(item.Miktar.ToString(), fontSabit, Brushes.Black, new Point(100, yukseklik));
                        e.Graphics.DrawString(Convert.ToDouble(item.SatisFiyat).ToString("C2"), fontSabit, Brushes.Black, new Point(150, yukseklik));
                        e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString("C2"), fontSabit, Brushes.Black, new Point(200, yukseklik));

                        yukseklik += 15;
                        genelToplam += Convert.ToDouble(item.Toplam);
                    }
                    e.Graphics.DrawString("----------------------------------------", fontSabit, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString("Toplam : " + genelToplam.ToString("C2"), fontBuyuk, Brushes.Black, new Point(5, yukseklik + 20));
                    e.Graphics.DrawString("----------------------------------------", fontSabit, Brushes.Black, new Point(5, yukseklik + 40));
                    e.Graphics.DrawString("***** Mali Değeri Yoktur *****", fontSabit, Brushes.Black, new Point(5, yukseklik + 60));

                    PaperSize paperSize = new PaperSize("58mm Termal", 220, yukseklik + 80);
                    printDocument.DefaultPageSettings.PaperSize = paperSize;
                }
            }
        }
    }
}