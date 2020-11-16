using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static List<SinhVien> DanhSachSinhVien = new List<SinhVien>();

        public static void menu()
        {
            Console.WriteLine("***   MENU   ***");
            Console.WriteLine("1. Xem danh sach sinh vien");
            Console.WriteLine("2. Them sinh vien");
            Console.WriteLine("3. Tim sinh vien");
            Console.WriteLine("4. Cap nhat thong tin sinh vien");
            Console.WriteLine("5. Thoát");
        }

        public static void InDanhSachSinhVien()
        {
            
            Console.WriteLine("Danh sach sinh vien");
            foreach (var sv in DanhSachSinhVien)
            {
                sv.XemThongTin(sv);
                Console.WriteLine();
            }
        }

        public static SinhVien TimSinhVien(string maSV)
        {
            SinhVien result = null;
            foreach(var sv in DanhSachSinhVien)
            {
                if (maSV == sv.MaSV)
                {
                    result = sv;
                }
            }
            return result;
        }

        public static void CapNhatThongTin(string maSV)
        {
            SinhVien sv = TimSinhVien(maSV);
            if (sv != null)
            {
                Console.WriteLine("Ma sinh vien: " + sv.MaSV);
                Console.WriteLine("Nhap ho ten sinh vien: ");
                sv.MaSV = Console.ReadLine();
                Console.WriteLine("Nhap ngay sinh: ");
                sv.HoTen = Console.ReadLine();
                Console.WriteLine("Nhap dia chi: ");
                sv.DiaChi = Console.ReadLine();
                Console.WriteLine("Nhap dien thoai: ");
                sv.DienThoai = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ma " + maSV);
            }
        }

        public static void ThemSinhVien(string MaSV, string HoTen, DateTime NgaySinh, string DiaChi, string DienThoai)
        {
            SinhVien sv = TimSinhVien(MaSV);
            if(sv == null)
            {
                DanhSachSinhVien.Add(new SinhVien(MaSV, HoTen, NgaySinh, DiaChi, DienThoai));
                //return true;
            }
            //return false;
        }

        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();

            string MaSV = null;
            string Hoten = null;
            DateTime NgaySinh = Convert.ToDateTime(null);
            string DiaChi = null;
            string DienThoai = null;
            int choice = 0;

            do
            {
                menu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InDanhSachSinhVien();
                        break;
                    case 2:
                        Console.WriteLine("Nhap ma sinh vien: ");
                        MaSV = Console.ReadLine();
                        Console.WriteLine("Nhap ho ten sinh vien: ");
                        Hoten = Console.ReadLine();
                        Console.WriteLine("Nhap ngay sinh sinh vien: ");
                        NgaySinh = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Nhap dia chi sinh vien: ");
                        DiaChi = Console.ReadLine();
                        Console.WriteLine("Nhap dien thoai sinh vien: ");
                        DienThoai = Console.ReadLine();
                        ThemSinhVien(MaSV, Hoten, NgaySinh, DiaChi, DienThoai);
                        break;
                    case 3:
                        Console.WriteLine("Nhap ma sinh vien can tim: ");
                        MaSV = Console.ReadLine();
                        sv = TimSinhVien(MaSV);
                        if (sv == null)
                        {
                            Console.WriteLine("Khong tim thay sinh vien co ma " + MaSV);
                        }
                        else
                        {
                            sv.XemThongTin(sv);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap ma sinh vien can cap nhat: ");
                        MaSV = Console.ReadLine();
                        CapNhatThongTin(MaSV);
                        break;
                }

            } while (choice >= 1 && choice <= 4);
        }
    }
}
