﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace De1_NguyenTanSuong_21133078
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WalletDBFirst1Entities : DbContext
    {
        public WalletDBFirst1Entities()
            : base("name=WalletDBFirst1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<LoaiVi> LoaiVis { get; set; }
        public virtual DbSet<Vi> Vis { get; set; }
    }
}
