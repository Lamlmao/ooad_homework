using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class CuocPT : EntityBase<int> 
{
    public int MaPT { get; set; }

    public string? MaPhPT { get; set; }

    public string? PPPT { get; set; }

    public DateTime? NPT { get; set; }

    public DateTime? GPT { get; set; }

    public List<PhieuTheoDoiSK> PhieuTheoDoiSKs { get; set;} 

    public List<PhieuPT> PhieuPTs { get; set;}
    public List<BacSi> BacSis { get; set;}

}
