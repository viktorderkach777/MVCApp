using System.Collections.Generic;
using System.Linq;
using AjaxSimpleHelper.Models;

namespace AjaxSimpleHelper
{
    public class EDAL : IDAL
    {
        private readonly Library _ctx = new Library();

        public ICollection<DBPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate)
        {
            if (icon == null)
            {
                return _ctx.DBPlaces.ToList();
            }

            if (!string.IsNullOrEmpty(openTime) && !string.IsNullOrEmpty(closeTime) && !string.IsNullOrEmpty(rate))
            {
                int startTime = int.Parse(openTime);
                int finishTime = int.Parse(closeTime);
                int currentRate = int.Parse(rate);

                if (icon == "all")
                {
                    return _ctx.DBPlaces.Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Rate >= currentRate).ToList();
                }

                return _ctx.DBPlaces.Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Icon == icon && p.Rate >= currentRate).ToList();
            }

            return null;
        }        
    }
}