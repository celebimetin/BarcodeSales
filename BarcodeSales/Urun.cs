//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarcodeSales
{
    using System;
    
    public partial class Urun
    {
        public int UrunId { get; set; }
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public string UrunGrup { get; set; }
        public Nullable<double> AlisFiyat { get; set; }
        public Nullable<double> SatisFiyat { get; set; }
        public Nullable<int> KdvOrani { get; set; }
        public Nullable<double> KdvTutari { get; set; }
        public string Birim { get; set; }
        public Nullable<double> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}