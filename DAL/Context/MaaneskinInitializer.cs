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
            context.Items.Add(new Item(0, "Pilsner", 7.5, "CarlsbergPilsner.jpg"));
            context.Items.Add(new Item(1, "IPA", 8.5, "CarlsbergIPA.jpg"));
            context.Items.Add(new Item(2, "Jul", 10, "CarlsbergJul.jpg"));
            context.Items.Add(new Item(3, "Sport", 7.5, "Sport.jpg"));
            context.Items.Add(new Item(4, "Special", 10, "CarlsbergSpecial.jpg"));

            Order order = new Order(1);
            order.AddOrderLine(new OrderLine(1, 10, new Item(1, "Tuborg", 10.00, "img.url")));
            context.Orders.Add(order);

            context.SaveChanges();
        }

        //Dont fucking touch dummy or the Project wont recognize the damn DB
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
