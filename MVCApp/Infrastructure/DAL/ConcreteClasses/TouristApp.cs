
//using Microsoft.AspNet.Identity.EntityFramework;
//using System.Data.Entity;
//using MVCApp.Models;

//using System;
//using System.Linq;


//namespace MVCApp
//{        

//    public class TouristAppContext : IdentityDbContext<DALPlace>
//        {

//        public TouristAppContext() : base("CustomConnectionString") { }
       

//        public static TouristAppContext Create()
//        {
//            return new TouristAppContext();
//        }


//        //public TouristApp()
//        //     : base("name=TouristApp")
//        //{
//        //    Database.SetInitializer<TouristApp>(new CustomInitializer<TouristApp>());
//        //}

//        public virtual DbSet<DALPlace> DALPlaces { get; set; }
//    }
//}