using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsmeraldaPlus.Web.Controllers
{
    public class Registrarse : Controller
    {
        // GET: Registrase
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registrase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registrase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrase/Create
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

        // GET: Registrase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registrase/Edit/5
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

        // GET: Registrase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registrase/Delete/5
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
