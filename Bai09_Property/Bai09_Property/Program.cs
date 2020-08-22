using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Bai09_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hinh = new HinhChuNhat();

            hinh.ChieuDai = 4;
            hinh.ChieuRong = 5;

            hinh.tinhChuVi();
            hinh.tinhDienTich();

            Console.WriteLine(hinh.Ten + " co chu vi la " + hinh.ChuVi);
            Console.WriteLine(hinh.Ten + " co dien tich la " + hinh.DienTich);

            HinhChuNhat hinh2 = hinh;
            // True
            Console.WriteLine(hinh2.Equals(hinh));

            HinhChuNhat hinh3 = new HinhChuNhat();
            hinh3.ChieuDai = hinh.ChieuDai;
            hinh3.ChieuRong = hinh.ChieuRong;
            hinh3.tinhChuVi();
            hinh3.tinhDienTich();
            // False
            Console.WriteLine(hinh3.Equals(hinh));


            Console.ReadLine();
        }
    }
}
