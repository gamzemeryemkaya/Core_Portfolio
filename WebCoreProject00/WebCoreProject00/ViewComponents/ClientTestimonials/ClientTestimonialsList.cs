using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.ClientTestimonials
{
    public class ClientTestimonialsList:ViewComponent
    {
        ClientTestimonialsManager testimonialsManager = new ClientTestimonialsManager(new EFClientTestimonialsDAL());
        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
    }
}
