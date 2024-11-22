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
        private static ItemBLL itembll { get; set; } = new ItemBLL();
        private Order _order;
        private int _id;
        private string _date;
        private DateTime _datetime;
        private List<OrderLine> _emptyOrderlines = new List<OrderLine>();
        private List<OrderLine> _filledOrderLines = new List<OrderLine> {
            new OrderLine(1,1,itembll.GetItem(1)),
            new OrderLine(2,2,new Item()),
            new OrderLine(3,3,new Item())

        };
        private List<Order> _orderList = new List<Order>();

        [Given (@"Parameters, ID (.*), Date (.*)")]
        public void GivenCorrectParameters(int id, string date) {
            _id = id;
            _date = date;
            _datetime = DateTime.Parse(_date);
        }

        [Given(@"following orders exist:")]
        public void GivenFollowingOrdersExist(Table table) {
            foreach (var row in table.Rows) {
                Order o = new Order(Int32.Parse(row["ID"]));
                o.Date = DateTime.Parse(row["Date"]);
                _orderList.Add(o);
            }
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
    }
}
