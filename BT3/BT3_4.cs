using System;

class Program
{
    static bool KiemTraChinhPhuong(int n)
    {
        if (n < 0)
        {
            return false;
        }
        int sqrtN = (int)Math.Sqrt(n);
        return sqrtN * sqrtN == n;
    }

    static void Main()
    {
        Console.Write("Nhập vào một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTraChinhPhuong(n))
        {
            Console.WriteLine($"{n} là số chính phương.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số chính phương.");
        }
    }
}