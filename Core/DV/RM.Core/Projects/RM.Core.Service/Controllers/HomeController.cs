using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RM.Core.Data;
namespace RM.Core.Service.Controllers
{
    public class HomeController : Controller
    {
        private Prueba prueba = new Prueba();

        public ActionResult Index()
        {
            prueba.testCall();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
