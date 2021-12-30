using BankATMApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class BankTests
    {
        public Bank testSubjectBank;

        public void ArrangeBank()
        {
            this.testSubjectBank = new Bank(0001, "ING", "Private");
        }
        
        [TestMethod]
        public void Should_ReturnTrue_When_BankHasATMs()
        {
            // Arrange
            ArrangeBank();
            int expectedBankItemsSize = 3;
            // Act
            int actualBankItemsSize = testSubjectBank.MaintainsATM().Count;
            // Assert
            Assert.AreEqual(expectedBankItemsSize, actualBankItemsSize);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_BankHasCustomers()
        {
            // Arrange
            ArrangeBank();
            int expectedBankCustomersSize = 3;
            // Act
            int actualBankCustomersSize = testSubjectBank.ManagesCustomers().Count;
            // Assert
            Assert.AreEqual(expectedBankCustomersSize, actualBankCustomersSize);
        }
    }
}