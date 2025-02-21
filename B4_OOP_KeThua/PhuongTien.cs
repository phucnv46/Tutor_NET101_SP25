using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_OOP_KeThua
{
    internal class PhuongTien
    {
        public int ID { get; set; }

        public string Ten { get; set; }

        public string LoaiNhienLieu { get; set; }

        public string LoaiDongCo { get; set; }

        public virtual void DiChuyen()
        {
            Console.WriteLine("Đang chuyển động");
        }

        public PhuongTien() // constructor không tham số
        {
            
        }

        public PhuongTien(int iD, string ten, string loaiNhienLieu, string loaiDongCo) // constructor có tham số
        {
            ID = iD;
            Ten = ten;
            LoaiNhienLieu = loaiNhienLieu;
            LoaiDongCo = loaiDongCo;
        }
    }
}
