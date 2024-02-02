using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace ooad_homework.DTOs
{
    public class TimKiemTaiKhoanInputDTO
    {
        public string? Email { get; set; }
        public string? CCCD { get; set; }
    }

    public class TimKiemTaiKhoanOutputDTO
    {
        public int MaNguoiDung { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}