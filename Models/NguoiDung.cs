using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class NguoiDung : EntityBase<int> 
{
    public int MaND { get; set; }

    public string HoTen { get; set; }

    public DateTime NSND { get; set; }

    public string SDT { get; set; }

    public string Email { get; set; }

    public string CCCD { get; set; }

    public string DiaChi { get; set; }
}
