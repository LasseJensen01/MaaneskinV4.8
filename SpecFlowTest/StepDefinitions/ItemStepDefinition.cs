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
            private string _imgURL = "";

            [Given(@"parameters ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)""")]
            public void GivenTheItemParameters(int id, string name, double price, string imgurl) {
                _id = id;
                _name = name;
                _price = price;
                _imgURL = imgurl;
            }

            [When("I create Item")]
            public void WhenICreateItem() {
                _item = new Item(_id, _name, _price, _imgURL);
            }
            [Then(@"the item should have ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)""")]
            public void ThenIHaveAnItem(int expID, string expName, double expPrice, string expImgURL) {
                Assert.AreEqual(expID, _item.ID);
                Assert.AreEqual(expName, _item.Name);
                Assert.AreEqual(expPrice, _item.Price);
                Assert.AreEqual(expImgURL, _item.ImgURL);
            }
        }
    }
}
