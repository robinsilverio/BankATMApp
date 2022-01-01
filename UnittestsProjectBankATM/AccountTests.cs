using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankATMApp;
using System;

namespace BankATMApp
{
    [TestClass]
    public class AccountTests
    {

        private Account testSubjectAccount;

        private void ArrangeRegularAccount()
        {
            testSubjectAccount = new RegularAccount(0001, "Robin Medeiros Silvério");
        }
        private void ArrangeSavingAccount()
        {
            testSubjectAccount = new SavingAccount(0001, "Robin Medeiros Silvério");
        }

        private void ActIncreaseFunds()
        {
            testSubjectAccount.Credit(100);
        }
        private void ActDecreaseFunds()
        {
            testSubjectAccount.Credit(100);
            testSubjectAccount.Debit(10);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsIncreasedInRegularAccount()
        {
            ArrangeRegularAccount();
            ActIncreaseFunds();
            Assert.AreEqual(100, testSubjectAccount.Funds);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsDecreasedInRegularAccount()
        {
            ArrangeRegularAccount();
            ActDecreaseFunds();
            Assert.AreEqual(90, testSubjectAccount.Funds);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsIncreasedInSavingsAccount()
        {
            ArrangeSavingAccount();
            ActIncreaseFunds();
            Assert.AreEqual(100, testSubjectAccount.Funds);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsDecreasedInSavingsAccount()
        {
            ArrangeSavingAccount();
            ActDecreaseFunds();
            Assert.AreEqual(90, testSubjectAccount.Funds);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsRemainZeroAfterDebitDueNegativeFundsDisallowed()
        {
            ArrangeRegularAccount();
            testSubjectAccount.Debit(10);
            Assert.AreEqual(0, testSubjectAccount.Funds);
        }
    }
}
