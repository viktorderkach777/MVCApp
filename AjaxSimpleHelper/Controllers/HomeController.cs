using AjaxSimpleHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxSimpleHelper.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string id)
        {
            return View("Index", (object)id);
        }


        public ActionResult OrderedProducts(string id)
        {
            var orders = OrdersDb.GetOrders;

            if (!String.IsNullOrEmpty(id) && id!="All")
            {
                orders = orders.Where(o => o.Customer == id);
            }

            return PartialView(orders);
        }


        [HttpGet]
        public ActionResult IconMap()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IconMap(string id)
        {
            return View("IconMap", (object)id);
        }

        private readonly IDAL _dal = new EDAL();
        private readonly Library _ctx = new Library();

        public ActionResult OrderedPlaces(string id)
        {
            //var icons = _dal.GetDBPlacesByIcon(id); 
            var icons = _ctx.DBPlaces;

            //if (!String.IsNullOrEmpty(id) && id != "all")
            //{
            //    icons = _ctx.DBPlaces.Where(o => o.Icon == id).ToList();
            //}

            //if (!String.IsNullOrEmpty(id) && id != "all")
            //{
            //    icons = _ctx.DBPlaces.Where(o => o.Icon == id);
            //}

            return PartialView(icons);
        }

        public ICollection<DBPlace> GetDBPlacesByIcon(string icon)
        {
            if (!String.IsNullOrEmpty(icon))
            {

                if (icon == "all")
                {
                    return _ctx.DBPlaces.ToList();
                }

                return _ctx.DBPlaces.Where(p => p.Icon == icon).ToList();
            }

            return null;
        }

    }
}