using NUnit.Framework;

namespace Account.Tests
{
    public class Tests
    {
        private Account _account;
        [SetUp]
        public void Setup()
        {
            _account = new Account("Kristines account", 3000);
        }

        [Test]
        public void Withdawl_Remove250_Returns2750()
        {
            // Act
            var test = _account.Withdrawal(250);

            // Assert
            Assert.AreEqual(2750, test);
        }

        [Test]
        public void Deposit_Add500_Returns3500()
        {
            // Act
            var test = _account.Deposit(500);

            // Assert
            Assert.AreEqual(3500, test);
        }

        [Test]
        public void Balance_ReturnCurrentBalance()
        {
            // Act
            var test = _account.Balance();

            // Assert
            Assert.AreEqual(3000, test);
        }
    }
}