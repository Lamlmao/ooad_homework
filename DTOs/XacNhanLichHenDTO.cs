using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace ooad_homework.DTOs
{
    public class XacNhanLichHenDTO
    {
        public DateTime NgayHen { get; set; }

        public TimeOnly GioHen { get; set; }

        public string DiaDiemHen { get; set; }

        public string TenNguoiHen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string SDT { get; set; }

        public string Email { get; set; }

        public string CCCD { get; set; }
    }
}