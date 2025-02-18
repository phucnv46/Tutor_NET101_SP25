using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_OOP_DongGoi
{
    internal class GiangVien 
    {
        // Cú pháp tạo lớp: <phạm vi truy cập> class <Tên của class> {}
        //Tên class nên, phải viết theo kiểu pascal: Viết hoa các chữ cái đầu tiên của từ

        //Tạo các thuộc tính để mô tả class:
        // Có nhiều cách để tạo thuộc tính

        // trường dữ liệu


        // Full Property // propf+tab + tap

        private string _id;

        public string ID
        {
            get { return _id; }
            set { 
               if(value == null)
                {
                    Console.WriteLine("Không được để trống");
                    _id = "Không xác định";
                }
                _id = value;
            
            }
        }




        //sử dụng tổ hơp phím prop + tab để thêm thuôc tính nhanh không có field
        public string Name { get;  init; } // Auto Property
        // Có nhiều phạm vi truy cập của set

        //Method

        public void LenLop()
        {
            Console.WriteLine($"{Name} đã lên lớp");
        }

        // Hàm tạo : constructor: hàm định nghĩa cách tạo ra object

        public GiangVien()
        {
            Console.WriteLine("Tạo bằng constructor không tham số");
        }

        public GiangVien(string iD, string name)
        {
            ID = iD;
            Name = name;
            Console.WriteLine("Tạo bằng constructor có tham số");
        }
    }
}
