using AjaxSimpleHelper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
             //public ActionResult IconMap(PostPlace id)
        {
            return View("IconMap", (object)id);
        }

        private readonly IDAL _dal = new EDAL();
        private readonly Library _ctx = new Library();

        //public ActionResult OrderedPlaces(string id)
        public ActionResult OrderedPlaces(PostPlace place)
        {
            ICollection<DBPlace> icons;
            string id = place.id;

            if (place.Counter==null)
            {
                place.Counter = "1";
            }
            else
            {
                place.Counter += "2";
            }

            if (id!=null)
            {
                String[] words = place.slider.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                words = words.Where(val => val != "-").ToArray();

                List<string> times = new List<string>();

                foreach (var item in words)
                {
                    int pos = item.IndexOf(":00");
                    times.Add(item.Remove(pos));
                }
                 icons = _dal.GetDBPlacesByAllParams(id, times[0], times[1], place.Rate);

            }
            else
            {
                icons = _dal.GetDBPlacesByAllParams(id, place.OpenTime, place.CloseTime, place.Rate);
            }
           

            


           
            // var icons = _dal.GetDBPlacesByIcon(id); 
            //var icons = _ctx.DBPlaces;

            //if (!String.IsNullOrEmpty(id) && id != "all")
            //{
            //    icons = _dal..Where(o => o.Icon == id).ToList();
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

        [HttpGet]
        public ActionResult SliderMap()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SliderMap(string id)
        //public ActionResult IconMap(PostPlace id)
        {
            return View("SliderMap", (object)id);
        }


        [HttpGet]
        public ActionResult Weather()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Weather(string id)
        {
            return View("Weather", (object)id);
        }


        [HttpGet]
        public ActionResult Temp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Temp(string id)
        {
            return View("Temp", (object)id);
        }

    }
}