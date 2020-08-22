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

        public HinhChuNhat (float chieuDai, float chieuRong):base("Hinh Chu Nhat")
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        public override void tinhChuVi()
        {
            chuVi = 2 * (chieuRong + chieuDai);
        }

        public override void tinhDienTich()
        {
            dienTich = chieuDai * chieuRong;
        }
    }
}
