﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Controllers
{
    public class SustainableFarmingHUBController : Controller
    {
//--------------------------------------------------------------------
        public ActionResult SustainableFarmingHUB()
        {
            return View();
        }
//--------------------------------------------------------------------
        // GET: SustainableFarmingHUB
        public ActionResult Index()
        {
            return View();
        }

//--------------------------------------------------------------------
        // GET: SustainableFarmingHUB/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


//--------------------------------------------------------------------
        // GET: SustainableFarmingHUB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SustainableFarmingHUB/Create
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

//--------------------------------------------------------------------
        // GET: SustainableFarmingHUB/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SustainableFarmingHUB/Edit/5
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


 //--------------------------------------------------------------------
        // GET: SustainableFarmingHUB/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SustainableFarmingHUB/Delete/5
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
