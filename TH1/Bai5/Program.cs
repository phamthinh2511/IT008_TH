using System;
namespace Bai5
{
    internal class Program
    {
        public class Date
        {
            private int day;
            private int month;
            private int year;
            private bool Nhuan;
            public Date()
            {
                day = 1;
                month = 1;
                year = 1;
            }
            public void Nhap()
            {
                Console.Write("Nhập năm: ");
                year = int.Parse(Console.ReadLine());
                while (year < 1)
                {
                    Console.Write("Nhập lại năm: ");
                    year = int.Parse(Console.ReadLine());
                }
                Nhuan = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                Console.Write("Nhập tháng: ");
                month = int.Parse(Console.ReadLine());
                while (month < 1 || month > 12)
                {
                    Console.Write("Nhập lại tháng: ");
                    month = int.Parse(Console.ReadLine());
                }
                int maxday;
                if (month == 2)
                {
                    if (Nhuan)
                        maxday = 29;
                    else
                        maxday = 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                    maxday = 30;
                else
                    maxday = 31;
                Console.Write("Nhập ngày: ");
                day = int.Parse(Console.ReadLine());
                while (day < 1 || day > maxday)
                {
                    Console.Write("Nhập lại ngày: ");
                    day = int.Parse(Console.ReadLine());
                }
            }
            public void Thu()
            {
                int tongngay = 0;
                for (int i = 1; i < year; i++)
                {
                    if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    {
                        tongngay += 366;
                    }
                    else
                    {
                        tongngay += 365;
                    }
                }
                for (int i = 1; i < month; i++)
                {
                    if (i == 2)
                    {
                        if (Nhuan)
                        {
                            tongngay += 29;
                        }
                        else
                        {
                            tongngay += 28;
                        }
                    }
                    else if (i == 4 || i == 6 || i == 9 || i == 11)
                    {
                        tongngay += 30;
                    }
                    else
                    {
                        tongngay += 31;
                    }
                }
                tongngay += day;
                tongngay %= 7;
                switch (tongngay)
                {
                    case 0: 
                        Console.WriteLine("Hôm nay là chủ nhật.");
                        break;
                    case 1: 
                        Console.WriteLine("Hôm nay là thứ hai.");
                        break;
                    case 2:
                        Console.WriteLine("Hôm nay là thứ ba.");
                        break;
                    case 3:
                        Console.WriteLine("Hôm nay là thứ tư.");
                        break;
                    case 4:
                        Console.WriteLine("Hôm nay là thứ năm.");
                        break;
                    case 5:
                        Console.WriteLine("Hôm nay là thứ sáu.");
                        break;
                    case 6:
                        Console.WriteLine("Hôm nay là thứ bảy.");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Date date = new Date();
            date.Nhap();
            date.Thu();
        }
    }
}
