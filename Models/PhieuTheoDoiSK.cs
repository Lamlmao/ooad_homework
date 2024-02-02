using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class PhieuTheoDoiSK : EntityBase<int> 
{
    public int MaPTD { get; set; }

    public DateTime NPTD { get; set; }

    public float? TongTienTD { get; set; }

    public string? TTThuoc { get; set; }

    public DateTime? LichTD { get; set; }

    public CuocPT CuocPT {get; set;}
    public int MaCuocPT { get; set;}

    public NhanVien NhanVien { get; set;}
    public int MaNhanVien { get; set;}

    public BenhAn BenhAn { get; set;}
    public int MaBenhAn { get; set;}

    public BenhNhan BenhNhan { get; set;}
    public int MaBenhNhan { get; set;}
}
