using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ooad_homework.Models;

namespace ooad.Persistence;

public class BenhVienDbContext : DbContext {

    public DbSet<BacSi> BacSis { get; set;}

    public DbSet<BenhAn> BenhAns { get; set;}

    public DbSet<BenhNhan> BenhNhans { get; set; }

    public DbSet<CuocPT> CuocPTs { get; set; }

    public DbSet<NguoiDung> NguoiDungs { get; set; }

    public DbSet<NhanVien> NhanViens { get ;set; }

    public DbSet<PhieuPT> PhieuPTs { get; set; }

    public DbSet<PhieuTheoDoiSK> PhieuTheoDoiSKs { get; set;}


    public BenhVienDbContext(DbContextOptions<BenhVienDbContext> options) : base(options){
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<BenhNhan>().HasOne(p => p.NguoiDung).WithOne(p => p.BenhNhan).HasForeignKey<BenhNhan>("MaNguoiDung");
        
        // modelBuilder.Entity<NhanVien>().HasOne(p => p.NguoiDung).WithOne(p => p.NhanVien).HasForeignKey<NhanVien>("MaNguoiDung");

        // modelBuilder.Entity<BacSi>().HasOne(p => p.NguoiDung).WithOne(p => p.BacSi).HasForeignKey<BacSi>("MaNguoiDung").OnDelete(DeleteBehavior.NoAction);
        // modelBuilder.Entity<BacSi>().HasOne(p => p.CuocPT).WithMany(p => p.BacSis).HasForeignKey("MaCuocPT").OnDelete(DeleteBehavior.NoAction);

        // modelBuilder.Entity<PhieuPT>().HasOne(p => p.BenhNhan).WithMany(p => p.PhieuPTs).HasForeignKey("MaBenhNhan").OnDelete(DeleteBehavior.NoAction); 
        // modelBuilder.Entity<PhieuPT>().HasOne(p => p.CuocPT).WithMany(p => p.PhieuPTs).HasForeignKey("MaCuocPT").OnDelete(DeleteBehavior.NoAction);
        // modelBuilder.Entity<PhieuPT>().HasOne(p => p.NhanVien).WithMany(p => p.PhieuPTs).HasForeignKey("MaNhanVien").OnDelete(DeleteBehavior.NoAction);

        // modelBuilder.Entity<BenhAn>().HasOne(p => p.LoaiBenhAn).WithMany(p => p.BenhAns).HasForeignKey("MaLoaiBenhAn").OnDelete(DeleteBehavior.NoAction);
        // modelBuilder.Entity<BenhAn>().HasOne(p => p.BacSi).WithMany(p => p.BenhAns).HasForeignKey("MaBacSi").OnDelete(DeleteBehavior.NoAction);;
        // modelBuilder.Entity<BenhAn>().HasOne(p => p.BenhNhan).WithMany(p => p.BenhAns).HasForeignKey("MaBenhNhan").OnDelete(DeleteBehavior.NoAction);; 

        // modelBuilder.Entity<PhieuTheoDoiSK>().HasOne(p => p.CuocPT).WithMany(p => p.PhieuTheoDoiSKs).HasForeignKey("MaCuocPT").OnDelete(DeleteBehavior.NoAction);;
        // modelBuilder.Entity<PhieuTheoDoiSK>().HasOne(p => p.BenhAn).WithMany(p => p.PhieuTheoDoiSKs).HasForeignKey("MaBenhAn").OnDelete(DeleteBehavior.NoAction);;
        // modelBuilder.Entity<PhieuTheoDoiSK>().HasOne(p => p.NhanVien).WithMany(p => p.PhieuTheoDoiSKs).HasForeignKey("MaNhanVien").OnDelete(DeleteBehavior.NoAction);;
        // modelBuilder.Entity<PhieuTheoDoiSK>().HasOne(p => p.BenhNhan).WithMany(p => p.PhieuTheoDoiSKs).HasForeignKey("MaBenhNhan").OnDelete(DeleteBehavior.NoAction);;

        base.OnModelCreating(modelBuilder);
    }
}