using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context {
    internal class MaaneskinInitializer : CreateDatabaseIfNotExists<MaaneskinContext>{
        protected override void Seed(MaaneskinContext context) {
            // Make an Init Data for the DB here
            context.SaveChanges();
        }

        //Dont fucking touch dummy or the Project wont recognize the damn DB
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
