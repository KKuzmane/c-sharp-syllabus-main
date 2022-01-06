using NUnit.Framework;
using PhoneBook;

namespace Phonebook1.Tests
{
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [SetUp]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [Test]
        public void PutNumber_kristine26577489_ShouldContainKristine()
        {
            _target.PutNumber("Kristine", "26577489");
            
            Assert.AreEqual("26577489", _target.GetNumber("Kristine"));
        }

        [Test]
        public void GetNumber_Kristine_ShouldReturnNull()
        {
            var number = _target.GetNumber("Kristine");

            Assert.IsNull(null, number);
        }
    }
}