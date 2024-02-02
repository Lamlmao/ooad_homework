using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ooad.Migrations
{
    /// <inheritdoc />
    public partial class init_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "LoaiBenhAn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiBenhAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBenhAn", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_BacSis_CuocPTs_MaCuocPT",
                        column: x => x.MaCuocPT,
                        principalTable: "CuocPTs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BacSis_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_BenhNhans_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_NhanViens_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BenhAns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBA = table.Column<int>(type: "int", nullable: false),
                    TTLS = table.Column<double>(type: "float", nullable: true),
                    TTCLS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTHPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TDSK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiBenhAn = table.Column<int>(type: "int", nullable: false),
                    MaBenhNhan = table.Column<int>(type: "int", nullable: false),
                    MaBacSi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhAns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BenhAns_BacSis_MaBacSi",
                        column: x => x.MaBacSi,
                        principalTable: "BacSis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BenhAns_BenhNhans_MaBenhNhan",
                        column: x => x.MaBenhNhan,
                        principalTable: "BenhNhans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BenhAns_LoaiBenhAn_MaLoaiBenhAn",
                        column: x => x.MaLoaiBenhAn,
                        principalTable: "LoaiBenhAn",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_PhieuPTs_BenhNhans_MaBenhNhan",
                        column: x => x.MaBenhNhan,
                        principalTable: "BenhNhans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuPTs_CuocPTs_MaCuocPT",
                        column: x => x.MaCuocPT,
                        principalTable: "CuocPTs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuPTs_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_PhieuTheoDoiSKs_BenhAns_MaBenhAn",
                        column: x => x.MaBenhAn,
                        principalTable: "BenhAns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuTheoDoiSKs_BenhNhans_MaBenhNhan",
                        column: x => x.MaBenhNhan,
                        principalTable: "BenhNhans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuTheoDoiSKs_CuocPTs_MaCuocPT",
                        column: x => x.MaCuocPT,
                        principalTable: "CuocPTs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuTheoDoiSKs_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BacSis_MaCuocPT",
                table: "BacSis",
                column: "MaCuocPT");

            migrationBuilder.CreateIndex(
                name: "IX_BacSis_MaNguoiDung",
                table: "BacSis",
                column: "MaNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BenhAns_MaBacSi",
                table: "BenhAns",
                column: "MaBacSi");

            migrationBuilder.CreateIndex(
                name: "IX_BenhAns_MaBenhNhan",
                table: "BenhAns",
                column: "MaBenhNhan");

            migrationBuilder.CreateIndex(
                name: "IX_BenhAns_MaLoaiBenhAn",
                table: "BenhAns",
                column: "MaLoaiBenhAn");

            migrationBuilder.CreateIndex(
                name: "IX_BenhNhans_MaNguoiDung",
                table: "BenhNhans",
                column: "MaNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaNguoiDung",
                table: "NhanViens",
                column: "MaNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPTs_MaBenhNhan",
                table: "PhieuPTs",
                column: "MaBenhNhan");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPTs_MaCuocPT",
                table: "PhieuPTs",
                column: "MaCuocPT");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPTs_MaNhanVien",
                table: "PhieuPTs",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTheoDoiSKs_MaBenhAn",
                table: "PhieuTheoDoiSKs",
                column: "MaBenhAn");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTheoDoiSKs_MaBenhNhan",
                table: "PhieuTheoDoiSKs",
                column: "MaBenhNhan");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTheoDoiSKs_MaCuocPT",
                table: "PhieuTheoDoiSKs",
                column: "MaCuocPT");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTheoDoiSKs_MaNhanVien",
                table: "PhieuTheoDoiSKs",
                column: "MaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuPTs");

            migrationBuilder.DropTable(
                name: "PhieuTheoDoiSKs");

            migrationBuilder.DropTable(
                name: "BenhAns");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "BacSis");

            migrationBuilder.DropTable(
                name: "BenhNhans");

            migrationBuilder.DropTable(
                name: "LoaiBenhAn");

            migrationBuilder.DropTable(
                name: "CuocPTs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");
        }
    }
}
