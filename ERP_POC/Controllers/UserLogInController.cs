using ERP_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_POC.Controllers
{
    public class UserLogInController : Controller
    {
        // GET: UserLogIn
        public ActionResult Index()
        { 
            UserLogInVM UserLogInVM = new UserLogInVM();

            UserLogInVM.UserName = "sss";
            UserLogInVM.Password= "sss";

            return View(UserLogInVM);
        }

        public ActionResult LogInMe(UserLogInVM UserLogInVM)
        {

            if(ModelState.IsValid)
            {

            }

            return  Json(UserLogInVM);
        }
    }
}