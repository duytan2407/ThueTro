using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThueTro.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace ThueTro.Controllers
{
    public class NhaTroController : Controller
    {
        public readonly ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        // GET: NhaTro
        public ActionResult Index(int ?page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(db.NhaTros.ToList().OrderBy(n => n.IDNha).ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        // GET: NhaTro/Details/5
        public ActionResult Details(int id)
        {
            NhaTro nt = db.NhaTros.SingleOrDefault(n => n.IDNha == id);
            ViewBag.IDNha = nt.IDNha;
            if(nt == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(nt);
        }
        [HttpGet]
        // GET: NhaTro/Create
        public ActionResult Create()
        {
            //ViewBag.IDQuan = new SelectList(db.DiaDiems.ToList().OrderBy(n => n.TenQuan), "IDQuan", "TenQuan");
            //var nt = new NhaTro
            //{
            //    DiaDiems = db.DiaDiems.ToList()
            //};
            ViewBag.DiaDiemIdQuan = new SelectList(db.DiaDiems, "IDQuan", "TenQuan");
            return View();
        }

        // POST: NhaTro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(NhaTro nhatro, HttpPostedFileBase anh)
        {
            ViewBag.DiaDiemIdQuan = new SelectList(db.DiaDiems, "IDQuan", "TenQuan");
            if (anh == null)
            {
                ViewBag.Thongbao = "Bạn chưa chọn ảnh";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(anh.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/HinhAnh/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        anh.SaveAs(path);
                    }
                    nhatro.image = fileName;
                    db.NhaTros.Add(nhatro);
                    db.SaveChanges();                    
                }               
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        // GET: NhaTro/Edit/5
        public ActionResult Edit(int? id, bool? saveChangesError = false)
        {
            NhaTro nt = db.NhaTros.Find(id);            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }                        
            if (nt == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiaDiemIdQuan = new SelectList(db.DiaDiems, "IDQuan", "TenQuan", nt.DiaDiemIdQuan);
            return View(nt);     
        }

        // POST: NhaTro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]       
        public ActionResult Edit(NhaTro nhatro, HttpPostedFileBase fileUpload)
        {
            ViewBag.DiaDiemIdQuan = new SelectList(db.DiaDiems, "IDQuan", "TenQuan");
            //if(fileUpload != null)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        var fileName = Path.GetFileName(fileUpload.FileName);
            //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnh/"), fileName);
            //        if (System.IO.File.Exists(path))
            //        {
            //            ViewBag.Thongbao = "Hình ảnh đã tồn tại";
            //        }
            //        else
            //        {
            //            fileUpload.SaveAs(path);
            //        }
            //        nhatro.image = fileName;
                    db.Entry(nhatro).State = EntityState.Modified;
                    db.SaveChanges();
                //}
                return RedirectToAction("Index");
            //}
            //else
            //{
            //    ViewBag.Thongbao = "Bạn chưa chọn ảnh";
            //    return View();
            //}
        }
        [HttpGet]
        // GET: NhaTro/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaTro nt = db.NhaTros.Find(id);
            if (nt == null)
            {
                return HttpNotFound();
            }
            return View(nt);
        }

        // POST: NhaTro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
                NhaTro nt = db.NhaTros.SingleOrDefault(n => n.IDNha == id);
                ViewBag.IDNha = nt.IDNha;
                if (nt == null)
                {
                    return HttpNotFound();
                }
                db.NhaTros.Remove(nt);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
