using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Services.Count();
            ViewBag.v2 = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = c.Portfolios.Count();
            return View();
        }

    }
}
