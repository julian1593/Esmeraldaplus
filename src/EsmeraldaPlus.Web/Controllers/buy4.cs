﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsmeraldaPlus.Web.Controllers
{
    public class buy4 : Controller
    {
        // GET: buy4
        public ActionResult Index()
        {
            return View();
        }

        // GET: buy4/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: buy4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: buy4/Create
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

        // GET: buy4/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: buy4/Edit/5
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

        // GET: buy4/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: buy4/Delete/5
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
