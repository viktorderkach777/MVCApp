using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MVCApp
{
    public class CustomContext : IdentityDbContext<CustomUser>
    {
        public CustomContext() :base("CustomConnectionString")
        {

        }

        public static CustomContext Create()
        {
            return new CustomContext();
        }

        public virtual DbSet<Account> Accounts{get; set;}
    }
}