using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("StoreContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<StoreContext>());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}