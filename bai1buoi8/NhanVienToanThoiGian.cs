using System;

public class NhanVienToanThoiGian : NhanVien
{
    public double LuongThang { get; set; }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Lương tháng: {LuongThang}");
    }

    public override double TinhLuong()
    {
        return LuongThang;
    }
}
