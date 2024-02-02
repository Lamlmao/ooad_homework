using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyThongTinCaNhan
    {
        void DangNhap(DangNhapDTO dangNhapDTO);
        void DangXuat(DangXuatDTO dangXuatDTO);
        void DoiMatKhau(DoiMatKhauDTO dangNhapDTO);
        void XacNhanNguoiDung(XacNhanNguoiDungDTO xacNhanNguoiDungDTO);
    }
}