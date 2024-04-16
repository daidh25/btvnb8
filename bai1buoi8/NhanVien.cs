using System;

public class NhanVien
{
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string SoDienThoai { get; set; }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
        Console.WriteLine($"Số điện thoại: {SoDienThoai}");
    }

    public virtual double TinhLuong()
    {
        return 0;
    }
}
