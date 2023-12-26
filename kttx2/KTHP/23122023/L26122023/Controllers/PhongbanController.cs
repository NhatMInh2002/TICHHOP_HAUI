using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using L26122023.Models;

namespace L26122023.Controllers
{
    public class PhongbanController : ApiController
    {
        QLNVEntities db = new QLNVEntities();
        [HttpGet]
        public IEnumerable<PhongBan> getALL()
        {
            IEnumerable<PhongBan> querry = db.PhongBans;
            return querry;
        }
        [HttpPost]
        public bool ThemPhong(string ma, string ten)
        {
            PhongBan pb = db.PhongBans.FirstOrDefault(x => x.MaPhong == ma);
            if (pb == null)
            {
                PhongBan pb1 = new PhongBan();
                pb1.MaPhong = ma;
                pb1.TenPhong = ten;
                db.PhongBans.Add(pb1);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
