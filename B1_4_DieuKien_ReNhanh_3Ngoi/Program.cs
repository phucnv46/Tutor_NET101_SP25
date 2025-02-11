namespace B1_4_DieuKien_ReNhanh_3Ngoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Điều kiện : If(Đk), Else if(ĐK), Else{}

            // tổ hợp phím nhanh if+tab:

            if (true) { Console.WriteLine("Đk đúng"); } // nếu điều kiện đúng thì thực hiện code bên trong
            else if (true) { Console.WriteLine("Xem if đã thoả mãn chưa, rồi mới được xét điều kiện"); }
            else { Console.WriteLine("Khi mà các đk if, else if không thoả mãn thì sẽ chạy logic của else"); }


            // Câu lệnh rẽ nhánh <=> rẽ nhánh theo lựa chọn, và điều kiện, tương đương với if(đk==gt)
            // ứng dụng hay được dùng làm menu lựa chọn
            // switch : 
            //sw + tab

            int choice = int.Parse(Console.ReadLine());
            switch (choice) // Điều kiện lựa chọn
            {
                default: { Console.WriteLine("Không có lựa chọn này"); break; } // không thuộc các trường hợp nào cả
                case 1: { Console.WriteLine("In ra lựa chon 1"); break; } // Break: ngắt khối code
                //...
            }

            // Toán tử 3 ngôi 

            int a = 5;
            int b = a == 5 ? a : 0;
            //Đk ? nếu đúng thì : nếu sai thì  
            Console.WriteLine(b);


            //Bài luyện tập
   /*         Bài 1: Tạo 1 menu gồm các chức năng sau. Menu chỉ dừng lại khi chọn 0.
1.Nhập vào số nguyên dương. Kiểm tra xem đó là số chẵn hay lẻ
2.Nhập vào số n.Tính tổng các số lẻ từ 1 tới n
3.Nhập vào số n.Tính tích các số chẵn từ 1 tới n
     0.Thoát

Bài 2: Tạo 1 menu gồm các chức năng sau. Menu chỉ dừng lại khi chọn 0.
1.Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n.
2.Nhập thông tin gồm tên, tuổi, địa chỉ, điểm, trường học của bản thân và in ra.
3.Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.
4.Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.
5.Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.
     0.Thoát*/
/**/
        }
    }
}
