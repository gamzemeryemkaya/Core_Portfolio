using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager faetureManager = new FeatureManager( new EFFeatureDAL());
        public IViewComponentResult Invoke()
        {
            var values = faetureManager.TGetList();
            return View(values);
        }
    }
}
