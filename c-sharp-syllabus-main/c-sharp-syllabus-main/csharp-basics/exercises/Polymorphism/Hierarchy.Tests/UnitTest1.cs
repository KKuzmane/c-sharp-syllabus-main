using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class Tests
    {
        private Animal _cat;
        private Animal _mouse;
        private Food _meat;
        [SetUp]
        public void Setup()
        {
            _cat = new Cat("Lucijs", "Cat", 4.9, 3, "Latvia", "no breed");
            _mouse = new Mouse("Minnija", "The Mouse", 0.4, 1, "House");
            _meat = new Meat(3);
        }

        [Test]
        public void MakeSound_AnimalsSound_IsEqualAnimalsSound()
        {
            Assert.AreEqual("Pik pik pik", _mouse.MakeSound());
            Assert.AreEqual("Miau...", _cat.MakeSound());
        }

        [Test]
        public void EatFood_EatsVegtables_ReturnsAmountOrError()
        {
            string cat = "Cat Lucijs, no breed, 4,9, Latvia, 6";
            string mouse = "The Mouse is not eating that type of food!";

            Assert.AreEqual(cat, _cat.EatFood(_meat));
            Assert.AreEqual(mouse, _mouse.EatFood(_meat));
        }

        [Test]
        public void ShowAnimal_ReturnAllAnimalParameters()
        {
            string cat = "Cat Lucijs, no breed, 4,9, Latvia, 3";
            string mouse = "The Mouse Minnija, 0,4, House, 1";

            Assert.AreEqual(cat, _cat.ShowAnimal());
            Assert.AreEqual(mouse, _mouse.ShowAnimal());
        }
    }
}