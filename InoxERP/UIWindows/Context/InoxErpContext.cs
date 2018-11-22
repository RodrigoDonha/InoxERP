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

        //public InoxErpContext() : base("data source=tcp:inoxerpdb.database.windows.net,1433;initial catalog=InoxErpDB;persist security info=False;user id=masterRoot;password=inoxDB2018;multipleactiveresultsets=False;connect timeout=30;encrypt=True;trustservercertificate=False;App=EntityFramework")
        //{
        //}

        //create tables
        public DbSet<Users> Users { get; set; }

        public DbSet<Budgets_OS> Budgets_OS { get; set; }

        public DbSet<Clients> Clients { get; set; }

        public DbSet<Items> Items { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Services> Services { get; set; }

        public DbSet<Permitions> Permitions { get; set; }

        public DbSet<Contracts> Contracts { get; set; }

        public DbSet<Providers> Providers { get; set; }

        public DbSet<Cash> Cash { get; set; }

        public DbSet<Cheques> Cheques { get; set; }

        public DbSet<AccountsToReceive> AccountsToReceive { get; set; }

        public DbSet<ParcialReceive> ParcialReceive { get; set; }

        public DbSet<AccountsToPay> AccountsToPay { get; set; }

        public DbSet<ParcialPay> ParcialPay { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<InoxErpContext>(new CreateDatabaseIfNotExists<InoxErpContext>());
            //Database.SetInitializer<InoxErpContext>(new DropCreateDatabaseIfModelChanges<InoxErpContext>());
        }
    }
}
