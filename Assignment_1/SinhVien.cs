using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SinhVien
    {
        private string mMaSV;
        private string mHoTen;
        private DateTime mNgaySinh;
        private string mDiaChi;
        private string mDienThoai;

        public string DienThoai
        {
            get { return mDienThoai; }
            set { mDienThoai = value; }
        }


        public string DiaChi
        {
            get { return mDiaChi; }
            set { mDiaChi = value; }
        }


        public DateTime NgaySinh
        {
            get { return mNgaySinh; }
            set { mNgaySinh = value; }
        }


        public string HoTen
        {
            get { return mHoTen; }
            set { mHoTen = value; }
        }


        public string MaSV
        {
            get { return mMaSV; }
            set { mMaSV = value; }
        }


        public SinhVien()
        {
            mMaSV = null;
            HoTen = null;
            NgaySinh = Convert.ToDateTime(null);
            DiaChi = null;
            DienThoai = null;
        }

        public SinhVien (string masv, string hoten, DateTime ngaysinh,
            string diachi, string dienthoai)
        {
            this.mMaSV = masv;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
        }

        public void XemThongTin(SinhVien sinhvien)
        {
            Console.WriteLine("Ma Sinh Vien: " + sinhvien.MaSV);
            Console.WriteLine("Ho ten Sinh Vien: " + sinhvien.HoTen);
            Console.WriteLine("Ngay sinh: " + sinhvien.NgaySinh);
            Console.WriteLine("Dia chi: " + sinhvien.DiaChi);
            Console.WriteLine("Dien thoai: " + sinhvien.DienThoai);
        }
    }
}
