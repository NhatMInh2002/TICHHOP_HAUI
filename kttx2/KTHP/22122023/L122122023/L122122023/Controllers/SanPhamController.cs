using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using L122122023.Models;

namespace L122122023.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();


        [HttpGet]
        public IEnumerable<SanPham> LaySP()
        {
            IEnumerable<SanPham> querry = db.SanPhams;
            return querry;
        }

        [HttpPost]
        public bool Themsp(int masp, string ten, int dongia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if (sp == null)
            {
                SanPham sp1 = new SanPham();
                sp1.Ma = masp;
                sp1.Ten = ten;
                sp1.DonGia = dongia;
                sp1.MaDanhMuc = madm;
                db.SanPhams.Add(sp1);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool Sua(int masp, string ten, int dongia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if (sp != null)
            {
                sp.Ma = masp;
                sp.Ten = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madm;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        [HttpDelete]
        public bool Xoa(int id)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == id);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

