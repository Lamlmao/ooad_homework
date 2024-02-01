using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class CuocPT : EntityBase<int> 
{
    [Key]
    public int MaPT { get; set; }

    public string? MaPhPT { get; set; }

    public string? PPPT { get; set; }

    public DateTime? NPT { get; set; }

    public TimeOnly? GPT { get; set; }
}
