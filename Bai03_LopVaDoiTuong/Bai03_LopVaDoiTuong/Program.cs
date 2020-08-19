using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_LopVaDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron hinhTron = new HinhTron(10);
            Console.WriteLine("Hinh tron co chu vi la {0} va dien tich la {1}", hinhTron.tinhChuVi(), hinhTron.tinhDienTich());

            Console.ReadLine();
        }
    }
}
