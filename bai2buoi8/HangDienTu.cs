using System;

public class HangDienTu : HangHoa
{
    public string HangSanXuat { get; set; }
    public string XuatXu { get; set; }

    public override void Nhap()
    {
        base.Nhap();

        Console.Write("Nhập hãng sản xuất: ");
        HangSanXuat = Console.ReadLine();

        Console.Write("Nhập xuất xứ: ");
        XuatXu = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Loại: Điện tử, {base.ToString()}, Hãng sản xuất: {HangSanXuat}, Xuất xứ: {XuatXu}";
    }
}
