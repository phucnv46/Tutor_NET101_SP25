namespace B4_OOP_KeThua
{
    internal class Program
    {

     /*
      OOP: Class(lớp), object(đối tượng) : Tính chất đóng gói
      object : được tạo bởi toán tử new và constructor 
       Class: các trường thông tin, và cách thức truy cập trường thông tin(get;set;)=>thuộc tính
       +Các hàm biểu diễn hành vi, khả năng của lớp là phương thức (method)
       + Có những lớp biểu diễn thực thể => lớp thực thể 
       +Có những lớp chuyên dùng để xử lý logic => lớp logic (thường hay sử dụng các phương thức static)
       +static => có thể truy cập hàm mà không cần tạo object

      */
       /* 1 trong 4 tính chất của lập trình hướng đối tượng: Đóng gói, Kế thừa
        Kế thừa: Giúp cho class có thể kế thừa (tái sử dụng) /mở rộng các thuộc tính, và phương thức từ class khác
        Lớp kế thừa được gọi là class cha,lớp được kế thừa: class con
        
        Cú pháp: để kế thừa ta sử dụng ":" và gọi tên class muốn kế thừa
        class XeMay : PhuongTien 

        */

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Math.Cos(32); // phương thức static có thể gọi mà ko cần tạo  object
            PhuongTien xeMay = new XeMay(); // Các bạn làm việc với interface : IEnumrable,ICollection
            xeMay.DiChuyen();
        }
    }
}
