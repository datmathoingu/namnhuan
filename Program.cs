using System;
using System.Text;

namespace namnhuan
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int years;
            Boolean kt;
            Console.Write("Nhập năm muốn kiểm tra : ");
            years = Convert.ToInt32(Console.ReadLine());
            kt = nam(years);
            if (kt)
            Console.Write("Năm {0} là năm Nhuận ", years);
            else
            Console.Write("Năm {0} không phải là năm Nhuận ", years);
            Console.ReadLine();

        }
        static Boolean nam(int nam)
        {
            if (nam % 400 == 0 && nam % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
