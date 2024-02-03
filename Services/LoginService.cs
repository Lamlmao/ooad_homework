using ooad.Controllers;
using ooad_homework.DTOs;
using static ooad_homework.Controllers.PhieuTheoDoiSKController;
using static ooad_homework.Controllers.QuanLyBenhAnController;
using static ooad_homework.Controllers.QuanLyPhieuPTController;

namespace ooad_homework.Services
{
    public class LoginService
    {
        private static List<LoginDTO> _datas = null ; 

        public static List<LoginDTO> Data {
            get {
                if(_datas == null)
                    _datas = new List<LoginDTO>(){
                        new LoginDTO(){
                            UserName = "lamnh43",
                            Password = "lamnh43@123"
                        }
                    };
                return _datas; 
            }
        }
    }
}