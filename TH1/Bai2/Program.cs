using System;
namespace Bai2
{
    internal class Program
    {
        static bool songuyento(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i<= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                    
            }
            return true;
        }
        static int solution(int n)
        {
            int tong = 0;
            for (int i = 2; i < n; i++)
            {
                if (songuyento(i))
                    tong += i;
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Số các số nguyên bé hơn {0} là: {1}" ,n ,solution(n));
        }
    }
}
