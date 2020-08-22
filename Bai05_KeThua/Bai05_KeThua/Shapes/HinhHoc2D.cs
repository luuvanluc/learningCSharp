using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class HinhHoc2D
    {
        protected const float PI = 3.14f;
        protected string tenHinh;
        protected float chuVi;
        protected float dienTich;

        public HinhHoc2D(string tenHinh)
        {
            this.tenHinh = tenHinh;
            chuVi = dienTich = 0;
        }

        public HinhHoc2D()
            : this("Khong Xac Dinh")
        {

        }

        public void inTen()
        {
            Console.WriteLine("Hinh hoc la " + tenHinh);
        }

        public virtual void tinhChuVi()
        { 

        }

        public virtual void tinhDienTich()
        {

        }

        public void inChuVi()
        {
            Console.WriteLine("Chu Vi cua " + tenHinh + " la " + chuVi);
        }

        public void inDienTich()
        {
            Console.WriteLine("Dien Tich cua " + tenHinh + " la " + dienTich);
        }
    }
}
