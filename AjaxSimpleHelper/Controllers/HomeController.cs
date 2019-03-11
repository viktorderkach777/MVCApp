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
        public ActionResult Index(string Id)
        {
            return View("Index", (object)Id);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult IconMap()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IconMap(string Id)            
        {
            return View("IconMap", (object)Id);
        }

        private readonly IDAL _dal = new EDAL();      


        public JsonResult JsonPlaces(PostPlace place)
        {
            ICollection<DBPlace> icons;
            string Id = place.Id;            

            //if (Id != null)
            //{
                string[] words = place.Slider.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                words = words.Where(val => val != "-").ToArray();

                List<string> times = new List<string>();

                foreach (var item in words)
                {
                    int pos = item.IndexOf(":00");
                    times.Add(item.Remove(pos));
                }

                icons = _dal.GetDBPlacesByAllParams(Id, times[0], times[1], place.Rate);
            //}
            //else
            //{
            //    icons = _dal.GetDBPlacesByAllParams(Id, "12", "15", place.Rate);
            //}

            return  Json(icons, JsonRequestBehavior.AllowGet);
        }        

    }
}