using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_OnTap2
{
    internal class CongTy // Lớp sử lý logic
    {
        List<NhanVien> _staffs = new List<NhanVien>() {
        new NhanVien(){MaNhanVien = 1, HoTen= "Nguyễn Văn Phúc",ChucVu="GV",Luong=200000,PhongBan="C#"}
        };

        internal void ThemNhanVien()
        {
            NhanVien nhanVien = new NhanVien (); // Khoi tạo object rỗng, các trường, property đang không có dữ liệu
            //chèn dữ liệu vào property
            Console.Write("Xin mời nhập Mã nhân viên: ");
            nhanVien.MaNhanVien = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập họ tên nhân viên: ");
            nhanVien.HoTen = Console.ReadLine();
            Console.Write("Xin mời nhập chức vụ nhân viên: ");
            nhanVien.ChucVu = Console.ReadLine();
            Console.Write("Xin mời nhập lương nhân viên: ");
            nhanVien.Luong = double.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập phòng ban nhân viên: ");
            nhanVien.PhongBan = Console.ReadLine();

            // Thêm nhân viên vào danh sách
            _staffs.Add(nhanVien); 
        }

        internal void HienThiDanhSach()
        {
            Console.WriteLine();
            foreach (var nhanVien in _staffs) // duyệt từng phần tử trong danh sách
            {
                nhanVien.InThongTin(); // In thông tin với mỗi phần tử
                Console.WriteLine();// Xuống dòng với mỗi nhân viên
            }
            Console.WriteLine();
        }

        internal NhanVien TimNhanVien()
        {
            Console.Write("Xin mời nhập mã nhân viên: ");
            int maNhanVien = Convert.ToInt32(Console.ReadLine());
            foreach (var nhanVien in _staffs)
            {
                if (nhanVien.MaNhanVien == maNhanVien)
                {
                    nhanVien.InThongTin();
                    Console.WriteLine();
                    return nhanVien;
                }
            }

            Console.WriteLine($"Không tìm thấy nhân viên có mã: {maNhanVien}");
            return null;
        }

        internal void XoaNhanVien()
        {
            NhanVien nhanVienCanXoa = TimNhanVien();
            if(nhanVienCanXoa != null)
            {
                _staffs.Remove(nhanVienCanXoa);
                Console.WriteLine("Xoá nhân viên thành công");
            }
        }

        internal void KeThua()
        {
            NhanVienHopDong nhanVien = new NhanVienHopDong(); // Khoi tạo object rỗng, các trường, property đang không có dữ liệu
            //chèn dữ liệu vào property
            Console.Write("Xin mời nhập Mã nhân viên: ");
            nhanVien.MaNhanVien = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập họ tên nhân viên: ");
            nhanVien.HoTen = Console.ReadLine();
            Console.Write("Xin mời nhập chức vụ nhân viên: ");
            nhanVien.ChucVu = Console.ReadLine();
            Console.Write("Xin mời nhập lương nhân viên: ");
            nhanVien.Luong = double.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập phòng ban nhân viên: ");
            nhanVien.PhongBan = Console.ReadLine();
            Console.Write("Xin mời nhập loại hợp đồng nhân viên: ");
            nhanVien.LoaiHopDong = Console.ReadLine();

            nhanVien.InThongTin();
        }
    }
}
