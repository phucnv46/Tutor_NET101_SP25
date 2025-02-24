namespace B6_OnTap2
{
    internal class Program
    {
        /*
         1. **Tạo class NhanVien** với các thuộc tính và phương thức sau:
      - **Thuộc tính**:
        - MaNhanVien: int/string
        - HoTen: string
        - ChucVu: string
        - Luong: double
        - PhongBan: string
      - **Phương thức**: InThongTin(): void -> in ra thông tin nhân viên
      - **Constructor**: không tham số và có tham số

   2. **Tạo class NhanVienHopDong** kế thừa từ NhanVien
      - **Thêm 2 thuộc tính**:
        - ThoiHanHopDong: DateTime (Bỏ qua) // Các bạn nghiên cứu thêm. Đề thi sẽ không có trường datetime
        - LoaiHopDong: string
      - **Ghi đè phương thức** InThongTin(): void -> in ra thông tin nhân viên hợp đồng
      - **Constructor**: không tham số và có tham số (sử dụng base để kế thừa constructor)

   3. **Tạo interface IQuanLyNhanVien** với các phương thức: (bỏ)
      - ThemNhanVien(NhanVien nv): void
      - TimNhanVien(string maNV): NhanVien
      - XoaNhanVien(string maNV): void

   4. **Tạo class CongTy** để xử lý logic, implement interface IQuanLyNhanVien:
      - Có List<NhanVien>() (Nên khởi tạo trước data để thuận tiện cho chấm điểm)
      - Thực hiện các chức năng chính ở đây, menu chỉ để gọi chức năng của CongTy

   5. **Ở Program**:
      - Tạo menu lặp đến khi chọn Thoát thực hiện các chức năng sau:
        1. Thêm NhanVien vào danh sách
        2. Tìm nhân viên theo mã nhân viên, thông báo nếu không tìm thấy
        3. Xoá nhân viên theo mã nhân viên
        4. Tạo 1 NhanVienHopDong mới và in ra thông tin của NhanVienHopDong vừa tạo
        5.Hiển thị danh sách nhân viên
        0. Thoát
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int luaChon;
            while (true)
            {
                Console.WriteLine("1. Thêm NhanVien vào danh sách\r\n " +
                    "2. Tìm nhân viên theo mã nhân viên, thông báo nếu không tìm thấy\r\n    " +
                    "3. Xoá nhân viên theo mã nhân viên\r\n" +
                    "4. Tạo 1 NhanVienHopDong mới và in ra thông tin của NhanVienHopDong vừa tạo\r\n" +
                    "5.Hiển thị danh sách nhân viên\r\n" +
                    "6. Thoát");
               //Bắt người dùng nhập lựa chọn từ bàn phím
               // luaChon = int.Parse(Console.ReadLine()); // nếu người dùng nhập chữ sẽ gây ra lỗi
               int.TryParse(Console.ReadLine(), out luaChon);  // nếu nhập chữ sẽ trả về giá trị default là 0 sẽ không gây ra lỗi
               CongTy congTy = new CongTy();

                switch (luaChon)
                {

                    default: // Trường hợp nhập lựa chọn sai, hoặc không rơi vào case nào sẽ vào trường hợp này
                        Console.WriteLine("Lựa chọn sai");
                        break;
                    case 6: return;
                    case 1: congTy.ThemNhanVien() ; break;
                    case 2:congTy.TimNhanVien(); break;
                    case 3: congTy.XoaNhanVien(); break;
                    case 4: congTy.KeThua() ; break;
                    case 5:congTy.HienThiDanhSach(); break;
                }
            }
        }
    }
}
