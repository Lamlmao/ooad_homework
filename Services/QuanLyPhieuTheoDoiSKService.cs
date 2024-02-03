using ooad_homework.DTOs;
using static ooad_homework.Controllers.PhieuTheoDoiSKController;

namespace ooad_homework.Services
{
    public class QuanLyPhieuTheoDoiSKService
    {
        private static List<NhapPhieuTheoDoiSKDTO> _datas = null ; 

        public static List<NhapPhieuTheoDoiSKDTO> Data {
            get {
                if(_datas == null)
                    _datas = new List<NhapPhieuTheoDoiSKDTO>();
                return _datas; 
            }
        }
    }
}