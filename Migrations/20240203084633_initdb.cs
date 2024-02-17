using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ooad.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacSis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NCTBS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NKTBS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CVBS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoaBS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    MaCuocPT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenhAns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBA = table.Column<int>(type: "int", nullable: false),
                    MaBenhNhan = table.Column<int>(type: "int", nullable: false),
                    MaBacSi = table.Column<int>(type: "int", nullable: false),
                    TTLS = table.Column<double>(type: "float", nullable: true),
                    TTCLS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTHPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TDSK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiBenhAn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhAns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBN = table.Column<int>(type: "int", nullable: false),
                    LichSuKB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTYT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHYT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuocPTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPT = table.Column<int>(type: "int", nullable: false),
                    MaPhPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GPT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuocPTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaND = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSND = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    NCTNV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NKTNV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuPTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPPT = table.Column<int>(type: "int", nullable: false),
                    NgayLP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: true),
                    TongTienH = table.Column<float>(type: "real", nullable: true),
                    MaBenhNhan = table.Column<int>(type: "int", nullable: false),
                    MaCuocPT = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuPTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTheoDoiSKs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPTD = table.Column<int>(type: "int", nullable: false),
                    NPTD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTienTD = table.Column<float>(type: "real", nullable: true),
                    TTThuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LichTD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaCuocPT = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaBenhAn = table.Column<int>(type: "int", nullable: false),
                    MaBenhNhan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTheoDoiSKs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BacSis");

            migrationBuilder.DropTable(
                name: "BenhAns");

            migrationBuilder.DropTable(
                name: "BenhNhans");

            migrationBuilder.DropTable(
                name: "CuocPTs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhieuPTs");

            migrationBuilder.DropTable(
                name: "PhieuTheoDoiSKs");
        }
    }
}
