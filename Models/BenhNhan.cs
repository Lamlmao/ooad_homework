using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class BenhNhan : EntityBase<int> 
{
    [Key]
    public int MaBN { get; set; }

    public string? LichSuKB { get; set; }

    public string? TTYT { get; set; }

    public string? BHYT { get; set; }
}