using System.ComponentModel.DataAnnotations;
using ooad_homework.Common;

namespace ooad_homework.Models;
public class BacSi : EntityBase<int> 
{
    public DateTime NCTBS { get; set; }

    public DateTime? NKTBS { get; set; }

    public string CVBS { get; set; }

    public string KhoaBS { get; set; }
}