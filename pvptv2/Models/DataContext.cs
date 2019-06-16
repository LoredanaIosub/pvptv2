using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace pvptv2.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("MyConnectionString") //constructor de context
        { }

        public DbSet<Tourist> Tourists { get; set; } //set de entitati

        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //public System.Data.Entity.DbSet<pvptv2.Models.Notifications> NotificationServices { get; set; }
    }
}