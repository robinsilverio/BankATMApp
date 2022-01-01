using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankATMApp;
using static BankATMApp.EnumClass.Enumerations;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class TransactionsTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_ObjectIsOFWithDrawalTransactionClass()
        {
            Transaction testSubjectTransactions = new WithdrawalTransaction(0001, new RegularAccount(0001, "Robin Medeiros Silvério"));
            Assert.IsInstanceOfType(testSubjectTransactions, typeof(WithdrawalTransaction));
        }

        [TestMethod]
        public void Should_ReturnTrue_When_ObjectIsOfTransferTransactionClass()
        {
            Transaction testSubjectTransactions = new TransferTransaction(0001, new RegularAccount(0001, "Robin Medeiros Silvério"));
            Assert.IsInstanceOfType(testSubjectTransactions, typeof(TransferTransaction));
        }
    }
}
