using System;

namespace Bai1
{
    internal class Program
    {
        static bool songuyento(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static int demsochinhphuongnhonhat(int[]a, int n)
        {
            bool dem = false;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int sq = (int)Math.Sqrt(a[i]);
                if (sq * sq == a[i] && a[i] < min)
                    min = a[i];
            }
            if (!dem) return -1;
            return min;
        } 
        static int demtongsole(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    dem += a[i];
            }
            return dem;
        }
        static int demsonguyento(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (songuyento(a[i]))
                    dem++;
            }
            return dem;
        }
        static void Menu(int[] a, int n)
        {
            int thaotac;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. In mảng");
                Console.WriteLine("2. Tính tổng các số lẻ");
                Console.WriteLine("3. Đếm số nguyên tố");
                Console.WriteLine("4. Tìm số chính phương nhỏ nhất");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                thaotac = int.Parse(Console.ReadLine());

                switch (thaotac)
                {
                    case 1:
                        Console.WriteLine("Mảng:");
                        Console.WriteLine(string.Join(" ", a));
                        break;
                    case 2:
                        Console.WriteLine("Tổng các số lẻ: " + demtongsole(a, n));
                        break;
                    case 3:
                        Console.WriteLine("Số lượng số nguyên tố: " + demsonguyento(a, n));
                        break;
                    case 4:
                        Console.WriteLine("Số chính phương nhỏ nhất: " + demsochinhphuongnhonhat(a, n));
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (thaotac != 0);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            int count = 0;
            while (count < n)
            {
                int randnums = rand.Next(0, 1000);
                a[count] = randnums;
                count++;
            }
            Menu(a, n);
        }
    }
}
