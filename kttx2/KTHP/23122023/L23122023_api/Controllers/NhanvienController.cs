using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using L23122023_api.Models;

namespace L23122023_api.Controllers
{
    public class NhanvienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();

        [HttpGet]
        public IEnumerable<Nhanvien> LayNV()
        {
            IEnumerable<Nhanvien> querry = db.Nhanviens;
            return querry; 
        }
        [HttpPost]
        public bool ThemNV(string ma, string ten, string trinhdo, int luong)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if(nv == null)
            {
                Nhanvien nv1 = new Nhanvien();
                nv1.MaNV = ma;
                nv1.HoTen = ten;
                nv1.TrinhDo = trinhdo;
                nv1.Luong = luong;
                db.Nhanviens.Add(nv1);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool SuaNV(string ma, string ten, string trinhdo, int luong)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                
                nv.MaNV = ma;
                nv.HoTen = ten;
                nv.TrinhDo = trinhdo;
                nv.Luong = luong;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool XoaNV(string ma)
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
