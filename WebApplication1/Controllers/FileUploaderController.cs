using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//********************************************************
using WebApplication1.Models;  // 自己動手寫上命名空間 -- 「專案名稱.Models_FileUpload」。

using System.IO;
using OutSource.Entities;


namespace WebApplication1.Controllers
{
    public class FileUploaderController : Controller
    {
        // GET: FileUploader
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> files)
        {
            using (OutSourceEntities filemodel = new OutSourceEntities())
            {
                FileUpload_DB_Certif filetable = new FileUpload_DB_Certif();

                foreach (var file in files)
                {
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                        filetable.FileUpload_FilName = path;
                        file.SaveAs(path);
                        filemodel.FileUpload_DB_Certif.Add(filetable);
                        filemodel.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
        }


        public ActionResult DownLoad(int picId)
        {
            using (OutSourceEntities filemodel = new OutSourceEntities())
            {
                FileUpload_DB_Certif filetable = new FileUpload_DB_Certif();
                {
                    List<FileUpload_DB_Certif> pics =  filemodel.FileUpload_DB_Certif.Where(x => x.FileUpload_DB_CerId == picId).ToList();
                    FileUpload_DB_Certif pic = pics.SingleOrDefault();
                    string str = filemodel.FileUpload_DB_Certif.ToString();
                   // var path = Path.Combine(dir, filemodel.FileUpload_DB_Certif.ToString() + ".jpg"); ; //validate the path for security or use other means to generate the path.
                    return base.File(pic.FileUpload_FilName , "image/jpeg");
                }


            }
        }
    }
}