using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using System.Data.Entity;

namespace MVCApp
{
    public class CustomNinjectModule : NinjectModule
    {

        public override void Load()
        {
            Bind<IDAL>().To<MyDal>();

        }

    }
}