using System.Collections;

namespace B3_TapHop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mảng: là tập hơp các kiểu dư liệu cùng loại:
            // Có giới hạn số lượng phần tử: khó mở rộng, tương tác
            // Truy cập tuân tự, theo index

            // Kiểu danh sách: tương tự mảng: tập hợp các dữ liệu cùng loại
            // Nhưng không giới hạn số lượng phần tử
            // Có nhiều phương thức hỗ trợ
            // Cú pháp : List<kiểu dữ liệu> tên danh sách = new List<Kiểu dữ liệu>() // khai báo như tạo object

            List<string> words = new List<string>() { "Cộng", "Hoà", "Xã", "Hội" };
            //Thêm 1 phần tử mới vào list
            words.AddRange(new List<string>() { "Chủ", "Nghĩa", "Việt", "Nam" });

            words.RemoveAt(0); // Cong
            words.Remove("Hoà");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Truy cập phần tử
            // truy cập như mảng

            Console.WriteLine($"{words[6]} {words[7]}");

            //Arraylist <=> List<object>
            // Tập hơp các dữ liệu có thể không cùng loại

            ArrayList honTap = new ArrayList() { 1, "phuc", 2.5 };

            //Kiểu từ điển : Tập hợp theo phương thức chứa các cặp dữ liệu <string,int>

            Dictionary<string, string> maGVs = new Dictionary<string, string>() { {
                    "phucnv","Nguyễn Văn Phúc"
                } };

            /*
             Các class mô tả thực thể: Class thực thể, class chuyên phục vũ logic: class Logic (Thường không có thuộc tính)

            Bài tập:
            Tạo class NhanVat có các thuộc tính:
            Id: int/ string (Guid)
            Ten: string
            He: string
            MauToiDa: double
            Mana: double
            (... các chỉ số khác)
            phương thức: InThongTin(): void => In ra thông tin của nhân vật

            Đầy đủ constructor có và không tham số

            Tạo class Logic: xử lý logic
            biến global là List<NhanVat>
            Có các hàm sử lý logic để thực hiện các chức năng sau: 
            Thêm 1 NhanVat vào list, Tìm NhanVat theo mã, Xoá NhanVat theo mã



             
             */
        }
    }
}
