﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sutcift
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_SUTEntities2 : DbContext
    {
        public DB_SUTEntities2()
            : base("name=DB_SUTEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Çalışanlar> Tb_Çalışanlar { get; set; }
        public virtual DbSet<Tb_Gelirler> Tb_Gelirler { get; set; }
        public virtual DbSet<Tb_Harcamalar> Tb_Harcamalar { get; set; }
        public virtual DbSet<Tb_ırkı> Tb_ırkı { get; set; }
        public virtual DbSet<Tb_inek> Tb_inek { get; set; }
        public virtual DbSet<Tb_Sağlık> Tb_Sağlık { get; set; }
        public virtual DbSet<Tb_Satışı> Tb_Satışı { get; set; }
        public virtual DbSet<Tb_Sut> Tb_Sut { get; set; }
    }
}
