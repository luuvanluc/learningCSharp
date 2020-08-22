using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class HinhChuNhat:HinhHoc2D
    {
        private float chieuDai;
        private float chieuRong;

        public HinhChuNhat (float dai, float rong):base("Hinh Chu Nhat")
        {
            chieuDai = dai;
            chieuRong = rong;
        }

        public HinhChuNhat() : this(0, 0) { }

        public override void tinhChuVi()
        {
 	        chuVi = (chieuDai + chieuRong ) * 2;
        }        public override void tinhDienTich()
        {
            dienTich = chieuDai * chieuRong;
        }        public float ChieuDai
        {
            get
            {
                return chieuDai;
            }
            set
            {
                chieuDai = value;
            }
        }        public float ChieuRong
        {
            get
            {
                return chieuRong;
            }
            set
            {
                chieuRong = value;
            }
        }
    }
}
