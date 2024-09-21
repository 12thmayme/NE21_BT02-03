
// Bài 3: Nhập vào đường kính hình tròn, tính bán kính, chu vi, diện tích hình tròn và hiển
// thị kết quả ra màn hình.


using System;

namespace TinhToanHinhTron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập đường kính của hình tròn: ");
            double duongKinh = double.Parse(Console.ReadLine());

            double banKinh = duongKinh / 2;
            double chuVi = Math.PI * duongKinh;
            double dienTich = Math.PI * Math.Pow(banKinh, 2);

            Console.WriteLine("Bán kính hình tròn là: {0}", banKinh);
            Console.WriteLine("Chu vi hình tròn là: {0}", chuVi);
            Console.WriteLine("Diện tích hình tròn là: {0}", dienTich);
        }
    }
}