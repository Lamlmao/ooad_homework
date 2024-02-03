using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class PhieuPT : EntityBase<int>
{
    public int MaPPT { get; set; }

    public DateTime NgayLP { get; set; }

    public float? TongTien { get; set; }

    public float? TongTienH { get; set; }

    public int MaBenhNhan { get; set; }

    public int MaCuocPT { get; set; }

    public int MaNhanVien { get; set; }
    
    public BenhNhan BenhNhan { get; set; }

    public CuocPT CuocPT { get; set; }

    public NhanVien NhanVien { get; set; }
}