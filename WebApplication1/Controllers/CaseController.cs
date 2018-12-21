using OutSource.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.IO;

namespace WebApplication1.Controllers
{
    public class CaseController : Controller
    {
        // GET: Case
        private OutSourceEntities db = new OutSourceEntities();
        public ActionResult Index()
        {
            using (OutSourceEntities CaseModel = new OutSourceEntities())
            {

                List<OutSourceCase> listOfCase = CaseModel.OutSourceCase.Where(x => true).ToList();


                List<CaseTable> tables = new List<CaseTable>();
                foreach (OutSourceCase dbCase in listOfCase)
                {
                    CaseTable cTable = CaseMapper(dbCase);
                    tables.Add(cTable);
                }

                return View(tables.ToList());
            }

        }

        private static CaseTable CaseMapper(OutSourceCase dbCase)
        {
            CaseTable cTable = new CaseTable();
            cTable.Caseid = dbCase.CaseId;
            cTable.CaseName = dbCase.CaseName;
            cTable.CasePrice = dbCase.Price;
            cTable.StartDate = dbCase.StartDate;
            cTable.EndDate = dbCase.EndDate;
            cTable.Requirs = dbCase.Requirs;
            cTable.CaseField = dbCase.CaseField;
            cTable.Address = dbCase.Address;
            return cTable;
        }

        // GET: Case/Details/5


        // GET: Case/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Case/Create
        [HttpPost]
        public ActionResult Create(CaseTable cTabe)
        {
            try
            {
                using (OutSourceEntities CaseModel = new OutSourceEntities())
                {
                    var outSourceCase = new OutSourceCase();
                    outSourceCase.CaseId = cTabe.Caseid;
                    outSourceCase.CaseName = cTabe.CaseName;
                    outSourceCase.Price = cTabe.CasePrice;
                    outSourceCase.Requirs = cTabe.Requirs;
                    outSourceCase.StartDate = cTabe.StartDate;
                    outSourceCase.EndDate = cTabe.EndDate;
                    outSourceCase.Address = cTabe.Address;
                    outSourceCase.CaseField = cTabe.CaseField;


                    CaseModel.OutSourceCase.Add(outSourceCase);
                    CaseModel.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return View();
            }
        }

        // GET: Case/Edit/5
        public ActionResult Edit(int id)
        {
            using (OutSourceEntities CaseModel = new OutSourceEntities())
            {
                var outSourceCase = new OutSourceCase();

                OutSourceCase sourceCase = CaseModel.OutSourceCase.Where(x => x.CaseId == id).Single();

                CaseTable table = CaseMapper(sourceCase);

                CaseModel.SaveChanges();

                return View(table);
            }

        }

        // POST: Case/Edit/5
        [HttpPost]
        public ActionResult Edit(CaseTable table)
        {
            try
            {
                // TODO: Add update logic here
                using (OutSourceEntities CaseModel = new OutSourceEntities())
                {
                    var outSourceCase = new OutSourceCase();

                    OutSourceCase sourceCase = CaseModel.OutSourceCase.Where(x => x.CaseId == table.Caseid).Single();

                    sourceCase.CaseId = table.Caseid;
                    sourceCase.Address = table.Address;
                    sourceCase.CaseName = table.CaseName;
                    sourceCase.EndDate = table.EndDate;
                    sourceCase.Requirs = table.Requirs;
                    sourceCase.StartDate = table.StartDate;
                    sourceCase.Price = table.CasePrice;
                    sourceCase.CaseField = table.CaseField;

                    CaseModel.OutSourceCase.Attach(sourceCase);
                    CaseModel.Entry(sourceCase).State = EntityState.Modified;

                    CaseModel.SaveChanges();

                   // return View(table);
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Delete/5
        public ActionResult Delete(int id)
        {
            using (OutSourceEntities CaseModel = new OutSourceEntities())
            {
                var outSourceCase = new OutSourceCase();

                OutSourceCase sourceCase = CaseModel.OutSourceCase.Where(x => x.CaseId == id).Single();

                CaseTable Dable = CaseMapper(sourceCase);

                CaseModel.SaveChanges();

                return View(Dable);
            }
        }

        // POST: Case/Delete/5
        [HttpPost]
        public ActionResult Delete(CaseTable Dable)
        {
            try
            {
                // TODO: Add delete logic here
                using (OutSourceEntities CaseModel = new OutSourceEntities())
                {
                    var outSourceCase = new OutSourceCase();

                    OutSourceCase sourceCase = CaseModel.OutSourceCase.Where(x => x.CaseId == Dable.Caseid).Single();
                    sourceCase.CaseId = Dable.Caseid;
                    sourceCase.Address = Dable.Address;
                    sourceCase.CaseName = Dable.CaseName;
                    sourceCase.EndDate = Dable.EndDate;
                    sourceCase.Requirs = Dable.Requirs;
                    sourceCase.StartDate = Dable.StartDate;
                    sourceCase.Price = Dable.CasePrice;
                    sourceCase.CaseField = Dable.CaseField;
                    CaseModel.OutSourceCase.Remove(sourceCase);
                    CaseModel.Entry(sourceCase).State = EntityState.Deleted;
                    CaseModel.SaveChanges();


                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //search
        public ActionResult SearchCaseName(int id)
        {
            using (OutSourceEntities CaseModel = new OutSourceEntities())
            {
                var outSourceCase = new OutSourceCase();

                OutSourceCase sourceCase = CaseModel.OutSourceCase.Where(x => x.CaseId == id).Single();

                CaseTable Sable = CaseMapper(sourceCase);

                CaseModel.SaveChanges();

                return View(Sable);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchCaseName(string searchcase)
        {
            using (OutSourceEntities db = new OutSourceEntities())
            {
                List<CaseTable> tables = new List<CaseTable>();
                var sa = Convert.ToString(searchcase);
                if (!String.IsNullOrEmpty(sa))
                {
                    List<OutSourceCase> sourceCases = db.OutSourceCase.Where(s => s.CaseName.Contains(sa)).ToList();

                  
                    foreach (OutSourceCase dbCase in sourceCases)
                    {
                        CaseTable cTable = CaseMapper(dbCase);
                        tables.Add(cTable);
                    }

                }
                return View(tables);
            }
          



        }

    }
}
