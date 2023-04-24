using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{
    public class ClientTestimonialsController : Controller
    {
        ClientTestimonialsManager testimonialsManager = new ClientTestimonialsManager(new EFClientTestimonialsDAL());
        public IActionResult Index()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(ClientTestimonials p)
        {
            testimonialsManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialsManager.TGetByID(id);
            testimonialsManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            ViewBag.v1 = "Referans Güncelleme";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referans Güncelleme";
            var values = testimonialsManager.TGetByID(id);
            return View("EditTestimonial", values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(ClientTestimonials testimonial)
        {
            testimonialsManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
