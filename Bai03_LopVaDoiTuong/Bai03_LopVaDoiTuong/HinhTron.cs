using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_LopVaDoiTuong
{
    class HinhTron
    {
        private const float PI = 3.14f;
        private float banKinh;

        public HinhTron(float banKinh)
        {
            this.banKinh = banKinh;
        }

        public HinhTron()
        {
            this.banKinh = 0;
        }

        public void setBanKinh(float banKinh)
        {
            this.banKinh = banKinh;
        }

        public float tinhChuVi()
        {
            return 2 * PI * banKinh;
        }

        public float tinhDienTich()
        {
            return PI * banKinh * banKinh;
        }
    }
}
