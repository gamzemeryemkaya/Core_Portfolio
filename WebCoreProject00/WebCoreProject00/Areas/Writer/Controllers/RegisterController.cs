﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreProject00.Areas.Writer.Models;

namespace WebCoreProject00.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
         public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageURL = p.ImageURL
            };
            if (p.Password == p.ConfirmPassword)
            {
                var result = await userManager.CreateAsync(w, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
