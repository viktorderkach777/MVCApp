using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AjaxSimpleHelper.Models;

namespace AjaxSimpleHelper
{
    public class EDAL : IDAL
    {
        private readonly Library _ctx = new Library();

        public ICollection<DBPlace> GetDBPlacesByParams(string icon, string time, string rate)
        {
            int workingTime = Int32.Parse(time);
            int currentRate = Int32.Parse(rate);

            if (icon == "all")
            {
                return _ctx.DBPlaces.Where(p => p.OpenTime <= workingTime && p.CloseTime >= workingTime && p.Rate >= currentRate).ToList();
            }

            return _ctx.DBPlaces.Where(p => p.OpenTime <= workingTime && p.CloseTime >= workingTime && p.Icon == icon && p.Rate >= currentRate).ToList();
        }


        public ICollection<DBPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate)
        {
            if (icon == null)
            {
                return _ctx.DBPlaces.ToList();
            }

            //if (!String.IsNullOrEmpty(icon) && !String.IsNullOrEmpty(openTime) && !String.IsNullOrEmpty(closeTime) && !String.IsNullOrEmpty(rate))
            {
                int startTime = Int32.Parse(openTime);
                int finishTime = Int32.Parse(closeTime);
                int currentRate = Int32.Parse(rate);

                if (icon == "all" )
                {
                    return _ctx.DBPlaces.Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Rate >= currentRate).ToList();
                }

                

                return _ctx.DBPlaces.Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Icon == icon && p.Rate >= currentRate).ToList();
            }

           // return null;
        }

        public ICollection<DBPlace> GetDBPlacesByIcon(string icon)
        {
            //if (!String.IsNullOrEmpty(icon))
            {          

                if (icon == "all" || icon==null)
                {
                    return _ctx.DBPlaces.ToList();
                }

                return _ctx.DBPlaces.Where(p =>  p.Icon == icon).ToList();
            }

            //return null;
        }


        public ICollection<DBPlace> GetDBPlacesById(string Id)
        {
            if (!String.IsNullOrEmpty(Id))
            {
                int id = Int32.Parse(Id);                

                return _ctx.DBPlaces.Where(p => p.Id == id).ToList();
            }

            return null;
        }
    }
}