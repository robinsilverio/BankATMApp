using BankATMApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class CustomerTests
    {
        private Customer testSubjectCustomer;

        private void ArrangeBankAndCustomer()
        {
            Bank testSubjectBank = new Bank(0001, "ING", "Private");
            this.testSubjectCustomer = new Customer(0001, "Robin Medeiros Silvério", "Teststraat 123", "00/00/00", testSubjectBank);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerOwnsOneOrMoreDebitCard()
        {
            ArrangeBankAndCustomer();
            Assert.IsTrue(testSubjectCustomer.Owns().Count >= 1);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerHasOneOrMoreAccounts()
        {
            // Arrange
            ArrangeBankAndCustomer();
            // Act
            int actualSize = testSubjectCustomer.Owns()[0].Access().Count;
            // Assert
            Assert.AreEqual(2, actualSize);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerHasSavingAccount()
        {
            // Arrange
            ArrangeBankAndCustomer();
            // Act
            Account? actualAccount = testSubjectCustomer.Owns()[0].Access().Find(x => x.GetType() == typeof(SavingAccount));
            // Assert
            Assert.IsInstanceOfType(actualAccount, typeof(SavingAccount));
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerHasRegularAccount()
        {
            ArrangeBankAndCustomer();
            // Act
            Account? actualAccount = testSubjectCustomer.Owns()[0].Access().Find(x => x.GetType() == typeof(RegularAccount));
            // Assert
            Assert.IsInstanceOfType(actualAccount, typeof(RegularAccount));
        }
    }
}
