using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager todoListManager = new ToDoListManager(new EFToDoListDAL());
        public IViewComponentResult Invoke()
        {
            var values = todoListManager.TGetList();
            return View(values);
        }
    }
}
