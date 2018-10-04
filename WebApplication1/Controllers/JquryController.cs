using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class JquryController : Controller
    {
            Entities db = new Entities(); 
            public ActionResult Index()
            {
                return View();
            }
            public JsonResult SaveData(User model)
            {
                db.Users.Add(model);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
            return Json("Registration Successful" , JsonRequestBehavior .AllowGet);
            }
        
    }
}