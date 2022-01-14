using NUnit.Framework;

namespace PhoneDirectory.Tests
{
    public class PhoneDirectoryTests
    {
        private PhoneBook.PhoneDirectory _target;
        [SetUp]
        public void Setup()
        {
            _target = new PhoneBook.PhoneDirectory();
        }

        [Test]
        public void PutNumber_kristine26577489_ShouldContainKristine()
        {
            // Act
            _target.PutNumber("Kristine", "26577489");

            // Assert
            Assert.AreEqual("26577489", _target.GetNumber("Kristine"));
        }

        [Test]
        public void GetNumber_Kristine_ShouldReturnNull()
        {
            // Act
            var number = _target.GetNumber("Kristine");

            // Assert
            Assert.IsNull(number);
        }
    }
}