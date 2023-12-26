using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using L26122023.Models;

namespace L26122023.Controllers
{
    public class NhanvienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();
        [HttpGet]
        public IEnumerable<Nhanvien> GetALL()
        {
            IEnumerable<Nhanvien> querry = db.Nhanviens;
            return querry;
        }
        public IEnumerable<Nhanvien> GetNVbyId(string map)
        {
            IEnumerable<Nhanvien> querry = db.Nhanviens.Where(x=>x.MaPhong == map);
            return querry;
        }


        [HttpPost]
        public bool AddNV(string ma, string ten, decimal luong, string map)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv == null)
            {
                Nhanvien nv1 = new Nhanvien();
                nv1.MaNV = ma;
                nv1.TenNV = ten;
                nv1.Luong = luong;
                nv1.MaPhong = map;
                db.Nhanviens.Add(nv1);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool UpNV(string ma, string ten, decimal luong, string map)
        {
            Nhanvien nv1 = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv1 != null)
            {
                nv1.MaNV = ma;
                nv1.TenNV = ten;
                nv1.Luong = luong;
                nv1.MaPhong = map;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool DelNV(string ma)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                db.Nhanviens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
