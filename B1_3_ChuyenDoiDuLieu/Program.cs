namespace B1_3_ChuyenDoiDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //Chuyển đổi là chuyển kiểu dữ liệu này sang 1 kiểu dữ liệu khác
            // Chuyển đổi ngầm định (Máy chuyển đổi cho mình)
            // Ép kiểu (casting)(coverting)

            double soThuc = 3.54;
            int SoNguyen =(int) soThuc; // Casting
            Console.WriteLine(SoNguyen+$"Kiểu của số nguyên {SoNguyen.GetType()}");//In ra kiểu của biến

            //Nhập dữ liệu từ bàn phím và chuyển đổi sang dạng mong muốn
            //C1: Parse();
            SoNguyen = int.Parse(Console.ReadLine()); // Đổi string từ bàn phím sang int()
            //C2// Convert
            soThuc = Convert.ToDouble(Console.ReadLine());
            // Dùng 2 cách trên có thể gây ra lỗi nếu không đúng định dạng VD: 3fas => lỗi
            //C3: TryParse(); áp dụng cho biến đã được khởi tạo
            int.TryParse(Console.ReadLine(), out SoNguyen); // Nếu lỗi thì sẽ gán với giá trị mặc định (0)
            

        }
    }
}
