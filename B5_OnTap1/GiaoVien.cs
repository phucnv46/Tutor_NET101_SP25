using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace B5_OnTap1
{
    internal class GiaoVien // Tạo class, các thuộc tính Full Property
    {
        //c1: tạo field rồi alt + enter chọn 
        private int _id; // alt + enter, chọn encapsulate field


        //c2: propf + tab +tab
        // nên trình bày theo 1 cách nhất định
        private string _ten;
        private double soGioDay;

        public GiaoVien()
        {
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        //c3: viết auto property rồi chuyển sang full property
        // prop + tab 
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }
        public int Id { get => _id; set => _id = value; }

        // Tạo full property

        internal virtual void InThongTin() // Vẫn viết kiểu passcal
        {
            Console.Write($"Id: {Id}, Ten: {Ten}, {soGioDay}");
           // Console.WriteLine(JsonSerializer.Serialize(this));
        }

        public GiaoVien(int id, string ten, double soGioDay)
        {
            Id = id;
            Ten = ten;
            SoGioDay = soGioDay;
        }

        //Alt + enter => generate constructor

        // Đối với constructor có tham số: chọn hết field(khối xanh) hoặc Property (cờ lê) 1 trong 2 loại thôi




    }
}
