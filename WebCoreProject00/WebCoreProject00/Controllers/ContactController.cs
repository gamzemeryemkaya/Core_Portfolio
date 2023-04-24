using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messagemanager = new MessageManager(new EFMessageDAL());
        public IActionResult Index()
        {
            var values = messagemanager.TGetList();
            return View(values);
        }
        public IActionResult DeleteCMessage(int id)
        {
            var values = messagemanager.TGetByID(id);
            messagemanager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult CMessageDetails(int id)
        {
            var values = messagemanager.TGetByID(id);
            return View(values);
        }
    }
}
