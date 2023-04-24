using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementsManager announcementsManager = new AnnouncementsManager(new EFAnnouncementsDAL());
        public IActionResult Index()
        {
            var values = announcementsManager.TGetList();
            return View(values);
        }
        public IActionResult AnnouncementsDetails(int id)
        {
            Announcements announcement = announcementsManager.TGetByID(id);
            return View(announcement);
        }
    }
}
