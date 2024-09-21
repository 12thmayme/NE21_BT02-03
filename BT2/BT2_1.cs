// Bài 1: Nhập vào 2 số nguyên dương a, b từ bàn phím. Tỉnh tổng, hiệu, tích, thương của 2
// số vừa nhập và hiển thị kết quả ra màn hình

using System;

namespace BaiTapTinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập liệu
            Console.Write("Nhập số nguyên dương a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên dương b: ");
            int b = int.Parse(Console.ReadLine());

            // Tính toán
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            double thuong = (double)a / b; // Ép kiểu để chia lấy phần thập phân

            // Xuất kết quả
            Console.WriteLine("Tổng của {0} và {1} là: {2}", a, b, tong);
            Console.WriteLine("Hiệu của {0} và {1} là: {2}", a, b, hieu);
            Console.WriteLine("Tích của {0} và {1} là: {2}", a, b, tich);
            Console.WriteLine("Thương của {0} và {1} là: {2}", a, b, thuong);
        }
    }
}