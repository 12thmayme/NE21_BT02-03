using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao ngay ban muon: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Nhap vao thang ban muon: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap vao nam ban muon: ");
        int year = int.Parse(Console.ReadLine());

        DateTime enteredDate = new DateTime(year, month, day);

        DateTime yesterday = enteredDate.AddDays(-1);
        DateTime tomorrow = enteredDate.AddDays(1);

        Console.WriteLine("---------------------------->");
        Console.WriteLine("Ngay hom qua la: " + yesterday.ToString("dd/MM/yyyy"));
        Console.WriteLine("Ngay hien tai la: " + enteredDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Ngay mai la: " + tomorrow.ToString("dd/MM/yyyy"));
        Console.WriteLine("---------------------------->");
    }
}