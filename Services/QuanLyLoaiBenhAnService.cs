using ooad_homework.DTOs;
using static ooad_homework.Controllers.PhieuTheoDoiSKController;
using static ooad_homework.Controllers.QuanLyBenhAnController;
using static ooad_homework.Controllers.QuanLyPhieuPTController;

namespace ooad_homework.Services
{
    public class QuanLyBenhAnService
    {
        private static List<BenhAnDTO> _datas = null ; 

        public static List<BenhAnDTO> Data {
            get {
                if(_datas == null)
                    _datas = new List<BenhAnDTO>();
                return _datas; 
            }
        }
    }
}