using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SifabsApps.KOSPATemplate.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // the Index action is our entry point to the app.
        // this view contain the template placeholder for all content
        // which will be loaded async in client side
        public ActionResult Index()
        {
            return View();
        }

        #region views 

        // these views will be called once the app is initialized
        // as the user navigates in client.
        // which means we can still use razor and process them with
        // any custom server side logic like normal asp.net mvc views

        public ActionResult Default()
        {
            ViewBag.Message = "Your Home page";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your About page";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact page";
            return View();
        }

        #endregion
    }
}