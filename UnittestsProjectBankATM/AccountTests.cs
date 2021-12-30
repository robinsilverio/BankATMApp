using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankATMApp;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class AccountTests
    {

        private Account testSubjectAccount;

        public void ArrangeAccount(Account paramAccount)
        {
            testSubjectAccount = paramAccount;
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsIncreasedInRegularAccount()
        {
            ArrangeAccount(new RegularAccount(0001, "Robin Medeiros Silvério"));
            testSubjectAccount.Credit(100);
            Assert.AreEqual(100, testSubjectAccount.Funds);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_FundsIsIncreasedInSavingsAccount()
        {
            ArrangeAccount(new SavingAccount(0001, "Robin Medeiros Silvério"));
            testSubjectAccount.Credit(100);
            Assert.AreEqual(100, testSubjectAccount.Funds);
        }
    }
}
