using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04_Static
{
    class HinhChuNhat
    {
        private float chieuDai;
        private float chieuRong;

        private static int num = 0;

        public HinhChuNhat(float chieuDai, float chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            num++;
        }

        public HinhChuNhat()
        {
            chieuDai = chieuRong = 0;
            num++;
        }

        public void setChieuDai(float chieuDai)
        {
            this.chieuDai = chieuDai;
        }

        public void setChieuRong(float chieuRong)
        {
            this.chieuRong = chieuRong;
        }

        public float tinhChuVi()
        {
            return 2 * (chieuRong + chieuDai);
        }

        public float tinhDienTich()
        {
            return chieuDai * chieuRong;
        }

        public static int getSoLuongHinhChuNhat()
        {
            return num;
        }

    }
}
