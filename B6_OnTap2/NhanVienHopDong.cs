using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_OnTap2
{
    internal class NhanVienHopDong : NhanVien
    {
		private string _loaiHopDong;

        public NhanVienHopDong()
        {
        }

        public NhanVienHopDong(int maNhanVien, string ten, string chucVu, string phongBan, double luong,string loaiHopDong) 
            : base(maNhanVien, ten, chucVu, phongBan, luong)
        {
            _loaiHopDong = loaiHopDong;
        }

        public string LoaiHopDong
		{
			get { return _loaiHopDong; }
			set { _loaiHopDong = value; }
		}

        internal override void InThongTin()
        {
            base.InThongTin();
            Console.Write(", loại hợp đồng {0}", LoaiHopDong);
        }
    }
}
