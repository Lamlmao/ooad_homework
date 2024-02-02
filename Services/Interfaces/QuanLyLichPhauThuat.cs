using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyLichPhauThuat
    {
        void LapPhieuHenPhauThuat(LapPhieuHenPhauThuatDTO lapPhieuHenPhauThuatDTO);
        void CapNhatPhieuHenPhauThuat(CapNhatPhieuHenPhauThuatDTO capNhatPhieuHenPhauThuatDTO);
        void XoaPhieuHen(XoaPhieuHenDTO xoaPhieuHenDTO);
        void TimKiemPhieuHen(TimKiemPhieuHenDTO timKiemPhieuHenDTO);
    }
}