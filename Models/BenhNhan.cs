using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class BenhNhan : EntityBase<int> 
{
    public int MaBN { get; set; }

    public string? LichSuKB { get; set; }

    public string? TTYT { get; set; }

    public string? BHYT { get; set; }

    public int MaNguoiDung { get; set;}

    // public NguoiDung NguoiDung { get; set;}

    // public List<PhieuPT> PhieuPTs { get; set;}

    // public List<BenhAn> BenhAns { get; set;}

    // public List<PhieuTheoDoiSK> PhieuTheoDoiSKs { get; set;}

}