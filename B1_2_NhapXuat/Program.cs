using System.Text;

namespace B1_2_NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Alt+enter để gợi ý code, ctrl+space
            //Xuất dữ liệu
            Console.WriteLine("Hello, World!");
            // In ra Hello, world bằng Console.WriteLine(Chuoi muon in ra);
            // tổ hợp phím nhanh : cw+ tab+tab
            Console.Write("");// Bắt buộc phải có truyền vào
            // Console.WriteLine() <=> Console.Write("\n");
            //Console.WriteLine() in xong rồi tự động xuống dòng

            //Nhập dữ liệu từ bàn phím
            //Console.Read(); // Đọc kí tự ASCII
            //Console.ReadKey(); // Chỉ đọc 1 phím các bạn nhập vào
            Console.Write("Xin moi nhập 1 dòng kí tự: ");
            string input= Console.ReadLine(); // Đọc 1 dòng từ bàn phím
            // 1 dòng tương đương với khi nhập chuỗi kí tự và kết thúc bằng enter(\n)
            // Console.ReadLine() luôn trả về kiểu dữ liệu string, khi muốn người dùng nhập
            // các kiểu dữ liệu khác thì phải quy đổi
            Console.WriteLine("Bạn vừa nhập là: " + input);// adding chuỗi
            Console.WriteLine($"Bạn vừa nhập là: {input}");// Interpolar string sử dụng dấu $ trước chuỗi
            Console.WriteLine("Bạn vừa nhập vào là {0}", input); // vị trí biến bắt đầu luôn là {0}


             
        }
    }
}
