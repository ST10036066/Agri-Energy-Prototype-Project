using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Controllers
{
    /// <summary>
    /// All method creations below occured after a view template 
    /// was chosen and is based on the GreenEnergyMarketplace's model
    /// </summary>
    public class GreenEnergyMarketplaceController : Controller
    {
        //------------generated after the asp.net framework mvc web application was chosen-----
        public ActionResult GreenEnergyMarketplace ()
        {
            return View();
        }
        // GET: GreenEnergyMarketplace
        public ActionResult Index()
        {
            return View();
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        
        // GET: GreenEnergyMarketplace/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

//------------generated after the asp.net framework mvc web application was chosen-----
        //GET: GreenEnergyMarketplace/Create
        public ActionResult Create()
        {
            return View();
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        // POST: GreenEnergyMarketplace/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                /*
                // Extract data from the form collection
                var greenMarketProvider = collection["GreenMarketProvider"];
                var solutionName = collection["SolutionName"];
                var solutionDescription = collection["SolutionDesription"];

                // Create an instance of your data model (assuming CollaborationModel is your EF entity)
                var collaboration = new CollaborationModel
                {
                    GreenMarketProvider = greenMarketProvider,
                    SolutionName = solutionName,
                    SolutionDesription = solutionDescription
                };

                // Save to the database 
                dbContext.Collaborations.Add(collaboration);
                dbContext.SaveChanges();

                // Redirect to the Index action after successful insertion*/
                return RedirectToAction("Index");
            
            }
            catch
            {
                return View();
            }
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        // GET: GreenEnergyMarketplace/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GreenEnergyMarketplace/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        // GET: GreenEnergyMarketplace/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

//------------generated after the asp.net framework mvc web application was chosen-----
        // POST: GreenEnergyMarketplace/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
