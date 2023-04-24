﻿using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{

    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());
       
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {

            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience exprnc)
        {
            experienceManager.TAdd(exprnc);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var values = experienceManager.TGetByID(id);
            return View("EditExperience", values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience exprnc)
        {
            experienceManager.TUpdate(exprnc);
            return RedirectToAction("Index");
        }


    }
}
