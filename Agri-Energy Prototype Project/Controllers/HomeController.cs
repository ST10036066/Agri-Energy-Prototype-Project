using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Controllers
{
    public class HomeController : Controller
    {
//------------generated after the asp.net framework mvc web application was chosen------
        public ActionResult Index()
        { 
            return View();
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
//------------generated after the asp.net framework mvc web application was chosen-----
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}