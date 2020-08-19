using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hinhChuNhat1 = new HinhChuNhat();
            HinhChuNhat hinhChuNhat2 = new HinhChuNhat(2, 3);

            Console.WriteLine("Co tong co {0} hinh chu nhat duoc tao ra", HinhChuNhat.getSoLuongHinhChuNhat());
            Console.WriteLine("Hinh Chu Nhat 1 co chu vi la {0} va dien tich la {1}", hinhChuNhat1.tinhChuVi(), hinhChuNhat1.tinhDienTich());
            Console.WriteLine("Hinh Chu Nhat 2 co chu vi la {0} va dien tich la {1}", hinhChuNhat2.tinhChuVi(), hinhChuNhat2.tinhDienTich());

            Console.ReadLine();
        }
    }
}
