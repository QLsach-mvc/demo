﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBooks.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyBanSachEntities2 : DbContext
    {
        public QuanLyBanSachEntities2()
            : base("name=QuanLyBanSachEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<ThamGia> ThamGias { get; set; }
    }
}
