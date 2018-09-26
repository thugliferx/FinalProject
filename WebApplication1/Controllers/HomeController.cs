using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Jsn_1()
        {
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
        
        public JsonResult GetJson_Content_A_Md()
        {
            IList<Object> ObjList = new List<Object>()
            {
                new{ User_Name="Steven", account_number="Thuglifer", IsMale=true},
                new{  User_Name="Stanley", account_number="Stanley", IsMale=true},
                new{  User_Name="Sherry", account_number="Love", IsMale=false}
            };
            return Json(ObjList, JsonRequestBehavior.AllowGet);
        }
       
    }
}