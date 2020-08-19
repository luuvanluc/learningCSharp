using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mang 1 chieu
            int N = 0;
            Console.Write("Nhap so phan tu mang: ");
            N = Int32.Parse(Console.ReadLine());
            int[] Mang = new int[N];
            for(int i = 0; i < N; i++)
            {
                Console.Write("Nhap phan tu thu {0} cua mang: ", i);
                Mang[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang da nhap la: ");
            Console.Write("Mang[{0}] = ", N);
            Console.Write("{");
            for (int i = 0; i < N; i++)
            {
                Console.Write(Mang[i]);
                if (i < (N - 1))
                    Console.Write(", ");
            }
            Console.WriteLine("}");

            char[] Chuoi = { 'L', 'U', 'C' };
            // Ket qua in ra LUC
            Console.WriteLine(Chuoi);
            
            // Mang  2 chieu
            int[,] MangHaiChieu = new int[4,5];


            Console.ReadLine();


            
        }
    }
}
