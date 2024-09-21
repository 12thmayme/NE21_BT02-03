using System;

namespace TinhDiemTrungBinh
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập liệu
            Console.Write("Nhập họ tên học sinh: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập lớp: ");
            string lop = Console.ReadLine();

            Console.Write("Nhập điểm trung bình học kì I: ");
            double diemHK1 = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm trung bình học kì II: ");
            double diemHK2 = double.Parse(Console.ReadLine());

            // Tính toán
            double diemTrungBinhCaNam = (diemHK1 + diemHK2 * 2) / 3;

            // Xuất kết quả
            Console.WriteLine("\nThông tin học sinh:");
            Console.WriteLine("Họ tên: {0}", hoTen);
            Console.WriteLine("Lớp: {0}", lop);
            Console.WriteLine("Điểm trung bình học kì I: {0}", diemHK1);
            Console.WriteLine("Điểm trung bình học kì II: {0}", diemHK2);
            Console.WriteLine("Điểm trung bình cả năm: {0}", diemTrungBinhCaNam);
        }
    }
}