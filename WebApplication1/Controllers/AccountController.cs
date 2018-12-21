using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.IO;
using OutSource.Entities;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (OutSourceEntities db = new OutSourceEntities())
            {
                return View(db.Users.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Users account)
        {
            if (ModelState.IsValid)
            {
                using (OutSourceEntities db = new OutSourceEntities())
                {
                    Users user = new Users();
                    user.Email = account.Email;
                    user.Name = account.Name;
                    user.Pwd = account.Pwd;
                    user.CellPhone = account.CellPhone;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Name + "" + "成功登入";
            }
            return RedirectToAction("Login");
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users user)
        {
            using (OutSourceEntities db = new OutSourceEntities())
            {
                var usr = db.Users.Single(u => u.Name == user.Name && u.Pwd == user.Pwd);
                {
                    if (usr != null)
                    {
                        Session["UserID"] = user.Id.ToString();
                        Session["UserName"] = user.Name.ToString();
                        return RedirectToAction("user", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("","UserName or Password is wrong!");
                        return View();
                    }
                   
                }
            }
            
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}