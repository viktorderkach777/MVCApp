using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp
{

    public class MyDal : IDAL
    {
        private readonly CustomContext ctx;

        public MyDal()
        {
            this.ctx = CustomContext.Create();
        }

        public MyDal(CustomContext ctx)
        {
            this.ctx = ctx;
        }


        public ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate)
        {
            if (icon == null)
            {
                return ctx.Set<DALPlace>().ToList();
            }

            if (!string.IsNullOrEmpty(openTime) && !string.IsNullOrEmpty(closeTime) && !string.IsNullOrEmpty(rate))
            {
                int startTime = int.Parse(openTime);
                int finishTime = int.Parse(closeTime);
                int currentRate = int.Parse(rate);

                if (icon == "all")
                {
                    return ctx.Set<DALPlace>().Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Rate >= currentRate).ToList();
                }

                return ctx.Set<DALPlace>().Where(p => p.OpenTime <= startTime && p.CloseTime >= finishTime && p.Icon == icon && p.Rate >= currentRate).ToList();
            }

            return null;
        }

        public DALPlace GetDBPlacesById(string id)
        {
            if (id == null)
            {
                return null;
            }

            int ID = int.Parse(id);

            DALPlace myPlace = ctx.DALPlaces.Where(p => p.Id == ID).SingleOrDefault();

            return myPlace;
        }

        public ICollection<DALPlace> GetDBPlaces()
        {
            return ctx.Set<DALPlace>().ToList();
        }

        public bool  AddPlace (DALPlace place)
        {
            if (place == null)
            {
                return false;
            }

            int count = ctx.DALPlaces.Count();

            ctx.DALPlaces.Add(place);
            ctx.SaveChanges();           

            return count == ctx.DALPlaces.Count();
        }

        public bool EditPlace(DALPlace place)
        {
            if (place !=null)
            {
                ctx.Entry(place).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }

            return false;
        }

    }
}