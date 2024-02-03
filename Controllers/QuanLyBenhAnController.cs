using Microsoft.AspNetCore.Mvc;
using ooad_homework.Services;

namespace ooad_homework.Controllers
{
    public class QuanLyBenhAnController : Controller
    {
        private List<BenhAnDTO> data = QuanLyBenhAnService.Data;

        [HttpPost]
        public IActionResult NhapBenhAn(BenhAnDTO doiSKDTO)
        {
            doiSKDTO.MaBA = data.Count + 1;
            if (doiSKDTO.MaBenhNhan != 0)
                data.Add(doiSKDTO);
            return RedirectToAction("LietKeBenhAn");
        }
        [HttpGet]
        public IActionResult NhapBenhAn()
        {
            return View();
        }
        public IActionResult LietKeBenhAn()
        {
            return View(data);
        }
        [HttpGet]
        public IActionResult XoaBenhAn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SuaBenhAn(BenhAnDTO nhapPhieuPTDTO)
        {
            var currentValue = data.Where(p => p.MaBA == nhapPhieuPTDTO.MaBA).First();

                currentValue.MaBA = nhapPhieuPTDTO.MaBA;
                currentValue.TTLS = nhapPhieuPTDTO.TTLS;
                currentValue.TTCLS = nhapPhieuPTDTO.TTCLS;
                currentValue.TTHPT = nhapPhieuPTDTO.TTHPT;
                currentValue.TDSK = nhapPhieuPTDTO.TDSK;
                currentValue.MaBenhNhan = nhapPhieuPTDTO.MaBenhNhan;
                currentValue.MaBacSi = nhapPhieuPTDTO.MaBacSi;


            return RedirectToAction("LietKeBenhAn");
        }
        [HttpGet]
        public IActionResult SuaBenhAn()
        {


            return View();
        }
        [HttpPost]
        public IActionResult XoaBenhAn(int MaBA)
        {
            data.Remove(data.Where(p => p.MaBA == MaBA).First());
            return RedirectToAction("LietKeBenhAn");
        }
        public class BenhAnDTO
        {

            public int MaBA { get; set; }

    public double? TTLS { get; set; }

    public string? TTCLS { get; set; }

    public string? TTHPT { get; set; }

    public string? TDSK { get; set; }

    public int MaLoaiBenhAn { get; set; }

    public int MaBenhNhan { get; set; }
    public int MaBacSi { get; set; }
        }
    }
}