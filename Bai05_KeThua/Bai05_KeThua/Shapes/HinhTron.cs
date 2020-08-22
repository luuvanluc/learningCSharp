using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class HinhTron:HinhHoc2D
    {
        private float banKinh;
        
        public HinhTron(float banKinh):base("Hinh Tron")
        {
            this.banKinh = banKinh;
        }

        public HinhTron():this(0)
        {

        }

        public override void tinhChuVi()
        {
            chuVi = 2 * PI * banKinh;
        }

        public override void tinhDienTich()
        {
            dienTich = PI * banKinh * banKinh;
        }
    }
}
