using System;

namespace CacLoaiPhamVi
{
    class SinhVien
    {
        private string MASV;
        private string HoTen;
        private double diemToan; // Crtl + Alt + .
        private double diemVan;
        private double diemLy;


        // Thong tin mac dinh
        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }


        // Thong tin mac dinh
        public double DiemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }


        // VD neu thay doi thong tin
        public double DiemLy
        {
            get { return diemLy; }
            set
            {
                if (value <= 10 || value >= 0)
                {
                    diemLy = value;
                }
            }
        }



        //  Đây là phương thức truy vấn giá trị của thuộc tính MASV
        //  Vì thế phương thức sẽ trả về string (trùng với kiểu dữ liệu của thuộc tính MASV)
        public string getMASV()
        {
            return MASV;
        }



        //  Đây là phương thức cập nhật giá trị cho thuộc tính diemToan
        //  Vì thế phương thức có 1 tham số truyển vào kiểu double trùng với kiểu thuộc tính diemToan
        public void setDiemToan(int DT)
        {
            diemToan = DT;
        }



        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;

            Console.WriteLine($"Sinh viên ${HoTen} có điểm trung bình là {DTB}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.DiemLy = 8.25;

            Console.WriteLine($"Điểm lý: {sv.DiemLy}");
        }
    }
}