using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using taowebapi.Models;


namespace taowebapi.Controllers
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
        [HttpGet]
        public SanPham laysptheoma(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            return sp;
        }
        [HttpGet]
        public IEnumerable<SanPham> laysptheomadm(int madm)
        {
            IEnumerable<SanPham> query = db.SanPhams.Where(x => x.MaDanhMuc == madm);
            return query;
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
        public bool capnhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp != null)
            {
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool xoa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
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
