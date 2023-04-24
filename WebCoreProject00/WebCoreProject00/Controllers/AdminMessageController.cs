using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EFWriterMessageDAL());
        public IActionResult InBoxMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writermessagemanager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult OutBoxMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writermessagemanager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminWriterMessageDetails(int id)
        {
            var values = writermessagemanager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminWriterMessageDelete(int id)
        {
            var values = writermessagemanager.TGetByID(id);
            writermessagemanager.TDelete(values);
            return RedirectToAction("OutBoxMessageList");
        }
        [HttpGet]
        public IActionResult AdminWriterMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminWriterMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writermessagemanager.TAdd(p);
            return RedirectToAction("OutBoxMessageList");
        }

    }
}
