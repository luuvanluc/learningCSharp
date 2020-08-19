using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_XuatNhapConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten cua ban: ");
            string name = Console.ReadLine();
            Console.Write("Nhap nam sinh cua ban: ");
            string strBirthYear = Console.ReadLine();
            int birthYear = Int32.Parse(strBirthYear);
            int thisYear = DateTime.Now.Year;
            int age = thisYear - birthYear;
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine("Tuoi cua ban la {0}", age);

            Console.ReadLine();

        }
    }
}
