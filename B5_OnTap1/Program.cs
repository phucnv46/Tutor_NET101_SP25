namespace B5_OnTap1
{
    internal class Program
    {
        /*
          Các bước triển khai bài thi: Đọc kỹ đề: 
           -Phần nào dễ và nhiều điểm làm trước
           -Khó hoặc không biết làm sau hoặc bỏ qua

        -Tạo được class: Thực thể, Logic (1đ)
        -Tạo menu lặp(2đ)
        -Thêm 1 đối tượng (2đ)
        => Cơ bản để qua môn
        -Hiển thi danh sách, Tìm đối tượng (1đ)
        -Thường không vào đề sửa, Xoá đối tượng (1đ)
        -Tạo class con (1đ)
        -Thực hiện khởi tạo được object của class con (1đ)
        -Điểm 10: Xử lý dữ liệu, điều kiện
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int luaChon;
            while (true)
            {
                Console.WriteLine("1.Nhập thông tin đối tượng." +
                    "\r\n2.Hiển thị danh sách đối tượng." +
                    "\r\n3.Xóa đối tượng theo ID." +
                    "\r\n4.Thoát." +
                    "\r\n5.Kế thừa");
                Console.Write("Xin mời nhập lựa chọn: ");
                //luaChon = Convert.ToInt32(Console.ReadLine());
               // int.TryParse(Console.ReadLine(), out luaChon); // nếu nhập sai sẽ trả về 0
               int.TryParse(Console.ReadLine(), out luaChon);
                switch (luaChon)
                {
                    default:
                        Console.WriteLine("Lựa chọn sai!");
                        break;
                    case 4: return; // Thoát luôn ra khỏi hàm main <=> Thoát chương trình
                    case 1:SERVICE.ThemGiaoVien(); break;
                    case 2:SERVICE.HienThiDanhSach(); break;
                    case 3:SERVICE.XoaGiaoVien(); break;
                    case 5: SERVICE.KeThua(); break;
                        
                }
            }
        }
    }
}
