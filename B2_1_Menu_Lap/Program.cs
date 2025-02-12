namespace B2_1_Menu_Lap
{
    internal class Program
    {

        //Menu: Danh sách các chức năng; lựa chọn sẽ thực hiện chức năng; lặp đi lặp lại chỉ dừng khi chọn thoát;
        // Các thành phần của menu: In chức năng, biến lựa chọn, vòng lặp, switch-case (giúp chọn đúng chức năng)...



        /* Bài 2: Tạo 1 menu gồm các chức năng sau.Menu chỉ dừng lại khi chọn 0.
 1.Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n.
 2.Nhập thông tin gồm tên, tuổi, địa chỉ, điểm, trường học của bản thân và in ra.
 3.Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.
 4.Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.
 5.Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.
      0.Thoát*
 /**/
        static void Main(string[] args)
        {
            // C1: Lặp menu, và chỉ dừng lại khi người dùng chọn thoát;
            //C2: Lặp menu khi người chưa chọn thoát;
            // C3: không khuyến khích: sử dụng lable, go-to

            //C1:

            int luaChon; // biến lựa chọn 
            while (true) // rủi ro nếu không code trường hợp thoát
            {
                Console.WriteLine("1.Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n." +
                    "\r\n2.Nhập thông tin gồm tên, tuổi, địa chỉ, điểm, trường học của bản thân và in ra." +
                    "\r\n3.Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.\r\n" +
                    "4.Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.\r\n" +
                    "5.Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.\r\n" +
                    " 0.Thoát"); // in chức năng

                Console.Write("Xin mời chọn chưc năng: ");
                // luaChon= Convert.ToInt32(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out luaChon); // cho người dùng nhập lựa chọn từ bàn phím

                switch (luaChon)
                {
                    case 0:
                        return;
                    //  Environment.Exit(0);break;
                    default: Console.WriteLine("Lựa chọn sai");  ; break;
                    case 1: break; // cho chức năng 1
                    case 2:  break; // cho chức năng 2
                        //...

                }


                //C2: 
                do
                {
                    Console.WriteLine("1.Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n." +
                    "\r\n2.Nhập thông tin gồm tên, tuổi, địa chỉ, điểm, trường học của bản thân và in ra." +
                    "\r\n3.Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.\r\n" +
                    "4.Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.\r\n" +
                    "5.Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.\r\n" +
                    " 0.Thoát"); // in chức năng

                    Console.Write("Xin mời chọn chưc năng: ");
                    // luaChon= Convert.ToInt32(Console.ReadLine());
                    int.TryParse(Console.ReadLine(), out luaChon); // cho người dùng nhập lựa chọn từ bàn phím

                    switch (luaChon)
                    {
                        case 0:
                            return;
                        //  Environment.Exit(0);break;
                        default: Console.WriteLine("Lựa chọn sai"); ; break;
                        case 1: break; // cho chức năng 1
                        case 2: break; // cho chức năng 2
                                       //...

                    }
                }
                while (luaChon ==0);

                //C3: Không khuyến khích:

                menu: Console.WriteLine("1.Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n." +
                   "\r\n2.Nhập thông tin gồm tên, tuổi, địa chỉ, điểm, trường học của bản thân và in ra." +
                   "\r\n3.Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.\r\n" +
                   "4.Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.\r\n" +
                   "5.Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.\r\n" +
                   " 0.Thoát");
                int luachon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 0: return; // kết thúc
                    case 1: //gọi code chức năng, sau khi thực hiện song code , sử dụng go to quay trở lại menu:
                        goto menu; 
                  
                }

            }
        }
    }
}
