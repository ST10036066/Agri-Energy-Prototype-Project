using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Controllers
{
    public class CollaborationsController : Controller
    {
        public CollaborationsController() { }

        public ActionResult Collaborations ()
        {
            return(View());
        }
        // GET: Collaborations
        public ActionResult Index()
        {
            return View();
        }

        // GET: Collaborations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Collaborations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Collaborations/Create
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

        // GET: Collaborations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Collaborations/Edit/5
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

        // GET: Collaborations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Collaborations/Delete/5
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
