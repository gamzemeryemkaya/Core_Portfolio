using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        SocialMediaManager socialmediaManager = new SocialMediaManager(new EFSocialMediaDAL());
        public IViewComponentResult Invoke()
        {
            var values = socialmediaManager.TGetList();
            return View(values);
        }
    }

}
