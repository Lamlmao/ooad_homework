using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ooad.Models;

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
        base.OnModelCreating(modelBuilder);
    }
}   