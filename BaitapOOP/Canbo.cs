using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapOOP
{
    public class Canbo
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public void In()
        {
            Console.WriteLine("Id: {0} -- HoTen: {1}-- Tuoi: {2}-- GioiTinh: {3}-- DiaChi: {4}", Id, HoTen, Tuoi, GioiTinh, DiaChi);
        }

    }
}
