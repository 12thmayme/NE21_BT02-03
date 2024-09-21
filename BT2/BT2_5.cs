using System;

namespace QuanLyNhanVien
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double LuongCoBan { get; set; }
        public   
 int SoNamLamViec { get; set; }
        public double PhuCap { get; set; }

        public void TinhPhuCap()
        {
            PhuCap = SoNamLamViec > 5 ? LuongCoBan / 2 : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NhanVien[] nhanVien = new NhanVien[2];

            for (int i = 0; i < nhanVien.Length; i++)
            {
                nhanVien[i] = new NhanVien();

                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("Họ tên: ");
                nhanVien[i].HoTen = Console.ReadLine();
                // Nhập các thông tin còn lại tương tự

                // Tính phụ cấp
                nhanVien[i].TinhPhuCap();
            }

            // Hiển thị thông tin
            Console.WriteLine("\nThông tin các nhân viên:");
            foreach (var nv in nhanVien)
            {
                Console.WriteLine($"Họ tên: {nv.HoTen}");
                Console.WriteLine($"Giới tính: {nv.GioiTinh}");
                // Hiển thị các thông tin còn lại tương tự
            }
        }
    }
}
