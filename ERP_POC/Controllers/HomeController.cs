using ERP_POC.UOW.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_POC.Controllers
{
    public class HomeController : Controller
    {

         
       private IUnitOfWork UOW;

        public HomeController(IUnitOfWork _UOW)
        {
            UOW = _UOW;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}