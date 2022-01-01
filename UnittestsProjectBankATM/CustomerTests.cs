using BankATMApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class CustomerTests
    {
        private const int PIN = 0215;
        private Bank testSubjectBank;
        private Customer testSubjectCustomer;

        private void ArrangeBankAndCustomer()
        {
            testSubjectBank = new Bank(0001, "ING", "Private");
            testSubjectCustomer = new Customer(0001, "Robin Medeiros Silvério", "Teststraat 123", "00/00/00", testSubjectBank);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerOwnsOneOrMoreDebitCard()
        {
            ArrangeBankAndCustomer();
            Assert.IsTrue(testSubjectCustomer.Owns().Count >= 1);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_CustomerHasAccessToAccounts()
        {
            // Arrange
            ArrangeBankAndCustomer();
            // Act
            bool actualAccess = testSubjectCustomer.Owns()[0].VerifyPIN(PIN);
            // Assert
            Assert.AreEqual(true, actualAccess);
        }
    }
}
