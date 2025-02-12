using System.Text;

namespace B2_VongLap
{
    /* Cmt đoạn văn : ctrl +shift+ /
     Vòng lặp: thực hiện lặp lại 1 dòng hoặc 1 khối code theo điều kiện chỉ định, và có thể kiểm 
    soát lúc kết thúc, số lần lặp
      Các loại vòng lặp:
     while(Điều kiện)
    {
    code
    }
    Thực hiện khi mà điều kiện đúng, gán đk = true thì vòng lặp sẽ vô tận, quy trình thực hiện
    -Kiểm tra điều kiện, nếu điều kiện đúng => lặp
    VD int soNguyen = 5;
    int a = 1;
    while(a<5) // vòng lặp sẽ kết thúc khi a = 5 điều kiện không thoả mạn
    {
       a=a+1 ; (a++)
       
    }

     do
    {
    code...
    }
    while(điều kiên);
    - Thực hiện code trong do trước rồi mới kiểm tra, chắc chắc chạy code ít nhất 1 lần, dùng cho 
    đến khi điều kiện không còn đúng


    --for( <Kiểu dữ liệu> giá trị khởi đầu ; Điều kiện kết thúc ; giá trị tính tiến   ) 
    {
      code (phần được lặp);
    } 
    -Dễ dàng kiểm soát được số lượng lần lặp, và thường dùng cho kiểu số

    Vd: for(int a = 0; a < 5; a++)
    {
    code
    }
    Kiểm soát được vòng lặp lặp 5 lần từ 0 - 4;
    Ngoài ra còn hay được sử dụng cho truy cập mảng bằng chỉ số (index)

    phím tắt: for + tab

    var : kiểu dữ liệu sẽ bằng đối số tương ứng ( kiểu dữ liệu của giá trị gán), Chỉ sử dụng được ở trong hàm
    --foreach(<kiểu dữ liệu> tenbienTp : tenTaphop)
    {
      code
    }

    --Duyệt mỗi, (toàn bộ từng phần tử của tập hợp)...

    --Mảng:
     Tập hợp (số lượng lớn) các biến cùng loại dữ liệu
    VD thay vì khai báo 10 biến int ta có thể tạo ra mảng chưa 10 phần tử int
    Cú pháp: <kiểu dữ liệu>[] <tên mảng> = {các phần tử} (slpt sẽ bằng phần tử khởi tạo)
    C2:       <kiểu dữ liệu>[] <tên mảng> = new <kiểu dữ liệu>[slpt]; (cung cấp 1 mảng trống có slpt tương ứng)        






     */
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8 ;
            var a = 1;
            int soNguyen = 5;
            Console.WriteLine("Sử dụng while:");
            while (a< soNguyen)
            {
                Console.WriteLine(a);
                a++;
            }

            a = 1;
            Console.WriteLine("Sử dụng do while: "); 
            do // Thực hiện code trước kiểm tra điều kiện sau
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < soNguyen);


            /* for (; ; ) // while(true) lặp vô tận
             {

             }*/

            Console.WriteLine("Sử dụng for: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            double[] reals = {2.4,5,-9,23,5,1};

            // Duyệt mảng bằng for
            Console.Write("Duyệt mảng bằng for {2.4,5,-9,23,5,1}: ");
            for (int i = 0; i < reals.Length; i++)
            {
                Console.Write(reals[i] + " ");
            }
            Console.WriteLine();
            //Duyệt mảng bằng foreach
            Console.Write("Duyệt mảng bằng foreach {2.4,5,-9,23,5,1}: ");
            foreach (var real in reals)
            {
                Console.Write(real+ " ");
            }

        }
    }
}
