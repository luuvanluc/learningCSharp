using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Bai06_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhHoc2D hinh = new HinhChuNhat(4,5);
            hinh.tinhDienTich();
            hinh.tinhChuVi();
            hinh.inChuVi();
            hinh.inDienTich();

            Console.ReadLine();
        }
    }
}
