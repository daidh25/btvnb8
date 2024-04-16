using System;

public class HangThucPham : HangHoa
{
    public string CachBaoQuan { get; set; }
    public string NoiSanXuat { get; set; }

    public override void Nhap()
    {
        base.Nhap();


        Console.Write("Nhập cách bảo quản: ");
        CachBaoQuan = Console.ReadLine();

        Console.Write("Nhập nơi sản xuất: ");
        NoiSanXuat = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Loại: Thực phẩm, {base.ToString()}, Cách bảo quản: {CachBaoQuan}, Nơi sản xuất: {NoiSanXuat}";
    }
}
