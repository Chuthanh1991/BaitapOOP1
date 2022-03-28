using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyCanBo quanLyCanBo = new QuanLyCanBo();
            int id, tuoi;
            string hoTen, diaChi, gioiTinh;
            do
            {
                Console.WriteLine("1. THÊM");
                Console.WriteLine("2. XOÁ");
                Console.WriteLine("3. CẬP NHẬT");
                Console.WriteLine("4. TÌM KIẾM");
                Console.WriteLine("5. HIỆN THỊ DANH SÁCH");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Nhap ID Can Bo:");
                        id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Ho Ten Can Bo:");
                        hoTen =Console.ReadLine();
                        Console.WriteLine("Nhap Tuoi Can Bo:");
                        tuoi = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Dia chi Can Bo:");
                        diaChi = Console.ReadLine();
                        Console.WriteLine("Nhap Gioi tinh Can Bo:");
                        gioiTinh = Console.ReadLine();
                        Canbo canbo = new Canbo();
                        canbo.Id = id;
                        canbo.HoTen = hoTen;
                        canbo.Tuoi = tuoi;
                        canbo.DiaChi = diaChi;
                        canbo.GioiTinh = gioiTinh;
                        quanLyCanBo.Add(canbo);
                        break;
                    case "2":
                        Console.WriteLine("Nhap ID Can Bo:");
                        id = Int32.Parse(Console.ReadLine());
                        quanLyCanBo.Delete(id); 
                        break;
                    case "3":
                        Console.WriteLine("Nhap ID Can Bo:");
                        id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Ho Ten Can Bo:");
                        hoTen = Console.ReadLine();
                        Console.WriteLine("Nhap Tuoi Can Bo:");
                        tuoi = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Dia chi Can Bo:");
                        diaChi = Console.ReadLine();
                        Console.WriteLine("Nhap Gioi tinh Can Bo:");
                        gioiTinh = Console.ReadLine();
                        quanLyCanBo.Update(id, hoTen, tuoi, gioiTinh, diaChi);
                        break;
                    case "4":
                        Console.WriteLine("Nhap ID Can Bo:");
                        id = Int32.Parse(Console.ReadLine());
                        quanLyCanBo.Search(id);
                        break;
                    case "5":
                        quanLyCanBo.hienthi();
                        break;
                }
            } while (true);
           
        }
    }
}
