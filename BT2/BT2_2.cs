// Bài 2: Nhập vào 2 cạnh của hình chữ nhật, tính diện tích, chu vi và hiển thị kết quả ra màn
//hình.

using System;

namespace TinhToanHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chiều dài của hình chữ nhật: ");
            double chieuDai = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng của hình chữ nhật: ");
            double chieuRong = double.Parse(Console.ReadLine());

            double dienTich = chieuDai * chieuRong;
            double chuVi = 2 * (chieuDai + chieuRong);
            
            Console.WriteLine("Diện tích hình chữ nhật là: {0}", dienTich);
            Console.WriteLine("Chu vi hình chữ nhật là: {0}", chuVi);
        }
    }
}