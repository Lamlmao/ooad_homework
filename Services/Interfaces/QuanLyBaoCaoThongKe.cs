using ooad_homework.DTOs;

namespace ooad_homework.Services.Interfaces
{
    public interface IQuanLyBaoCaoThongKe
    {
        void ThongKeDanhSachBenhNhanKhongDongTien(ThongKeDanhSachBenhNhanKhongDongTienDTO thongKeDanhSachBenhNhanKhongDongTienDTO);
        void ThongKeDanhSachBenhNhanDangChoPhauThuat(ThongKeDanhSachBenhNhanDangChoPhauThuat thongKeDanhSachBenhNhanDangChoPhauThuat);
        void ThongKeDanhSachBenhNhanHuyPhauThuat(ThongKeDanhSachBenhNhanHuyPhauThuat thongKeDanhSachBenhNhanHuyPhauThuat);
        void ThongBaoQuaHan(ThongBaoQuaHanDTO thongBaoQuaHanDTO);
        void ThongKeDanhSachBacSiPhauThuatvaSoLanPhauThuat(ThongKeDanhSachBacSiPhauThuatvaSoLanPhauThuatDTO thongKeDanhSachBacSiPhauThuatvaSoLanPhauThuatDTO);
    }
}