using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarcodeSales
{
    static class Raporlar
    {
        public static string Baslik { get; set; }
        public static string TarihBaslangic { get; set; }
        public static string TarihBitis { get; set; }
        public static string SatisNakit { get; set; }
        public static string SatisKart { get; set; }
        public static string IadeNakit { get; set; }
        public static string IadeKart { get; set; }
        public static string GiderNakit { get; set; }
        public static string GiderKart { get; set; }
        public static string GelirNakit { get; set; }
        public static string GelirKart { get; set; }
        public static string KartKomisyon { get; set; }
        public static string KdvToplam { get; set; }

        public static void RaporSayfasiRaporu(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<IslemOzet> islemOzetsList = new List<IslemOzet>();
            islemOzetsList.Clear();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                islemOzetsList.Add(new IslemOzet
                {
                    IslemNoId = Convert.ToInt32(dataGridView.Rows[i].Cells["IslemNoId"].Value.ToString()),
                    Iade = Convert.ToBoolean(dataGridView.Rows[i].Cells["Iade"].Value),
                    OdemeSekli = dataGridView.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Nakit = Islemler.DoubleYap(dataGridView.Rows[i].Cells["Nakit"].Value.ToString()),
                    KrediKarti = Islemler.DoubleYap(dataGridView.Rows[i].Cells["KrediKarti"].Value.ToString()),
                    Gelir = Convert.ToBoolean(dataGridView.Rows[i].Cells["Gelir"].Value.ToString()),
                    Gider = Convert.ToBoolean(dataGridView.Rows[i].Cells["Gider"].Value.ToString()),
                    AlisFiyatToplam = Islemler.DoubleYap(dataGridView.Rows[i].Cells["AlisFiyatToplam"].Value.ToString()),
                    Aciklama = dataGridView.Rows[i].Cells["Aciklama"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dataGridView.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici = dataGridView.Rows[i].Cells["Kullanici"].Value.ToString()
                });
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsGenelRapor";
            reportDataSource.Value = islemOzetsList;

            fRaporGoster fRaporGoster = new fRaporGoster();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Clear();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            fRaporGoster.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGenelRapor.rdlc";

            ReportParameter[] parameters = new ReportParameter[13];
            parameters[0] = new ReportParameter("Baslik", Baslik);
            parameters[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            parameters[2] = new ReportParameter("TarihBitis", TarihBitis);
            parameters[3] = new ReportParameter("SatisNakit", SatisNakit);
            parameters[4] = new ReportParameter("SatisKart", SatisKart);
            parameters[5] = new ReportParameter("IadeNakit", IadeNakit);
            parameters[6] = new ReportParameter("IadeKart", IadeKart);
            parameters[7] = new ReportParameter("GiderNakit", GiderNakit);
            parameters[8] = new ReportParameter("GiderKart", GiderKart);
            parameters[9] = new ReportParameter("GelirNakit", GelirNakit);
            parameters[10] = new ReportParameter("GelirKart", GelirKart);
            parameters[11] = new ReportParameter("KartKomisyon", KartKomisyon);
            parameters[12] = new ReportParameter("KdvToplam", KdvToplam);

            fRaporGoster.reportViewer1.LocalReport.SetParameters(parameters);
            fRaporGoster.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            fRaporGoster.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            fRaporGoster.ShowDialog();

            Cursor.Current = Cursors.Default;
        }

        public static void StokRaporu(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<Urun> uruns = new List<Urun>();
            uruns.Clear();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                uruns.Add(new Urun
                {
                    Barkod = dataGridView.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAdi = dataGridView.Rows[i].Cells["UrunAdi"].Value.ToString(),
                    Birim = dataGridView.Rows[i].Cells["Birim"].Value.ToString(),
                    SatisFiyat = Islemler.DoubleYap(dataGridView.Rows[i].Cells["SatisFiyat"].Value.ToString()),
                    Miktar = Islemler.DoubleYap(dataGridView.Rows[i].Cells["Miktar"].Value.ToString()),
                    Tarih = Convert.ToDateTime(dataGridView.Rows[i].Cells["Tarih"].Value.ToString()),
                    //Kullanici = dataGridView.Rows[i].Cells["Kullanici"].Value.ToString()
                });
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsStokUrun";
            reportDataSource.Value = uruns;

            fRaporGoster fRaporGoster = new fRaporGoster();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Clear();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            fRaporGoster.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokUrun.rdlc";

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("Baslik", Baslik);
            parameters[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            parameters[2] = new ReportParameter("TarihBitis", TarihBitis);
            //parameters[3] = new ReportParameter("Kullanici", Kullanici);

            fRaporGoster.reportViewer1.LocalReport.SetParameters(parameters);
            fRaporGoster.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            fRaporGoster.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            fRaporGoster.ShowDialog();

            Cursor.Current = Cursors.Default;
        }

        public static void StokIzlemeRaporu(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<StokHaraket> uruns = new List<StokHaraket>();
            uruns.Clear();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                uruns.Add(new StokHaraket
                {
                    Barkod = dataGridView.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAdi = dataGridView.Rows[i].Cells["UrunAdi"].Value.ToString(),
                    UrunGrup = dataGridView.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dataGridView.Rows[i].Cells["Birim"].Value.ToString(),
                    Miktar = Islemler.DoubleYap(dataGridView.Rows[i].Cells["Miktar"].Value.ToString()),
                    Tarih = Convert.ToDateTime(dataGridView.Rows[i].Cells["Tarih"].Value.ToString()),
                });
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsStokIzleme";
            reportDataSource.Value = uruns;

            fRaporGoster fRaporGoster = new fRaporGoster();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Clear();
            fRaporGoster.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            fRaporGoster.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokIzleme.rdlc";

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("Baslik", Baslik);
            parameters[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            parameters[2] = new ReportParameter("TarihBitis", TarihBitis);

            fRaporGoster.reportViewer1.LocalReport.SetParameters(parameters);
            fRaporGoster.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            fRaporGoster.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            fRaporGoster.ShowDialog();

            Cursor.Current = Cursors.Default;
        }
    }
}