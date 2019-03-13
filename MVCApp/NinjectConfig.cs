using System.Web.Mvc;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;

namespace MVCApp
{
    public class NinjectConfig
    {
        public static void RegisterDependencies()
        {
            //1 class configurator for instance abstraction bindings
            NinjectModule nm = new CustomNinjectModule();

            //2 ninject main functionality creation
            StandardKernel kernel = new StandardKernel(nm);

            kernel.Unbind<ModelValidatorProvider>();
            //kernel.AddBinding();

            //3 resolver for all registered dependencies
            NinjectDependencyResolver ndr = new NinjectDependencyResolver(kernel);

            DependencyResolver.SetResolver(ndr);
        }
    }
}