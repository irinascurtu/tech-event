//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using TechEvent.Domain.Entities;

//namespace TechEvent.Web.Controllers
//{
//    public class SponsorTypesController : Controller
//    {
//        // GET: SponsorTypes
//        public ActionResult List()
//        {
//            var model = new List<SponsorTypes>();
//            return View(model);
//        }

//        // GET: SponsorTypes/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: SponsorTypes/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: SponsorTypes/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: SponsorTypes/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: SponsorTypes/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: SponsorTypes/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: SponsorTypes/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}