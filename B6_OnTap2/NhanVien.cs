using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_OnTap2
{
    internal class NhanVien
    {
        //Thuộc tính viết ở dạng đầy đủ Full Property
        //C1: propf + tab

        private int _maNhanVien;

        //c2: Tạo full property => khai báo field rồi ấn tổ hợp alt+enter chọn encapsulate field

        private string _ten;
        private string chucVu;
        private string phongBan;

        public int MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        public string HoTen { get => _ten; set => _ten = value; }

        //c3 Tạo auto property rồi chuyển thành full property
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public string PhongBan { get => phongBan; set => phongBan = value; }

        private double _luong;

        public NhanVien()
        {
        }

        public double Luong
        {
            get { return _luong; }
            set { _luong = value; }
        }

        public NhanVien(int maNhanVien, string ten, string chucVu, string phongBan, double luong)
        {
            _maNhanVien = maNhanVien;
            _ten = ten;
            this.chucVu = chucVu;
            this.phongBan = phongBan;
            _luong = luong;
        }

        /* public NhanVien(int maNhanVien, string hoTen, string chucVu, string phongBan, double luong)
         {
             MaNhanVien = maNhanVien;
             HoTen = hoTen;
             ChucVu = chucVu;
             PhongBan = phongBan;
             Luong = luong;
         }*/

        //tạo nhanh constructor 
        //c1: ctor + tab
        //c2: alt + enter => generate constructor
        //Đối với constructor có tham số chọn hết cờ lê, hoặc khối xanh



        internal virtual void InThongTin()
        {
            Console.Write("Mã nhân viên: {0}, Họ và tên: {1}, Chức vụ: {2},Lương: {3}, Phòng ban: {4} ", MaNhanVien,
                HoTen, ChucVu, Luong, PhongBan);
        }

       



    }
}
