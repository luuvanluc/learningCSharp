using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class HinhChuNhat:HinhHoc2D
    {
        float chieuDai;
        float chieuRong;
        float chuVi;
        float dienTich;

        public HinhChuNhat (float dai, float rong)
        {
            chieuDai = dai;
            chieuRong = rong;
            chuVi = dienTich = 0;
        }

        // When implement interface, not need type "override" beside method. But always public method
        public void tinhChuVi()
        {
            chuVi = 2 * (chieuRong + chieuDai);
        }

        public void tinhDienTich()
        {
            dienTich = chieuDai * chieuRong;
        }

        public void inChuVi()
        {
            Console.WriteLine("Hinh Chu Nhat co chu vi " + chuVi);
        }

        public void inDienTich()
        {
            Console.WriteLine("Hinh Chu Nhat co dien tich " + dienTich);
        }
    }
}
