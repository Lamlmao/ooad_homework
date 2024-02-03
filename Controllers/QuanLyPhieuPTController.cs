using Microsoft.AspNetCore.Mvc;
using ooad_homework.Services;

namespace ooad_homework.Controllers
{
    public class QuanLyPhieuPTController : Controller
    {
        private List<NhapPhieuPTDTO> data = QuanLyPhieuPTService.Data;

        [HttpPost]
        public IActionResult NhapPhieuPhauThuat(NhapPhieuPTDTO doiSKDTO)
        {
            doiSKDTO.MaPPT = data.Count + 1;
            if (doiSKDTO.MaBenhNhan != 0)
                data.Add(doiSKDTO);
            return RedirectToAction("LietKePhieuPhauThuat");
        }
        [HttpGet]
        public IActionResult NhapPhieuPhauThuat()
        {
            return View();
        }
        public IActionResult LietKePhieuPhauThuat()
        {
            return View(data);
        }
        [HttpGet]
        public IActionResult XoaPhieuPhauThuat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SuaPhieuPhauThuat(NhapPhieuPTDTO nhapPhieuPTDTO)
        {
            var currentValue = data.Where(p => p.MaPPT == nhapPhieuPTDTO.MaPPT).First();

                currentValue.MaPPT = nhapPhieuPTDTO.MaPPT;
                currentValue.NgayLP = nhapPhieuPTDTO.NgayLP;
                currentValue.TongTien = nhapPhieuPTDTO.TongTien;
                currentValue.TongTienH = nhapPhieuPTDTO.TongTienH;
                currentValue.MaBenhNhan = nhapPhieuPTDTO.MaBenhNhan;
                currentValue.MaCuocPT = nhapPhieuPTDTO.MaCuocPT;
                currentValue.MaNhanVien = nhapPhieuPTDTO.MaNhanVien;

            return RedirectToAction("LietKePhieuPhauThuat");
        }
        [HttpGet]
        public IActionResult SuaPhieuPhauThuat()
        {


            return View();
        }
        [HttpPost]
        public IActionResult XoaPhieuPhauThuat(int MaPPT)
        {
            data.Remove(data.Where(p => p.MaPPT == MaPPT).First());
            return RedirectToAction("LietKePhieuPhauThuat");
        }
        public class NhapPhieuPTDTO
        {

            public int MaPPT { get; set; }

            public DateTime NgayLP { get; set; }

            public float? TongTien { get; set; }

            public float? TongTienH { get; set; }

            public int MaBenhNhan { get; set; }

            public int MaCuocPT { get; set; }

            public int MaNhanVien { get; set; }
        }
    }
}