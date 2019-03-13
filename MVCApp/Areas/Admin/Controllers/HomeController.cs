using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDAL bll;

        public HomeController(IDAL bll)
        {
            this.bll = bll;
        }

        // GET: Admin/Home
        public ActionResult Index()
        {
            var myTasks = bll.GetDBPlaces().Select(p => new GetPlace()
            {
                Id = p.Id,
                AboutPlace = p.AboutPlace,
                CloseTime = p.CloseTime,
                Icon = p.Icon,
                Latitude = p.Latitude,
                LinkRef = p.LinkRef,
                LinkText = p.LinkText,
                Longitude = p.Longitude,
                Name = p.Name,
                OpenTime = p.OpenTime,
                Rate = p.Rate
            }).ToList();
            return View(myTasks);
        }
    }
}