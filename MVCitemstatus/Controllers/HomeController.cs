using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCitemstatus.Models;

namespace MVCitemstatus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Itemstatus()
        {
            var items = new List<ItemViewModels>
            {
                new ItemViewModels{ Id = 1, Status = "01"},
                new ItemViewModels{ Id = 2, Status = "00"},
                new ItemViewModels{ Id = 3, Status = "20"},
                new ItemViewModels{ Id = 4, Status = "99"},
                new ItemViewModels{ Id = 5, Status = "00"},
            };  

            return View(items);
        }

    }
}