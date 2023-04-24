using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebCoreProject00.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class WDashboardController : Controller
    {
       
        private readonly UserManager<WriterUser> _userManager;

        public WDashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.w = values.Name + " " + values.Surname;

            //api işlemleri
            string api = "e262c39a6d29dc5fbe04caedc976bfde";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=antalya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.w5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //istatistik
            Context c = new Context();
            ViewBag.w1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.w2 = c.Announcementss.Count();
            ViewBag.w3 = c.Users.Count();
            ViewBag.w4 = c.Skills.Count();
            return View();
        }
        

    }
}
