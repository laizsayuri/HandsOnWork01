using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWork01.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext 
    {
        public DbSet<Bula> Bulas { get; set; }        

        public Context() : base("how_bulasConnectionString")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            Database.Initialize(true);
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bula>().ToTable("Bulas");
            base.OnModelCreating(modelBuilder);
        }
    }
}
