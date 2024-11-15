using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace SpecFlowTest.StepDefinitions {
    // MAKE THESE FIRST, THE FEATURE WILL GET INTELLISENSE BASED ON THESE FUNCTIONS
    internal class ItemStepDefinition {
        [Binding]
        public class ItemCreationSteps {
            private Item _item = new Item();
            private int _id = 0;
            private string _name = "";
            private double _price = 0.0;
            private int _quantity = 0;
            private string _imgURL = "";

            [Given(@"Parameters ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)"", Quantity (.*)")]
            public void GivenTheItemParameters(int id, string name, double price, string imgurl, int quantity) {
                _id = id;
                _name = name;
                _price = price;
                _quantity = quantity;
                _imgURL = imgurl;
            }

            [When("I create Item")]
            public void WhenICreateItem() {
                _item = new Item(_id, _name, _price, _imgURL, _quantity);
            }
            [Then(@"The item should have ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)"", Quantity (.*)")]
            public void ThenIHaveAnItem(int expID, string expName, double expPrice, string expImgURL, int quantity) {
                Assert.AreEqual(expID, _item.ID);
                Assert.AreEqual(expName, _item.Name);
                Assert.AreEqual(expPrice, _item.Price);
                Assert.AreEqual(expImgURL, _item.ImgURL);
                Assert.AreEqual(_quantity, _item.Quantity);
            }
        }
    }
}
