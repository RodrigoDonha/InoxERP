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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<InoxErpContext>(new CreateDatabaseIfNotExists<InoxErpContext>());
            //Database.SetInitializer<CalculoHorasContext>(new DropCreateDatabaseIfModelChanges<CalculoHorasContext>());

        }
    }
}
