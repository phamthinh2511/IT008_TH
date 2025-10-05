using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Solution()
        {
            int nam;
            Console.Write("Nhập năm: ");
            nam = int.Parse(Console.ReadLine());
            if (nam < 1)
            {
                Console.WriteLine("Năm không hợp lệ!");
                exit(0);
            }
            bool nhuan = ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0));
            int thang;
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            if (thang < 1 || thang > 12)
            {
                Console.WriteLine("Tháng không hợp lệ.");
                exit(0);
            }
            if (thang == 2)
            {
                if (nhuan)
                {
                    Console.WriteLine("Số ngày trong tháng 2 năm {0} là: 29", nam);
                }
                else
                {
                    Console.WriteLine("Số ngày trong tháng 2 năm {0} là: 28", nam);
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.WriteLine("Số ngày trong tháng {1} năm {0} là: 30", nam, thang);
            }
            else Console.WriteLine("Số ngày trong tháng {1} năm {0} là: 31", nam, thang);
        }

        private static void exit(int v)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Solution();
        }
    }
}
