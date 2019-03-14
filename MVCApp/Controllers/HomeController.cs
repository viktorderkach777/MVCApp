using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp
{
    public class HomeController : Controller
    {
        private readonly IDAL bll;

        public HomeController(IDAL bll)
        {
            this.bll = bll;
        }

        //private readonly IDAL bll = new MyDal();

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



        [HttpGet]
        public ActionResult Map()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Map(string Id)
        {
            return View("Map", (object)Id);
        }


        public JsonResult JsonPlaces(PostPlace place)
        {

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

            var icons = bll.GetDBPlacesByAllParams(Id, times[0], times[1], place.Rate);
            //}
            //else
            //{
            //    icons = _dal.GetDBPlacesByAllParams(Id, "12", "15", place.Rate);
            //}

            return Json(icons, JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Table()
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(GetPlace p)
        {
            if (ModelState.IsValid)
            {
                //bll.MyTasks.Add(myTask);
                //db.SaveChanges();
                DALPlace dp = new DALPlace()
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
                };

                bool IsSave = bll.AddPlace(dp);

                if (IsSave)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(p);
                }
            }

            return View(p);
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            DALPlace p = bll.GetDBPlacesById(id.ToString());

            if (p != null)
            {
                GetPlace dp = new GetPlace()
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
                };

                return View(dp);
            }


            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(GetPlace p)
        {
            if (ModelState.IsValid)
            {

                if (p != null)
                {
                    DALPlace dp = new DALPlace()
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
                    };

                    bool IsEdit = bll.EditPlace(dp);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(p);
                }
            }

            return View(p);
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            DALPlace place = bll.GetDBPlacesById(id.ToString());

            if (place != null)
            {
                bll.RemovePlace(place);
            }
            
            return RedirectToAction("Index");
        }
    }
}