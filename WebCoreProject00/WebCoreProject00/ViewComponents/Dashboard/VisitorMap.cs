﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
