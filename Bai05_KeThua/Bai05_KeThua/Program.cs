using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Bai05_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhHoc2D hinhTron = new HinhTron(10);
            hinhTron.tinhChuVi();
            hinhTron.tinhDienTich();
            hinhTron.inTen();
            hinhTron.inChuVi();
            hinhTron.inDienTich();
            Console.WriteLine("Hinh Tron is Hinh Hoc 2D: " + (hinhTron is HinhHoc2D));

            HinhHoc2D hinh = new HinhHoc2D();
            hinh.tinhChuVi();
            hinh.tinhDienTich();
            hinh.inTen();
            hinh.inChuVi();
            hinh.inDienTich();
            Console.WriteLine("Hinh Hoc 2D is Hinh Tron: " + (hinh is HinhTron));


            Console.ReadLine();
        }
    }
}
