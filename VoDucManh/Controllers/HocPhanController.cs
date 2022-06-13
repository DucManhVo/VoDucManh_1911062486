using VoDucManh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoDucManh.Controllers
{
    public class HocPhanController : Controller
    {
        // GET: HocPhan
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_hocphan = from tt in data.HocPhans select tt;
            return View(all_hocphan);
        }
    }
}
