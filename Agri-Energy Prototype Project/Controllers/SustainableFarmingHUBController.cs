using Agri_Energy_Prototype_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;



namespace Agri_Energy_Prototype_Project.Controllers
{
    public class SustainableFarmingHUBController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ActionResult SustainableFarmingHUB()
        {
            SustainableFarmingHUB model = new SustainableFarmingHUB();
            ViewBag.Products = _context.SustainableFarmingHUB.ToList();
            return View("ViewProducts", model);

            // model.ViewProducts = _context.SustainableFarmingHUBs.ToList();
            // or whatever your data source is

            //return View();
        }

      


        public SustainableFarmingHUBController()
        {
            _context = ApplicationDbContext.Create();
        }

        // GET: SustainableFarmingHUB
        public ActionResult Index()
       {
            return View();
        }

        // GET: SustainableFarmingHUB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SustainableFarmingHUB/Create
        [HttpPost]
        public ActionResult Create(SustainableFarmingHUB model)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new SustainableFarmingHUB
                {
                    ProductName = model.ProductName,
                    ProductionDate = model.ProductionDate,
                    ProductionDetails = model.ProductionDetails,
                    ProductUsage = model.ProductUsage,
                    Owner = model.Owner,
                    Category = model.Category
                };
                _context.SustainableFarmingHUB.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: SustainableFarmingHUB/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _context.SustainableFarmingHUB.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: SustainableFarmingHUB/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var product = _context.SustainableFarmingHUB.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            _context.SustainableFarmingHUB.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: SustainableFarmingHUB/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _context.SustainableFarmingHUB.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: SustainableFarmingHUB/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SustainableFarmingHUB model)
        {
            if (ModelState.IsValid)
            {
                var product = _context.SustainableFarmingHUB.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                product.ProductName = model.ProductName;
                product.ProductionDate = model.ProductionDate;
                product.ProductionDetails = model.ProductionDetails;
                product.ProductUsage = model.ProductUsage;
                product.Owner = model.Owner;
                product.Category = model.Category;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


        public ActionResult ViewProducts()
        {
            // Retrieve the saved data from the database or repository
            var products =_context.SustainableFarmingHUB.ToList(); // Assuming you have a database context or repository

            return View(products);
        }

    }
}


