namespace B1_KhaiBaoBien
{
    /*
     Comment 1 đoạn văn : ctrl + shift + /
     Biến là 1 đơn vị dữ liệu, khi khai báo sẽ lưu trữ dữ liệu tạm thời ở 1 vùng nhớ trong ram
     Cú pháp: <kiểu dữ liệu> <tên biến> (=)(giá trị khởi tạo);
     Kiểu dữ liệu:
     +Kiểu số:
        +Số nguyên int(32 bit), long(64bit), short(16bit),byte(255 so nguyen)
        +Số nguyên không dấu: uint(usigned),ulong,...
        +Số thập phân có dấu phẩy: float, double, decimal...
     Kiểu kí tự và chuỗi:
      char: 1 kí tự
      char[]:<=> string: chuỗi kí tự
     + Kiểu Logic: boolean
       -bool: true/ false;
     +Kiểu đối tượng: class
     + Kiểu động: dynamic

    //Biến:
    + Biến không ở trong hàm nào, ở trong class thì sẽ gọi là biến toàn cục (golobal)
    + Biến nằm trong hàm, hoặc 1 khối lệnh thì sẽ gọi là biến địa phương(cục bộ)(Local)
    Quy tắc đặt tên biến:
    +Đặt tên có ý nghĩa
    +Tên không được bắt đầu bằng số, hoặc các ký tự đặc biệt khác _;
    +Biến nên được đặt theo phong cách lạc đà (camel case) hoặc là viết thường hẳn: VD: soNguyen; songuyen; so_nguyen (kiểu rắn)
    +Biến toàn cục thì nên có _ ở trước;
    +

     */

    internal class Program
    {
        static int _soNguyen = -3; // mặc định truy cập trong class
        static void Main(string[] args)
        {
            double soThuc = 3.5; // chỉ sử dụng được trong hàm hoặc khối code
            Console.WriteLine("Hello, World!" + _soNguyen); 
        }

        static void InSoThuc()
        {
            Console.WriteLine(_soNguyen); // cw+ tab+tab
        }
    }
}
