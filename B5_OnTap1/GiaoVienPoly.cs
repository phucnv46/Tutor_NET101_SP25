using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_OnTap1
{
    internal class GiaoVienPoly : GiaoVien
    {
		private string _nganhDay;

        public GiaoVienPoly()
        {
        }

        public GiaoVienPoly(int id, string ten, double soGioDay,string nganhDay) : base(id, ten, soGioDay)
        {
            _nganhDay = nganhDay;
        }

        public string NganhDay
		{
			get { return _nganhDay; }
			set { _nganhDay = value; }
		}

        internal override void InThongTin()
        {
            base.InThongTin();
            Console.Write($" ,{NganhDay}");
        }

        
    }
}
