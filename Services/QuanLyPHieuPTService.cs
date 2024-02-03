using ooad_homework.DTOs;
using static ooad_homework.Controllers.PhieuTheoDoiSKController;
using static ooad_homework.Controllers.QuanLyPhieuPTController;

namespace ooad_homework.Services
{
    public class QuanLyPhieuPTService
    {
        private static List<NhapPhieuPTDTO> _datas = null ; 

        public static List<NhapPhieuPTDTO> Data {
            get {
                if(_datas == null)
                    _datas = new List<NhapPhieuPTDTO>();
                return _datas; 
            }
        }
    }
}