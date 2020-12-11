using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsmeraldaPlus.Web.Controllers
{
    public class sessionstarted : Controller
    {
        // GET: sessionstarted
        public ActionResult Index()
        {
            return View();
        }

        // GET: sessionstarted/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: sessionstarted/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sessionstarted/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: sessionstarted/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: sessionstarted/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: sessionstarted/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: sessionstarted/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
