using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace B5_OnTap1
{
    internal class SERVICE
    {
        // static => không cần tạo đối tượng vẫn gọi được method

        static List<GiaoVien> _teachers = new List<GiaoVien>() { 
          new GiaoVien(){Id=1,Ten="Phuc",SoGioDay =32},
          new GiaoVien(){Id=2,Ten="Manh",SoGioDay =42},
          new GiaoVien(){Id=3,Ten="Hieu",SoGioDay =62},
        };

        internal static void ThemGiaoVien() // Ham them giao vien
        {
            GiaoVien giaoVien = new GiaoVien(); // Tạo object bằng constuctor không tham số
            Console.Write("Xin mời nhập ID giáo viên:");
            giaoVien.Id = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập tên giáo viên:");
            giaoVien.Ten = Console.ReadLine();
            Console.Write("Xin mời nhập số giờ dậy giáo viên:");
            giaoVien.SoGioDay = double.Parse(Console.ReadLine()); // nhớ đổi đúng kiểu

            // Thêm object vào list
            _teachers.Add(giaoVien);
            
        } 

        internal static void HienThiDanhSach() // Điểm 6
        {
            foreach (var giaoVien in _teachers)
            {
                giaoVien.InThongTin();
                Console.WriteLine();
            }
            // Console.WriteLine(JsonSerializer.Serialize(_teachers)); // Cách bí :)
        }

        private static GiaoVien TimGiaoVien()
        {
            Console.Write("Xin mời nhập ID của giáo viên cần tìm");
            int idCanTim = int.Parse(Console.ReadLine());
            foreach (var giaoVien in _teachers)
            {
               if(giaoVien.Id == idCanTim) return giaoVien; // trả về giáo viên cần tìm
            }

            return null;
        }

        internal static void XoaGiaoVien() //8đ
        {
            GiaoVien giaoVienCanXoa = TimGiaoVien();
            if(giaoVienCanXoa==null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Không tìm thấy ID cần xoá");
                Console.ResetColor();
                return;
            }
            
            _teachers.Remove(giaoVienCanXoa);
            HienThiDanhSach();
            
        }

        internal static void KeThua()
        {
            //trick lỏd :)
            GiaoVienPoly giaoVien = new GiaoVienPoly(); // Tạo object bằng constuctor không tham số
            Console.Write("Xin mời nhập ID giáo viên:");
            giaoVien.Id = int.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập tên giáo viên:");
            giaoVien.Ten = Console.ReadLine();
            Console.Write("Xin mời nhập số giờ dậy giáo viên:");
            giaoVien.SoGioDay = double.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập ngành dậy giáo viên:");
            giaoVien.NganhDay = Console.ReadLine();

            giaoVien.InThongTin();// In thông tin của giaoVienPoly
        }
    }
}
