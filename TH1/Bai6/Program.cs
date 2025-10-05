using System;
using System.Collections.Generic;
namespace Bai6
{
    internal class Program
    {
        static bool Songuyento(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Xuat(int[,] ma, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(ma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int Solonnhatnhonhat(int[,] ma, int n, int m, int process)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ma[i, j] > max)
                    {
                        max = ma[i, j];
                    }
                    if (ma[i, j] < min)
                    {
                        min = ma[i, j];
                    }
                }
            }
            if (process == 1) return max;
            else return min;
        }
        static int Dongcotonglonnhat(int[,] ma, int n, int m)
        {
            int tongln = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int tong = 0;
                for (int j = 0; j < m; j++)
                {
                    tong += ma[i, j];
                }
                if (tong > tongln)
                {
                    tongln = tong;
                }
            }
            return tongln;
        }
        static int Tongcacsokhacnguyento(int[,] ma, int n, int m)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!Songuyento(ma[i, j]))
                    {
                        tong += ma[i, j];
                    }
                }
            }
            return tong;
        }
        static void Xoadongthuk(int[,] ma, int n, int m)
        {
            int k;
            Console.Write("Nhập thứ tự hàng xóa (1 - n): ");
            k = int.Parse(Console.ReadLine());
            k--;
            int[,] moi1 = new int[n - 1, m];
            int ni = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == k) continue;
                for (int j = 0; j < m; j++)
                {
                    moi1[ni, j] = ma[i, j];
                }
                ni++;
            }
            Console.WriteLine("Ma trận sau khi xóa hàng thứ {0} là:", k + 1);
            if (moi1 == null || moi1.GetLength(0) == 0)
            {
                Console.WriteLine("Ma trận rỗng.");
                return;
            }
            Xuat(moi1, n - 1, m);
        }
        static void Xoacotcophantulonnhat(int[,] ma, int n, int m)
        {
            int max = Solonnhatnhonhat(ma, n, m, 1);
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max == ma[i, j])
                    {
                        list.Add(j);
                    }
                }
            }
            int[,] moi2 = new int[n, m - list.Count];
            for (int i = 0; i < n; i++)
            {
                int nj = 0;
                for (int j = 0; j < m; j++)
                {
                    bool skip = false;
                    foreach (int col in list)
                    {
                        if (j == col)
                            skip = true;
                    }
                    if(skip) continue;
                    moi2[i, nj] = ma[i, j];
                    nj++;
                }
            }
            Console.WriteLine("Ma trận sau khi xóa các cột chứa phần tử lớn nhất là:");
            if (moi2 == null || moi2.GetLength(1) == 0)
            {
                Console.WriteLine("Ma trận rỗng.");
                return;
            }
            Xuat(moi2, n, m - list.Count);
        }
        static void Menu(int[,] ma, int n, int m)
        {
            int thaotac;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. In ma trận");
                Console.WriteLine("2. Tìm phần tử lớn nhất/nhỏ nhất");
                Console.WriteLine("3. Tìm dòng có tổng các phần tử lớn nhất");
                Console.WriteLine("4. Tính tổng các số không phải số nguyên tố");
                Console.WriteLine("5. Xóa dòng thứ k của ma trận");
                Console.WriteLine("6. Xóa cột có phần tử lớn nhất trong ma trận");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                thaotac = int.Parse(Console.ReadLine());

                switch (thaotac)
                {
                    case 1:
                        Console.WriteLine("Ma trận:");
                        Xuat(ma, n, m);
                        break;
                    case 2:
                        Console.Write("Nhập 1 hoặc 0 để tìm số LN hoặc NN:");
                        int process = int.Parse(Console.ReadLine());
                        if (process == 1)
                            Console.Write("Số lớn nhất: {0}", Solonnhatnhonhat(ma, n, m, process));
                        else
                            Console.Write("Số nhỏ nhất: {0}", Solonnhatnhonhat(ma, n, m, process));
                        break;
                    case 3:
                        Console.WriteLine("Hàng có tổng các phần tử lớn nhất là: {0}", Dongcotonglonnhat(ma, n, m));
                        break;
                    case 4:
                        Console.WriteLine("Tổng các phần tử không phải số nguyên tố là: {0}", Tongcacsokhacnguyento(ma, n, m));
                        break;
                    case 5:
                        Xoadongthuk(ma, n, m);
                        break;
                    case 6:
                        Xoacotcophantulonnhat(ma, n, m);
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
            int m, n;
            Console.Write("Nhập số hàng: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            m = int.Parse(Console.ReadLine());
            int[,] ma = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int randnums = rand.Next(0, 1000);
                    ma[i, j] = randnums;
                }
            }
            Menu(ma, n, m);
        }
    }
}
