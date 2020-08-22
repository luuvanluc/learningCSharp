using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class HinhHoc2D
    {
        protected const float PI = 3.14f;
        protected string ten;
        protected float chuVi;
        protected float dienTich;

        public HinhHoc2D (string ten)
        {
            this.ten = ten;
            chuVi = dienTich = 0;
        }

        public HinhHoc2D()
            : this("Khong Xac Dinh")
        { }

        public abstract void tinhChuVi();
        public abstract void tinhDienTich();
        public virtual void inChuVi()
        {
            Console.WriteLine(ten + " co chu vi " + chuVi);
        }
        public virtual void inDienTich()
        {
            Console.WriteLine(ten + " co dien tich " + dienTich);
        }
    }
}
