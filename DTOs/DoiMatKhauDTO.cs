using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace ooad_homework.DTOs
{
    public class DoiMatKhauDTO
    {
        public string TaiKhoan { get; set; }

        public string MatKhauCu { get; set; }

        public string MatKhauMoi { get; set; }

        public string XacNhanMatKhau { get; set; }
    }
}