using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class HinhHoc2D
    {
        protected string ten;
        protected float chuVi;
        protected float dienTich;

        public HinhHoc2D (string ten)
        {
            this.ten = ten;
            chuVi = dienTich = 0;
        }

        public string Ten
        {
            get
            {
                return this.ten;
            }
        }

        public float ChuVi
        {
            get
            {
                return this.chuVi;
            }
        }

        public float DienTich
        {
            get
            {
                return dienTich;
            }
        }

        public abstract void tinhChuVi();
        public abstract void tinhDienTich();



    }
}
