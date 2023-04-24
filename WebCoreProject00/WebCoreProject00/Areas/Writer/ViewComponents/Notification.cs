using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementsManager announcementsManager = new AnnouncementsManager(new EFAnnouncementsDAL());
        public IViewComponentResult Invoke()
        {
            var values = announcementsManager.TGetList().Take(3).ToList();
            return View(values);
        }
    }
}