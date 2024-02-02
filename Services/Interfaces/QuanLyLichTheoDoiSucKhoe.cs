using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyTheoDoiVaChamSocSKHauPhauThuat
    {
        void LapPhieuHenDieuTri(LapPhieuHenDieuTriDTO lapPhieuHenDieuTriDTO);
        void CapNhatPhieuHen(CapNhatPhieuHenDTO capNhatPhieuHenDTO);
        void XoaPhieuHen(XoaPhieuHenDTO xoaPhieuHenDTO);
        void TimKiemPhieuHen(TimKiemPhieuHenDTO timKiemPhieuHenDTO);
    }
}