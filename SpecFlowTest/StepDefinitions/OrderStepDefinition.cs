using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BLL;
using DTO.Models;
using NUnit.Framework;

namespace SpecFlowTest.StepDefinitions {

    [Binding]
    public class OrderStepDefinition {
        private Order _order;
        private int _id;
        private string _date;
        private DateTime _datetime;
        private List<OrderLine> _emptyOrderlines = new List<OrderLine>();
        private static Item _pilsner { get; set; } = new Item("Pilsner", 10.0, "imgurl", 10);
        private List<OrderLine> _filledOrderLines = new List<OrderLine> {
            new OrderLine(1,1, _pilsner),
            new OrderLine(2,1,new Item("Sodavand",7.0,"imgurl",10)),
            new OrderLine(3,3,new Item("Drink",15.0,"imgurl",10))

        };
        private List<Order> _orderList = new List<Order>();

        [Given (@"Parameters, ID (.*), Date (.*)")]
        public void GivenCorrectParameters(int id, string date) {
            _id = id;
            _date = date;
            _datetime = DateTime.Parse(_date);
        }

        [When (@"I create Order")]
        public void WhenICreateOrder() {
            _order = new Order(_id);
            _order.Date = _datetime;
            _order.OrderLines = _filledOrderLines;
        }

        [Then((@"I have parameters as ID (.*), Date (.*)"))]
        public void ThenIhaveAnOrder(int expectedID, string expectedDate) {
            Assert.AreEqual(expectedID, _order.ID);
            Assert.AreEqual(DateTime.Parse(expectedDate), _order.Date);
        }

        [Then(@"I have a order with value of (.*)")]
        public void ThenIHaveOrderWithValueOf(double expectedPrice) {
            foreach(var o in _orderList) {
                Assert.AreEqual(expectedPrice, o.GetTotalOrderPrice());
            }
        }
        [Then(@"When price changes of item value still is (.*)")]
        public void ThenWhenItemPriceChangesValueIsStill(double expectedPrice) {
            _pilsner.Price = 100;
            Assert.AreEqual(expectedPrice, _order.GetTotalOrderPrice());
        }
    }
}
