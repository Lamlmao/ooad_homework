using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class BacSi : EntityBase<int>
{
    public DateTime NCTBS { get; set; }

    public DateTime? NKTBS { get; set; }

    public string CVBS { get; set; }

    public string KhoaBS { get; set; }

    public int MaNguoiDung { get; set; }

    public NguoiDung NguoiDung { get; set; }

    public CuocPT CuocPT { get; set; }

    public int MaCuocPT { get; set; }

    public List<BenhAn> BenhAns { get; set; }
}