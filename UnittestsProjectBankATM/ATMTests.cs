using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankATMApp;
using System.Collections.Generic;
using System;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class ATMTests
    {
        private ATM testSubjectATM;

        private void ArrangeBankATMAndDebitCardTestSubjects()
        {
            Bank testSubjectBank = new Bank(0001, "ING", "Private");
            testSubjectATM = new ATM(0001, "Amsterdam - Centraal Station", testSubjectBank);
        }

        private bool ActGrantAccessWithPIN(int paramPIN)
        {
            testSubjectATM.InsertCard("Robin Medeiros Silvério");
            return testSubjectATM.VerifyPIN(paramPIN);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AccessToAccountsIsGrantedByCorrectPin()
        {
            ArrangeBankATMAndDebitCardTestSubjects();

            bool actAccess = ActGrantAccessWithPIN(0215);

            Assert.AreEqual(true, actAccess);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AccessToAccountsIsNotGrantedByIncorrectPin()
        {
            ArrangeBankATMAndDebitCardTestSubjects();

            bool actAccess = ActGrantAccessWithPIN(5555);

            Assert.AreEqual(false, actAccess);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_OptionWithdrawalIsChosenByUser()
        {
            ArrangeBankATMAndDebitCardTestSubjects();
            char expectedOption = 'W';
            decimal amount = 100;

            bool actAccess = ActGrantAccessWithPIN(0215);
            testSubjectATM.ProcessTransaction(expectedOption, amount);
            
            Assert.IsInstanceOfType(testSubjectATM.transactions[0], typeof(WithdrawalTransaction));
        }

        [TestMethod]
        public void Should_ReturnTrue_When_OptionTransferIsChosenByUser()
        {
            ArrangeBankATMAndDebitCardTestSubjects();
            char expectedOption = 'T';
            decimal amount = 100;

            bool actAccess = ActGrantAccessWithPIN(0215);
            testSubjectATM.ProcessTransaction(expectedOption, amount);

            Assert.IsInstanceOfType(testSubjectATM.transactions[0], typeof(TransferTransaction));
        }
        
    }
}
