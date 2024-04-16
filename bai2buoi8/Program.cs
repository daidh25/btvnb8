using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static bool KiemTraNhap(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Thông tin không được để trống. Vui lòng nhập lại.");
            return false;
        }
        if (Regex.IsMatch(input, @"[<>!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
        {
            Console.WriteLine("Không được nhập các ký tự đặc biệt hoặc thẻ. Vui lòng nhập lại.");
            return false;
        }
        return true;
    }

    static string NhapGiaTien()
    {
        string input;
        do
        {
            Console.Write("Nhập giá tiền: ");
            input = Console.ReadLine();
        } while (!double.TryParse(input, out double giaTien) || giaTien <= 0 || !KiemTraNhap(input));
        return input;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        HangDienTu[] dienTus = new HangDienTu[2];
        HangThucPham[] thucPhams = new HangThucPham[2];
        HangQuanAo[] quanAos = new HangQuanAo[2];

        Console.WriteLine("Nhập thông tin cho Hàng điện tử:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Nhập thông tin sản phẩm {i + 1}:");
            dienTus[i] = new HangDienTu();
            dienTus[i].Nhap();
        }

        Console.WriteLine("\nNhập thông tin cho Hàng thực phẩm:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Nhập thông tin sản phẩm {i + 1}:");
            thucPhams[i] = new HangThucPham();
            thucPhams[i].Nhap();
        }

        Console.WriteLine("\nNhập thông tin cho Hàng quần áo:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Nhập thông tin sản phẩm {i + 1}:");
            quanAos[i] = new HangQuanAo();
            quanAos[i].Nhap();
        }

        MuaHang(dienTus[0], 1);
        MuaHang(thucPhams[0], 1);
        MuaHang(quanAos[0], 1);

        ThongKeHetHan(dienTus);
        ThongKeHetHan(thucPhams);
        ThongKeHetHan(quanAos);
    }

    static void MuaHang(HangHoa hangHoa, int soLuong)
    {
        Console.WriteLine($"Đã mua {soLuong} sản phẩm {hangHoa.TenHang} - {hangHoa.MaHang}. Còn lại: {soLuong}");
    }

    static void ThongKeHetHan(HangHoa[] hangHoas)
    {
        DateTime ngayHienTai = DateTime.Now;
        Console.WriteLine("\nCác loại hàng hóa sắp hết hạn:");
        foreach (var hangHoa in hangHoas)
        {
            if (hangHoa.NgayHetHan.HasValue && (hangHoa.NgayHetHan.Value - ngayHienTai).TotalDays < 30)
            {
                Console.WriteLine(hangHoa);
            }
        }
    }
}
