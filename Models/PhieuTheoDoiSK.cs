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
}
