using NUnit.Framework;
using DTO.Models;
using TechTalk.SpecFlow;
using System.Collections;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class ItemCreationSteps
    {
        private Item _item;
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;
        private string _imgURL;

        [Given(@"parameters ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)"", Quantity (.*)")]
        public void GivenTheItemParameters(int id, string name, double price, string imgurl, int quantity)
        {
            _id = id;
            _name = name;
            _price = price;
            _imgURL = imgurl;
            _quantity = quantity;
        }

        [When("I create Item")]
        public void WhenICreateItem()
        {
            _item = new Item(_id, _name, _price, _imgURL, _quantity);
        }

        [Then(@"the item should have ID (.*), Name ""(.*)"", Price (.*), and ImgURL ""(.*)"", Quantity (.*)")]
        public void ThenIHaveAnItem(int expectedId, string expectedName, double expectedPrice, string expectedImgUrl, int expectedQuantity)
        {
            Assert.AreEqual(expectedId, _item.ID, "Item ID mismatch.");
            Assert.AreEqual(expectedName, _item.Name, "Item Name mismatch.");
            Assert.AreEqual(expectedPrice, _item.Price, 0.01, "Item Price mismatch.");
            Assert.AreEqual(expectedImgUrl, _item.ImgURL, "Item ImgURL mismatch.");
            Assert.AreEqual(expectedQuantity, _item.Quantity, "Item Quantity mismatch.");
        }

        [Then(@"the item should throw an ArgumentException")]
        public void ThenIHaveInputError()
        {
            Assert.Throws<ArgumentException>(() => {
                new Item(-1, null, -1, null, -1);
            }, "Expected ArgumentException not thrown.");
        }

        [Then(@"the property (.*) is of type double")]
        public void ThenIHaveTypeDoubleSurity(IEnumerable expectedNumber)
        {
            Assert.AreEqual(expectedNumber.GetType(), typeof(double), "Expected type mismatch: double.");
        }
    }
}
