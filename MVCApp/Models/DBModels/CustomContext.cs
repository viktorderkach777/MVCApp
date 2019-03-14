using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace MVCApp
{
    public class CustomContext : IdentityDbContext<CustomUser>
    {
        public CustomContext() :base("CustomConnectionString")
        {
            Database.SetInitializer<CustomContext>(new CustomInitializer<CustomContext>());
        }

        public static CustomContext Create()
        {
            return new CustomContext();
        }

        public virtual DbSet<Account> Accounts{get; set;}

        public virtual DbSet<DALPlace> DALPlaces { get; set; }

        public virtual DbSet<LogTable> LogTables { get; set; }
    }
}