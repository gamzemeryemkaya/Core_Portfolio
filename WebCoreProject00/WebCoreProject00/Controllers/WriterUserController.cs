using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager usermanager = new WriterUserManager(new EFWriterUserDAL());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(usermanager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            usermanager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
