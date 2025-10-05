using System;
namespace Bai3
{
    internal class Program
    {
        public class Date
        {
            private int day;
            private int month;
            private int year;
            private bool Nhuan;
            bool valid = true;
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
                if (year < 1)
                {
                    valid = false;
                }
                Nhuan = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                Console.Write("Nhập tháng: ");
                month = int.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    valid = false;
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
                if (day < 1 || day > maxday)
                {
                    valid = false;
                }
            }
            public void Xuat()
            {
                if (valid) Console.WriteLine("Ngày tháng năm hợp lệ.");
                else Console.WriteLine("Ngày tháng năm không hợp lệ.");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Date date = new Date();
            date.Nhap();
            date.Xuat();
        }
    }
}
