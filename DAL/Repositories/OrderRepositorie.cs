﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class OrderRepositorie {
        public static DTO.Models.Order GetOrder(int id) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order order = context.Orders.Find(id);
                DTO.Models.Order DTOOrder = Mapper.OrderMapper.Map(order);
                DTOOrder.OrderLines = OrderLinjeRepositorie.GetAllOrderLinjes(DTOOrder.ID);
                return DTOOrder;
            }
        }
        public static List<DTO.Models.Order> GetAllOrders() {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                List<DAL.Models.Order> orders = context.Orders.ToList();
                List<DTO.Models.Order> DTOorders = Mapper.OrderMapper.Map(orders);
                //hiv orderlines med
                foreach (DTO.Models.Order order in DTOorders)
                {
                    List<DTO.Models.OrderLine> orderLines = OrderLinjeRepositorie.GetAllOrderLinjes(order.ID);
                    order.OrderLines = orderLines;
                }
                
                return DTOorders;
            }
        }
        public static void AddOrder(DTO.Models.Order order) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order dataOrder = Mapper.OrderMapper.Map(order);
                

                foreach (Models.OrderLine ol in dataOrder.OrderLines) {
                    ol.Item.Quantity = ol.Item.Quantity - ol.Quantity;
                    ItemRepositorie.UpdateItem(Mapper.ItemMapper.Map(ol.Item)); 

                    // Tells the DbContext the item changes are a modification and shouldnt create a new table element
                    // For this object
                    context.Entry(ol.Item).State = System.Data.Entity.EntityState.Modified;
                }
                context.Orders.Add(dataOrder);
                context.SaveChanges();
            }
        }
    }
}
