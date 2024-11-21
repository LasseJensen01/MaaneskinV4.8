using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using NUnit.Framework;

namespace SpecFlowTest.StepDefinitions {
    public class OrderStepDefinition {
        private Order _order;
        private int _id;
        private DateTime _date;
        private List<OrderLine> _orderlines = new List<OrderLine>();

        [Given (@"Parameters, ID (.*), Date (.*), Orderlines (.*)")]
        public void GivenCorrectParameters(int id, DateTime date, List<OrderLine> orderLines) {
            _id = id;
            _date = date;
            _orderlines = orderLines;
        }

        [When (@"I create order")]
        public void WhenICreateOrder() {
            _order = new Order(_id);
            _order.Date = _date;
            _order.OrderLines = _orderlines;
        }

        [Then((@"I have parameters as ID (.*), Date (.*) Orderlines (.*)"))]
        public void ThenIhaveAnOrder(int expectedID, DateTime expectedDate, List<OrderLine> expectedOrderlines) {
            Assert.AreEqual();
        }
    }
}
