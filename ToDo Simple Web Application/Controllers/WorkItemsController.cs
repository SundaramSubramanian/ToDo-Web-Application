using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDo_Simple_Web_Application.Controllers
{
    public class WorkItemsController : Controller
    {
        // GET: WorkItems
        public ActionResult Index()
        {
            return View();
        }

        // GET: WorkItems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkItems/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}