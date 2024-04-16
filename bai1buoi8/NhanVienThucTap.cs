using System;

public class NhanVienThucTap : NhanVien
{
    public DateTime NgayBatDau { get; set; }
    public int SoNgayThucTap { get; set; }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngày bắt đầu thực tập: {NgayBatDau.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Số ngày thực tập: {SoNgayThucTap}");
    }

    public override double TinhLuong()
    {
       
        return 0;
    }
}
