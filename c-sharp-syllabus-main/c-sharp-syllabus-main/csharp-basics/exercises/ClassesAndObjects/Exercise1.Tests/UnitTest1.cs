using Exercise_1;
using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        private Product _target;
        private string _name = "Apple";
        private double _price = 50;
        private int _amount = 60;

        [SetUp]
        public void Setup()
        {
            _target = new Product(_name, _price, _amount);
        }

        [Test]
        public void PrintProduct_CheckIfPrintsApple50Euroes60Amount_ReturnsString()
        {
            string product = _target.PrintProduct();
            string value = "Apple, price 50EUR, amount 60";

            Assert.AreEqual(value, product);
        }

        [Test]
        public void ChangeAmount_StartPrice60_Returns10()
        {
            int product = _target.ChangeAmount(10);

            Assert.AreEqual(10, product);
        }

        [Test]
        public void ChangePrice_StartPrice50_Returns55()
        {
            double product = _target.ChangePrice(55);

            Assert.AreEqual(55, product);
        }
    }
}