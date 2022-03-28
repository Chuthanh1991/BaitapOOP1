using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapOOP
{
    public class QuanLyCanBo
    {
        ArrayList CB = new ArrayList();
        public void Add(Canbo C)
        {
            CB.Add(C);
        }
        public void Delete (int id)
        {
            Canbo canbo = new Canbo();
            foreach (Canbo C in CB)
            {
                if (id == C.Id)
                {
                    canbo = C; 
                }
            }
            CB.Remove(canbo);
        }
        public void Update(int id, string hoTen, int tuoi, string gioiTinh, string diaChi)
        {
            foreach (Canbo C in CB)
            {
                if (C.Id == id)
                {
                    C.HoTen = hoTen;
                    C.Tuoi = tuoi;
                    C.GioiTinh = gioiTinh;
                    C.DiaChi = diaChi;
                }
            }
        }
        public Canbo Search(int id)
        {
            Canbo canbo = new Canbo();
            foreach (Canbo C in CB)
            {
                if(C.Id ==id)
                {
                    canbo = C;
                }
            }
            return canbo; 
        }
        public void hienthi()
        {
            foreach (Canbo C in CB)
            {
                    C.In();
            }
        }
    }
}
