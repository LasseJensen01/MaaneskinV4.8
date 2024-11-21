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

            //ITEMS
            {
                context.Items.Add(new Item("Grøn Tuborg", 10.0, "GrønTuborg.jpg", 150));
                context.Items.Add(new Item("Tuborg Classic", 10.0, "TuborgClassic.jpg", 95));
                context.Items.Add(new Item("Breezer Pineapple", 15, "BreezerPineapple.jpg", 11));
                context.Items.Add(new Item("Breezer Orange", 15, "BreezerOrange.jpg", 9));
                context.Items.Add(new Item("Breezer Elderflower", 15, "BreezerElderflower.jpg", 5));
                context.Items.Add(new Item("Smirnoff Ice", 15, "SmirnoffIce.jpg", 20));
                context.Items.Add(new Item("Vodka", 0, "AbsolutVodka.jpg", 5));
                context.Items.Add(new Item("Coca Cola", 10, "CocaCola.jpg", 74));
                context.Items.Add(new Item("Pepsi Max", 10, "PepsiMax.jpg", 22));
                context.Items.Add(new Item("Faxe Kondi", 10, "FaxeKondi.png", 21));
                context.Items.Add(new Item("Øl 0%", 10, "Øl0Procent.png", 20));
                context.Items.Add(new Item("Hvidvin", 0, "Hvidvin.jpg", 7));
                context.Items.Add(new Item("Rødvin", 0, "Rødvin.jpg", 2));
                context.Items.Add(new Item("Energidrik", 0, "Energidrik.jpg", 16));
                context.Items.Add(new Item("Grandin", 0, "Grandin.jpg", 1));
                context.Items.Add(new Item("Rød Sodavand", 0, "Rødsodavand.jpg", 1));
            }

            //ORDERS
            {
                Order o1 = new Order();
                o1.AddOrderLine(new OrderLine());
            }


            context.SaveChanges();
        }

        //Dont fucking touch dummy or the Project wont recognize the damn DB
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
