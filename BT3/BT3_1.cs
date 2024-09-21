using System;

namespace KiemTraChiaHetCho3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một số nguyên: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine($"{number} chia hết cho 3.");
                }
                else
                {
                    Console.WriteLine($"{number} không chia hết cho 3.");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }
    }
}