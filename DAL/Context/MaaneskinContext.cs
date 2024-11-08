using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context {
    internal class MaaneskinContext : DbContext {
        public MaaneskinContext() : base("Maaneskin"){

        }

        /*
         * Insert various tables here like this
         * public DbSet<Item> Items { get; set; }
         * Make sure its plural so the OnModelCreating() function will remove the pluralization in the DB
         * but keep it in the code
         */
        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
