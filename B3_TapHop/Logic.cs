using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_TapHop
{
    internal class Logic
    {
        List<NhanVat> nhanVats = new List<NhanVat>();

        public void ThemNhanVat()
        {

            NhanVat nhanVat = new NhanVat();
            nhanVat.ID = 1;
            nhanVat.Ten = Console.ReadLine();
            nhanVat.He = Console.ReadLine();
            nhanVat.MauToiDa = double.Parse(Console.ReadLine());
          //  ...
        }
    }
}
