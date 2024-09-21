using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Không có số nguyên tố nào nhỏ hơn 2.");
            return;
        }

        Console.WriteLine($"Các số nguyên tố từ 1 đến {n} là:");
        for (int i = 2; i <= n; i++)
        {
            if (KiemTraNguyenTo(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    // Hàm kiểm tra số nguyên tố
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
