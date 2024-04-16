using System;
using System.Text.RegularExpressions;

public class HangHoa
{
    public string MaHang { get; set; }
    public string TenHang { get; set; }
    public double GiaTien { get; set; }
    public DateTime NgaySanXuat { get; set; }
    public DateTime? NgayHetHan { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhập mã hàng: ");
        MaHang = Console.ReadLine();

        Console.Write("Nhập tên hàng: ");
        TenHang = Console.ReadLine();

        Console.Write("Nhập giá tiền: ");
        while (!double.TryParse(Console.ReadLine(), out double giaTien) || giaTien <= 0)
        {
            Console.WriteLine("Giá tiền phải là một số dương. Vui lòng nhập lại.");
        }

        Console.Write("Nhập ngày sản xuất (dd/MM/yyyy): ");
        NgaySanXuat = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Nhập ngày hết hạn (dd/MM/yyyy, nếu có): ");
        string ngayHetHanInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(ngayHetHanInput))
        {
            NgayHetHan = DateTime.ParseExact(ngayHetHanInput, "dd/MM/yyyy", null);
        }
    }

    public override string ToString()
    {
        return $"Mã hàng: {MaHang}, Tên hàng: {TenHang}, Giá tiền: {GiaTien}, Ngày sản xuất: {NgaySanXuat.ToString("dd/MM/yyyy")}, Ngày hết hạn: {(NgayHetHan.HasValue ? NgayHetHan.Value.ToString("dd/MM/yyyy") : "Không có")}";
    }
}
