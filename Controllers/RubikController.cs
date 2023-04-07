using LAB02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB02.Controllers
{
    public class RubikController : Controller
    {
        private List<Rubik> listRubik;
        public RubikController()
        {
            listRubik = new List<Rubik>();
            listRubik.Add(new Rubik()
            {
                Id = 1,
                Ten = "Rubik 1",
                Loai = "3x3",
                MoTa = "Best Saler",
                Hang = "Rubik VN",
                Gia = 30000,
                Hinh = "Content/image/Rubik1.jpg",
                SoLgTon = 20
            });

            listRubik.Add(new Rubik()
            {
                Id = 2,
                Ten = "Rubik 2",
                Loai = "6x6",
                MoTa = "Best Saler",
                Hang = "Rubik UK",
                Gia = 60000,
                Hinh = "Content/image/Rubik2.jpg",
                SoLgTon = 10
            });

            listRubik.Add(new Rubik()
            {
                Id = 3,
                Ten = "Rubik 3",
                Loai = "12x12",
                MoTa = "Best Saler",
                Hang = "Rubik US",
                Gia = 90000,
                Hinh = "Content/image/Rubik1.jpg",
                SoLgTon = 15
            });

        }

        // GET: Rubik
        public ActionResult Index()
        {
            ViewBag.TitlePageName = "Rubik view page";
            return View(listRubik);
        }

        // GET: Rubik/Details/5
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound ();
            }
            Rubik rubik = listRubik.Find(s => s.Id == id);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }

        // GET: Rubik/Create
        // GET: Rubik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rubik/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rubik rubik)
        {
            if (ModelState.IsValid)
            {
                rubik.Id = listRubik.Count + 1;
                listRubik.Add(rubik);
                return RedirectToAction("Index");
            }

            return View(rubik);
        }


        // GET: Rubik/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.Id == id);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }

        // POST: Rubik/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rubik rubik)
        {
            if (ModelState.IsValid)
            {
                try
                {                   
                    var editRubik = listRubik.Find(b => b.Id == rubik.Id);
                    editRubik.Ten = rubik.Ten;
                    editRubik.Loai = rubik.Loai;
                    editRubik.MoTa = rubik.MoTa;
                    editRubik.Hang = rubik.Hang;
                    editRubik.Gia = rubik.Gia;
                    editRubik.Hinh = rubik.Hinh;
                    editRubik.SoLgTon = rubik.SoLgTon;
                    return View("Index", listRubik);
                }
                catch (Exception)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valide!");
                return View(rubik);            
            }
        }

        // GET: Rubik/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Rubik rubik = listRubik.Find(s => s.Id == id);

            if (rubik == null)
            {
                return HttpNotFound();
            }

            return View(rubik);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Rubik rubik)
        {
            Rubik rubikToRemove = listRubik.Find(r => r.Id == rubik.Id);

            if (rubikToRemove != null)
            {
                listRubik.Remove(rubikToRemove);
            }

            return View("Index", listRubik);
        }

    }
}
