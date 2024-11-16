using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Context {
    internal class MaaneskinInitializer : CreateDatabaseIfNotExists<MaaneskinContext>{
        protected override void Seed(MaaneskinContext context) {
            // Make an Init Data for the DB here
            context.Items.Add(new Item("Pilsner", 7.5, "CarlsbergPilsner.jpg", 100));
            context.Items.Add(new Item("IPA", 8.5, "CarlsbergIPA.jpg", 100));
            context.Items.Add(new Item("Jul", 10, "CarlsbergJul.jpg", 100));
            context.Items.Add(new Item("Sport", 7.5, "Sport.jpg", 100));
            context.Items.Add(new Item("Special", 10, "CarlsbergSpecial.jpg", 100));

            context.SaveChanges();
        }

        //Dont fucking touch dummy or the Project wont recognize the damn DB
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
