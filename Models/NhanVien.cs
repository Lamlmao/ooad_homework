using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class NhanVien : EntityBase<int> 
{
    public int MaNV { get; set; }

    public DateTime NCTNV { get; set; }

    public DateTime? NKTNV { get; set; }

    public string CV { get; set; }

    public int MaNguoiDung { get; set;}

    // public NguoiDung NguoiDung { get; set;}

    // public List<PhieuPT> PhieuPTs { get; set;}

    // public List<PhieuTheoDoiSK> PhieuTheoDoiSKs { get; set;}


}