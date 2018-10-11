using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        OutSourceDBEntities db = new OutSourceDBEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(member model)
        {
            db.members.Add(model);
            db.SaveChanges();
            return Json("Registration Successfull", JsonRequestBehavior.AllowGet);

        }
    }
}