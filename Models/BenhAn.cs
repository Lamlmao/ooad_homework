using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class BenhAn : EntityBase<int> 
{
    public int MaBA { get; set; }

    public double? TTLS { get; set; }

    public string? TTCLS { get; set; }

    public string? TTHPT { get; set; }

    public string? TDSK { get; set; }
}