using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsmeraldaPlus.Web.Controllers
{
    public class inicio : Controller
    {
        // GET: inicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: inicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: inicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: inicio/Create
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

        // GET: inicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: inicio/Edit/5
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

        // GET: inicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: inicio/Delete/5
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
