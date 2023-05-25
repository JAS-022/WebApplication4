using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SkusController : Controller
    {
        private ApplicationDbContext _context;

        public SkusController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Index
        public ActionResult Index()
        {
            List<Sku> skus = _context.Skus.ToList();
            return View(skus);
        }

        //Create
        public IActionResult Create()
        {
            Sku sku = new Sku();
            return PartialView("_SkuPartialView", sku);
        }

        [HttpPost]
        public IActionResult Create(Sku sku)
        {
            if (ModelState.IsValid)
            {
                var nameexist = _context.Skus.Any(x => x.Name == sku.Name);
                var codeexist = _context.Skus.Any(x => x.Code == sku.Code);

                if (nameexist && codeexist)
                {
                    ModelState.AddModelError("Name", "Sku with this name already exists");
                    ModelState.AddModelError("Code", "Sku with this code already exists");
                    return PartialView("_SkuPartialView", sku);
                }
                if (nameexist)
                {
                    ModelState.AddModelError("Name", "Sku with this name already exists");
                    return PartialView("_SkuPartialView", sku);
                }
                if (codeexist)
                {
                    ModelState.AddModelError("Code", "Sku with this code already exists");
                    return PartialView("_SkuPartialView", sku);
                }
                else
                {
                    sku.DateCreated = DateTime.Now;
                    sku.TimeStamp = DateTime.Now;
                    _context.Skus.Add(sku);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Skus");
                }
            }
            return View(sku);
        }

        //Edit
        public IActionResult Edit(int id)
        {
            Sku sku = _context.Skus.Where(c => c.Id == id).FirstOrDefault();
            return PartialView("_EditSkuPartialView", sku);
        }

        [HttpPost]
        public IActionResult Edit(Sku sku)
        {
            var nameexist = _context.Skus.Any(x => x.Name == sku.Name);
            var codeexist = _context.Skus.Any(x => x.Code == sku.Code);

            if (ModelState.IsValid)
            {
                if (nameexist && codeexist)
                {
                    ModelState.AddModelError("Name", "Sku with this name already exists");
                    ModelState.AddModelError("Code", "Sku with this code already exists");
                    return PartialView("_EditSkuPartialView", sku);
                }
                if (nameexist)
                {
                    ModelState.AddModelError("Name", "Sku with this name already exists");
                    return PartialView("_EditSkuPartialView", sku);
                }
                if (codeexist)
                {
                    ModelState.AddModelError("Code", "Sku with this code already exists");
                    return PartialView("_EditSkuPartialView", sku);
                }
                else
                {
                    sku.DateCreated = DateTime.Now;
                    sku.TimeStamp = DateTime.Now;
                    _context.Skus.Update(sku);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(sku);
        }
    }
}
