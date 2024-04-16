using System;

public class NhanVienBanThoiGian : NhanVien
{
    public int GioLamViec { get; set; }
    public double LuongGio { get; set; }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Số giờ làm việc: {GioLamViec}");
        Console.WriteLine($"Lương theo giờ: {LuongGio}");
    }

    public override double TinhLuong()
    {
        return GioLamViec * LuongGio;
    }
}
