﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarcodeSales
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class BarcodeSalesDbEntities : DbContext
    {
        public BarcodeSalesDbEntities() : base("name=BarcodeSalesDbEntities") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<HizliUrun> HizliUruns { get; set; }
        public virtual DbSet<Islem> Islems { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<Terazi> Terazis { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<IslemOzet> IslemOzets { get; set; }
    }
}