using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyThongTinBenhAnDonThuoc
    {
        void ThemMoiThongTinBenhAn(ThemMoiThongTinBenhAnDTO themMoiThongTinBenhAnDTO);
        void SuaThongTinBenhAn(SuaThongTinBenhAnDTO suaThongTinBenhAnDTO);
        void CapNhatDonThuoc(CapNhatDonThuocDTO capNhatDonThuocDTO);
        void XoaBenhAn(XoaBenhAnDTO xoaBenhAnDTO);
        void TimKiemThongTinBenhAnCuaBenhNhan(TimKiemThongTinBenhAnCuaBenhNhanDTO timKiemThongTinBenhAnCuaBenhNhanDTO);
    }
}