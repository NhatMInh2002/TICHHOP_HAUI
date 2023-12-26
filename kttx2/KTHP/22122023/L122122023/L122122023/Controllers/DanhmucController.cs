using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using L122122023.Models;

namespace L122122023.Controllers
{
    public class DanhmucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]
        public IEnumerable<DanhMuc> LayDM()
        {
            IEnumerable<DanhMuc> querry = db.DanhMucs;
            return querry;
        }

    }
}
