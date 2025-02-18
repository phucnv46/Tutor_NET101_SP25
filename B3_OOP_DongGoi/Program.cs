using System.Text;

namespace B3_OOP_DongGoi
{
    internal class Program
    {
        /*
         ctrl + shift + /
          OOP: Objects orient programing: Lập trình hướng đối tượng
         Lập trình hướng đối tượng: Là cách, kiểu lập trình sẽ chuyển các cái thực thể
        (sự vật, hiện tượng mà cần quan tâm ở bài toán)
        của bài toán ngoài đời thành các lớp, các đối tượng để sử lý trong code
        VD: Quản lý sinh viên: 
        Thực thể: SinhVien, MonHoc,Lop,...
        Chuyển thành code: Thực thể => class : để mô tả, 
        đối tượng (object) : Thể hiện của thể của class,
        biến đặc biệt mang theo đặc trưng của class
        VD: SinhVien hung = new SinhVien() ; hung sẽ mang các đặc trưng của class Sinh Viên

        Class: Thông tin(Tính chất) -> Thuộc tính (Properties)
        Hành vi ( hành động) : Hàm -> Phương thức (method)

        --Đóng gói:
        + Giúp truy cập, đặt hạn chế truy cập cho các class và object
        --Các phạm vi truy cập:
        + public : Có thể truy cập ở mọi nơi, kể cả khác project
        + internal: Có thể truy cập trong cùng 1 assembly (project)
        + protected: Có thể truy cập từ các lớp con, các lớp dẫn xuất
        + private: Chỉ có thể truy cập 1 class
        Nếu mà không khai báo pham vi truy cập là gì thì sẽ mặc định là private



         */
        static void Main(string[] args)
        {
            // Tạo object 
            // Cú pháp :<Class> tên object = new <Constructor>

            Console.OutputEncoding = Encoding.UTF8;
            GiangVien phuc = new GiangVien() { Name = "phuc" };
            phuc.ID = "Phucnv46";
            GiangVien huy = new GiangVien("huynq2","Huy");
            // Để gọi thuộc tính, hoặc phương thức ta dùng .

            Console.WriteLine(phuc.ID+" " +phuc.Name);
            Console.WriteLine(huy.ID+ " " + huy.Name);

            //Gọi phương thức:
            phuc.LenLop();
        }
    }

    // Khong khuyến khích trình bày nhiều class trong cùng 1 file
    internal class Demo
    {

    }
}
