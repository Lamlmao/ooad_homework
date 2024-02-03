using Microsoft.AspNetCore.Mvc;
using ooad_homework.Services;

namespace ooad_homework.Controllers
{
    public class PhieuTheoDoiSKController : Controller
    {
        private List<NhapPhieuTheoDoiSKDTO> data = QuanLyPhieuTheoDoiSKService.Data;

        [HttpPost]
        public IActionResult NhapPhieuTheoDoi(NhapPhieuTheoDoiSKDTO doiSKDTO)
        {
            doiSKDTO.MaPTD = data.Count + 1; 
            if(doiSKDTO.MaBenhNhan != 0)
                data.Add(doiSKDTO);
            return RedirectToAction("LietKePhieuTheoDoi");
        }
        [HttpGet]
        public IActionResult NhapPhieuTheoDoi(){
            return View();
        }
        public IActionResult LietKePhieuTheoDoi(){
            return View(data);
        }
        [HttpGet]
        public IActionResult XoaPhieuTheoDoi(){
            return View();
        }
        [HttpPost]
        public IActionResult SuaPhieuTheoDoi(NhapPhieuTheoDoiSKDTO nhapPhieuTheoDoiSKDTO){
            var currentValue = data.Where(p => p.MaPTD == nhapPhieuTheoDoiSKDTO.MaPTD).First();

            currentValue.MaNhanVien = nhapPhieuTheoDoiSKDTO.MaNhanVien;
            currentValue.NPTD = nhapPhieuTheoDoiSKDTO.NPTD;
            currentValue.TongTienTD = nhapPhieuTheoDoiSKDTO.TongTienTD ; 
            currentValue.TTThuoc = nhapPhieuTheoDoiSKDTO.TTThuoc ; 
            currentValue.LichTD = nhapPhieuTheoDoiSKDTO.LichTD ; 
            currentValue.MaCuocPT = nhapPhieuTheoDoiSKDTO.MaCuocPT ; 
            currentValue.MaNhanVien = nhapPhieuTheoDoiSKDTO.MaNhanVien;
            currentValue.MaBenhNhan = nhapPhieuTheoDoiSKDTO.MaBenhNhan ; 
            currentValue.MaBenhAn = nhapPhieuTheoDoiSKDTO.MaBenhAn; 
            return RedirectToAction("LietKePhieuTheoDoi");
        }
        [HttpGet]
        public IActionResult SuaPhieuTheoDoi( ){


            return View();
        }
        [HttpPost]
        public IActionResult XoaPHieuTheoDoi(int MaPTD){
            data.Remove(data.Where(p => p.MaPTD == MaPTD).First());
            return RedirectToAction("LietKePhieuTheoDoi");
        }
        public class NhapPhieuTheoDoiSKDTO {
            public int MaPTD { get; set; }

            public DateTime NPTD { get; set; }

            public float? TongTienTD { get; set; }

            public string? TTThuoc { get; set; }

            public DateTime? LichTD { get; set; }

            public int MaCuocPT { get; set;}

            public int MaNhanVien { get; set;}

            public int MaBenhAn { get; set;}

            public int MaBenhNhan { get; set;}        
            }
    }
}