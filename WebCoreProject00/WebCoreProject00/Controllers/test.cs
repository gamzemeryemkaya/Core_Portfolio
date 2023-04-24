using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
