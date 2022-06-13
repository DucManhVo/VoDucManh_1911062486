using VoDucManh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoDucManh.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        MyDataDataContext data = new MyDataDataContext();
        [HttpGet]
        // GET: NguoiDung
        public ActionResult Dangnhap()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var E_masv = collection["MaSV"];

            SinhVien s = data.SinhViens.SingleOrDefault(n => n.MaSV == E_masv);
            if (s != null)
            {
                ViewBag.ThongBao = "Chuc mung dang nhap thanh cong";
                Session["TaiKhoan"] = s;
            }
            else
            {
                ViewBag.ThongBao = "Sai ma sinh vien";

            }
            return RedirectToAction("Index", "HocPhan");

        }

    }
}