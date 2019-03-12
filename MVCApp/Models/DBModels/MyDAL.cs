using System;
using System.Collections.Generic;
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

    }
}