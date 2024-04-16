using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<NhanVien> danhSachNhanVien = new List<NhanVien>
        {
            new NhanVienToanThoiGian
            {
                HoTen = "Nguyen Van An",
                NgaySinh = new DateTime(1990, 1, 1),
                DiaChi = "Hà Nội",
                SoDienThoai = "0123456789",
                LuongThang = 20000000
            },
            new NhanVienBanThoiGian
            {
                HoTen = "Tran Thi Binh",
                NgaySinh = new DateTime(1995, 5, 5),
                DiaChi = "Ninh Bình",
                SoDienThoai = "0987654321",
                GioLamViec = 20,
                LuongGio = 100000
            },
            new NhanVienThucTap
            {
                HoTen = "Hoang Van Chi",
                NgaySinh = new DateTime(2000, 10, 10),
                DiaChi = "Thái Bình",
                SoDienThoai = "0123987654",
                NgayBatDau = new DateTime(2024, 4, 1),
                SoNgayThucTap = 30
            }
        };

        foreach (var nv in danhSachNhanVien)
        {
            Console.WriteLine("----------------------------");
            nv.HienThiThongTin();

            if (nv is NhanVienToanThoiGian)
            {
                var nhanVienToanThoiGian = nv as NhanVienToanThoiGian;
                Console.WriteLine($"Lương: {nhanVienToanThoiGian.TinhLuong()}");
            }
            else if (nv is NhanVienBanThoiGian)
            {
                var nhanVienBanThoiGian = nv as NhanVienBanThoiGian;
                Console.WriteLine($"Lương: {nhanVienBanThoiGian.TinhLuong()}");
            }
            else if (nv is NhanVienThucTap)
            {
             
                Console.WriteLine($"Lương: {nv.TinhLuong()}");
            }

            Console.WriteLine("----------------------------");
        }
    }
}
