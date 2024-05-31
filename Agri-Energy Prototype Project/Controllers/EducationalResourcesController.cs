using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Controllers
{
    public class EducationalResourcesController : Controller
    {
        public ActionResult EducationalResources()
        {
           

            return View();
        }
        // GET: EducationalResources
        public ActionResult Index()
        {
            return View();
        }

        // GET: EducationalResources/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EducationalResources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EducationalResources/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EducationalResources/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EducationalResources/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EducationalResources/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EducationalResources/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
