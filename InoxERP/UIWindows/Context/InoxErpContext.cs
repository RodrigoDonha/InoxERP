using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities;

namespace UIWindows.Context
{
    public class InoxErpContext : DbContext
    {
        public InoxErpContext() : base("InoxErpDB")
        {
        }

        //create tables
        public DbSet<Users> Users { get; set; }

        public DbSet<Budgets_OS> Budgets_OS { get; set; }

        public DbSet<Clients> Clients { get; set; }

        public DbSet<Items> Items { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Services> Services { get; set; }

        public DbSet<Permitions> Permitions { get; set; }

        public DbSet<Contracts> Contracts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<InoxErpContext>(new CreateDatabaseIfNotExists<InoxErpContext>());
            Database.SetInitializer<InoxErpContext>(new DropCreateDatabaseIfModelChanges<InoxErpContext>());
        }
    }
}
