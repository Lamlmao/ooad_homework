using ooad_homework.Common;

namespace ooad_homework.Models
{
    public class LoaiBenhAn : EntityBase<int>
    {
        public string TenLoaiBenhAn  { get; set; }
        public string MoTa { get; set; } 
        public List<BenhAn> BenhAns { get; set;}
    }
}