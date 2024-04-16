using System;

public class HangQuanAo : HangHoa
{
    public string Size { get; set; }
    public string MauSac { get; set; }

    public override void Nhap()
    {
        base.Nhap();

        Console.Write("Nhập size: ");
        Size = Console.ReadLine();

        Console.Write("Nhập màu sắc: ");
        MauSac = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Loại: Quần áo, {base.ToString()}, Size: {Size}, Màu sắc: {MauSac}";
    }
}
