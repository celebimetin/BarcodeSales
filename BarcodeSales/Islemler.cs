using System;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        public static void DataGridViewDüzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].HeaderText = "#";
                            break;
                        //Ürün Tablosu
                        case "UrunId":
                            dgv.Columns[i].HeaderText = "Ürün Numarası";
                            break;
                        case "IslemNo":
                            dgv.Columns[i].HeaderText = "İşlem Numarası";
                            break;
                        case "UrunAdi":
                            dgv.Columns[i].HeaderText = "Ürün Adı";
                            break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu";
                            break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "Kdv Oranı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "Kdv Tutarı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Birim":
                            dgv.Columns[i].HeaderText = "Birim";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Miktar":
                            dgv.Columns[i].HeaderText = "Miktar";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Toplam":
                            dgv.Columns[i].HeaderText = "Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            break;
                        //Ürün Tablosu end.

                        //İşlem Özeti tablosu
                        case "Gelir":
                            dgv.Columns[i].HeaderText = "Gelir";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Gider":
                            dgv.Columns[i].HeaderText = "Gider";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Nakit":
                            dgv.Columns[i].HeaderText = "Nakit";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "KrediKarti":
                            dgv.Columns[i].HeaderText = "Kredi Kartı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "AlisFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                            //İşlem Özeti tablosu end.
                    }
                }
            }
        }

        public static void StokHaraketGiris(string barkod, string urunAdi, string birim, double miktar, string urunGrup, string kullanici)
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                StokHaraket stokHaraket = new StokHaraket();
                stokHaraket.Barkod = barkod;
                stokHaraket.UrunAdi = urunAdi;
                stokHaraket.Birim = birim;
                stokHaraket.Miktar = miktar;
                stokHaraket.UrunGrup = urunGrup;
                stokHaraket.Kullanici = kullanici;
                stokHaraket.Tarih = DateTime.Now;

                db.StokHarakets.Add(stokHaraket);
                db.SaveChanges();
            }
        }

        public static int KartKomisyon()
        {
            int? sonuc = 0;
            using (var db = new BarcodeSalesDbEntities())
            {
                if (db.Sabits.Any())
                {
                    sonuc = db.Sabits.First().KartKomisyon;
                }
                else
                {
                    sonuc = 0;
                }
            }
            return Convert.ToInt16(sonuc);
        }

        public static void SabitVarsayilan()
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                if (!db.Sabits.Any())
                {
                    Sabit sabit = new Sabit();
                    sabit.AdSoyad = "Admin";
                    sabit.Unvan = "Unvan";
                    sabit.Adres = "Adres";
                    sabit.KartKomisyon = 0;
                    sabit.Yazici = false;

                    db.Sabits.Add(sabit);
                    db.SaveChanges();
                }
            }
        }

        public static void Backup()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Veri yedek dosyası|0.bak";
            saveFile.FileName = "Barkodlu_Satis_Programi_" + DateTime.Now.ToShortDateString();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(saveFile.FileName))
                    {
                        File.Delete(saveFile.FileName);
                    }
                    var dbHedef = saveFile.FileName;
                    string dbKaynak = Application.LocalUserAppDataPath;
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "] TO DISK='" + dbHedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedek alınmıştır.");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}