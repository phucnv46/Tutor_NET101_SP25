using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_OOP_KeThua
{
    internal class XeMay : PhuongTien 
    {
        public XeMay()
        {
        }

        public XeMay(int iD, string ten, string loaiNhienLieu, string loaiDongCo,string hangXe,double phanKhoi) 
            : base(iD, ten, loaiNhienLieu, loaiDongCo)
        {
            HangXe = hangXe;
            PhanKhoi = phanKhoi;
        }

        //XeMay được kế thừa các thuộc tính từ phương tiện: Id,Ten,LoaiNhienLieu,LoaiDongCo,...

        //Thêm thuộc tính: (Đôt biến) 
        //Thuộc tính riêng của XeMay
        public string HangXe { get; set; }

        public double PhanKhoi { get; set; }

        public override void DiChuyen()
        {
            //base để truy cập các phương thức của lớp cha
            //Tạo 1 đối tượng cha để sử dung
            base.DiChuyen();
            Console.WriteLine("Di chuyen bằng xe máy");
        }

        //Để tạo constructor có tham số nhanh sử dụng tổ hợp ctrl + .
        //Chọn generate constructor (....)
        

    }
}
