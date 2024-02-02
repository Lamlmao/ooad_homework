﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ooad.Persistence;

#nullable disable

namespace ooad.Migrations
{
    [DbContext(typeof(BenhVienDbContext))]
    [Migration("20240201150834_init_db")]
    partial class init_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ooad_homework.Models.BacSi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVBS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhoaBS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaCuocPT")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<DateTime>("NCTBS")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NKTBS")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaCuocPT");

                    b.HasIndex("MaNguoiDung")
                        .IsUnique();

                    b.ToTable("BacSis");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhAn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaBA")
                        .HasColumnType("int");

                    b.Property<int>("MaBacSi")
                        .HasColumnType("int");

                    b.Property<int>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int>("MaLoaiBenhAn")
                        .HasColumnType("int");

                    b.Property<string>("TDSK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TTCLS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TTHPT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TTLS")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MaBacSi");

                    b.HasIndex("MaBenhNhan");

                    b.HasIndex("MaLoaiBenhAn");

                    b.ToTable("BenhAns");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhNhan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BHYT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LichSuKB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaBN")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("TTYT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaNguoiDung")
                        .IsUnique();

                    b.ToTable("BenhNhans");
                });

            modelBuilder.Entity("ooad_homework.Models.CuocPT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("GPT")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaPT")
                        .HasColumnType("int");

                    b.Property<string>("MaPhPT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NPT")
                        .HasColumnType("datetime2");

                    b.Property<string>("PPPT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CuocPTs");
                });

            modelBuilder.Entity("ooad_homework.Models.LoaiBenhAn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiBenhAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiBenhAn");
                });

            modelBuilder.Entity("ooad_homework.Models.NguoiDung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.Property<DateTime>("NSND")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("ooad_homework.Models.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNV")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<DateTime>("NCTNV")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NKTNV")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaNguoiDung")
                        .IsUnique();

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ooad_homework.Models.PhieuPT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int>("MaCuocPT")
                        .HasColumnType("int");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<int>("MaPPT")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLP")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.Property<float?>("TongTienH")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MaBenhNhan");

                    b.HasIndex("MaCuocPT");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("PhieuPTs");
                });

            modelBuilder.Entity("ooad_homework.Models.PhieuTheoDoiSK", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("LichTD")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaBenhAn")
                        .HasColumnType("int");

                    b.Property<int>("MaBenhNhan")
                        .HasColumnType("int");

                    b.Property<int>("MaCuocPT")
                        .HasColumnType("int");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<int>("MaPTD")
                        .HasColumnType("int");

                    b.Property<DateTime>("NPTD")
                        .HasColumnType("datetime2");

                    b.Property<string>("TTThuoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("TongTienTD")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MaBenhAn");

                    b.HasIndex("MaBenhNhan");

                    b.HasIndex("MaCuocPT");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("PhieuTheoDoiSKs");
                });

            modelBuilder.Entity("ooad_homework.Models.BacSi", b =>
                {
                    b.HasOne("ooad_homework.Models.CuocPT", "CuocPT")
                        .WithMany("BacSis")
                        .HasForeignKey("MaCuocPT")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.NguoiDung", "NguoiDung")
                        .WithOne("BacSi")
                        .HasForeignKey("ooad_homework.Models.BacSi", "MaNguoiDung")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CuocPT");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhAn", b =>
                {
                    b.HasOne("ooad_homework.Models.BacSi", "BacSi")
                        .WithMany("BenhAns")
                        .HasForeignKey("MaBacSi")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.BenhNhan", "BenhNhan")
                        .WithMany("BenhAns")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.LoaiBenhAn", "LoaiBenhAn")
                        .WithMany("BenhAns")
                        .HasForeignKey("MaLoaiBenhAn")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BacSi");

                    b.Navigation("BenhNhan");

                    b.Navigation("LoaiBenhAn");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhNhan", b =>
                {
                    b.HasOne("ooad_homework.Models.NguoiDung", "NguoiDung")
                        .WithOne("BenhNhan")
                        .HasForeignKey("ooad_homework.Models.BenhNhan", "MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("ooad_homework.Models.NhanVien", b =>
                {
                    b.HasOne("ooad_homework.Models.NguoiDung", "NguoiDung")
                        .WithOne("NhanVien")
                        .HasForeignKey("ooad_homework.Models.NhanVien", "MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("ooad_homework.Models.PhieuPT", b =>
                {
                    b.HasOne("ooad_homework.Models.BenhNhan", "BenhNhan")
                        .WithMany("PhieuPTs")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.CuocPT", "CuocPT")
                        .WithMany("PhieuPTs")
                        .HasForeignKey("MaCuocPT")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuPTs")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BenhNhan");

                    b.Navigation("CuocPT");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ooad_homework.Models.PhieuTheoDoiSK", b =>
                {
                    b.HasOne("ooad_homework.Models.BenhAn", "BenhAn")
                        .WithMany("PhieuTheoDoiSKs")
                        .HasForeignKey("MaBenhAn")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.BenhNhan", "BenhNhan")
                        .WithMany("PhieuTheoDoiSKs")
                        .HasForeignKey("MaBenhNhan")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.CuocPT", "CuocPT")
                        .WithMany("PhieuTheoDoiSKs")
                        .HasForeignKey("MaCuocPT")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ooad_homework.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuTheoDoiSKs")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BenhAn");

                    b.Navigation("BenhNhan");

                    b.Navigation("CuocPT");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ooad_homework.Models.BacSi", b =>
                {
                    b.Navigation("BenhAns");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhAn", b =>
                {
                    b.Navigation("PhieuTheoDoiSKs");
                });

            modelBuilder.Entity("ooad_homework.Models.BenhNhan", b =>
                {
                    b.Navigation("BenhAns");

                    b.Navigation("PhieuPTs");

                    b.Navigation("PhieuTheoDoiSKs");
                });

            modelBuilder.Entity("ooad_homework.Models.CuocPT", b =>
                {
                    b.Navigation("BacSis");

                    b.Navigation("PhieuPTs");

                    b.Navigation("PhieuTheoDoiSKs");
                });

            modelBuilder.Entity("ooad_homework.Models.LoaiBenhAn", b =>
                {
                    b.Navigation("BenhAns");
                });

            modelBuilder.Entity("ooad_homework.Models.NguoiDung", b =>
                {
                    b.Navigation("BacSi")
                        .IsRequired();

                    b.Navigation("BenhNhan")
                        .IsRequired();

                    b.Navigation("NhanVien")
                        .IsRequired();
                });

            modelBuilder.Entity("ooad_homework.Models.NhanVien", b =>
                {
                    b.Navigation("PhieuPTs");

                    b.Navigation("PhieuTheoDoiSKs");
                });
#pragma warning restore 612, 618
        }
    }
}
