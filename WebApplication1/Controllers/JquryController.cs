using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
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
            model.Isvalid=false;
            db.Users.Add(model);
            
                db.SaveChanges();
           
            BuildEmailTemplate(model.Id);
           
            return Json("Registration Successful" , JsonRequestBehavior .AllowGet);
            }

        public void BuildEmailTemplate(string Regid)
        {
            string body = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/EmailTemplate/")+"Text"+".cshtml");
        }

        
    }
}