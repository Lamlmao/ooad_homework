using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyLoaiBenhAn
    {
        void ThemMoiLoaiBenhAn(ThemMoiLoaiBenhAnDTO themMoiLoaiBenhAnDTO);
        void SuaThongTinLoaiBenhAn(SuaThongTinBenhAnDTO suaThongTinBenhAnDTO);
        void XoaLoaiBenhAn(XoaLoaiBenhAnDTO xoaLoaiBenhAnDTO);
        void LietKeLoaiBenhAn(LietKeLoaiBenhAnDTO lietKeLoaiBenhAnDTO);
        
    }
}