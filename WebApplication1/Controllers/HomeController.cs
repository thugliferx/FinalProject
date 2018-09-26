using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserContext ur = new UserContext();
            User singleur = ur.Users.Where(User => User.Id == 1);


            return View();
        }

        public ActionResult receivecase() {

            return View();
        }


        public ActionResult sendcase()
        {

            return View();
        }




        public ActionResult sendya()
        {

            return View();
        }
    }
}