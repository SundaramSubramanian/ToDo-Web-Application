using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_Simple_Web_Application.Interface;

namespace ToDo_Simple_Web_Application.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;
        

        public RegistrationController()
        {
            _registrationService=new 
        }

        // GET: userRegistration
        public ActionResult Index()
        {
            return View();
        }

        // GET: userRegistration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: userRegistration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: userRegistration/Create
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

        // GET: userRegistration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: userRegistration/Edit/5
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

        // GET: userRegistration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: userRegistration/Delete/5
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