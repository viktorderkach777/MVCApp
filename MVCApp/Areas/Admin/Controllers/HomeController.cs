using MVCApp.Models;
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

        [TrackExecutionTime]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [TrackExecutionTime]
        [HttpPost]
        public ActionResult Create(GetPlace p)
        {
            if (ModelState.IsValid)
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

                bool IsSave = bll.AddPlace(dp);

                if (IsSave)
                {
                    return RedirectToAction("Index");
                }               
            }

            return View(p);
        }

        [TrackExecutionTime]
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

        [TrackExecutionTime]
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

       
        public ActionResult MyLogTable()
        {
            var logTables = bll.GetLogTables().Select(p => new ViewLogTable()
            {
                Id = p.Id,
                ActionName = p.ActionName,
                ActionRunningTime = p.ActionRunningTime,
                GetPostName = p.GetPostName,
                StartTime = p.StartTime,
                ViewRenderingTime = p.ViewRenderingTime

            }).ToList();

            return View(logTables);
        }
       
    }
}