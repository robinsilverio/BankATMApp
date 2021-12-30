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
        private DebitCard testSubjectDebitCard;
        private bool isAccessGranted;

        private void ArrangeBankATMAndDebitCardTestSubjects()
        {
            Bank testSubjectBank = new Bank(0001, "ING", "Private");
            testSubjectATM = new ATM(0001, "Amsterdam - Centraal Station", testSubjectBank);
            testSubjectDebitCard = new DebitCard(0001, "Robin Medeiros Silvério", 1234);
        }

        private void ActGrantAccessWithPIN(int paramPIN)
        {
            isAccessGranted = testSubjectATM.verifyPIN(testSubjectDebitCard, paramPIN);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_ObtainingDebitCardAfterInserting()
        {
            ArrangeBankATMAndDebitCardTestSubjects();
            
            DebitCard? actualDebitCard = testSubjectATM.InsertCard("Robin Medeiros Silvério");

            Assert.AreEqual(testSubjectDebitCard.OwnedBy, actualDebitCard.OwnedBy);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AccessToAccountsIsGrantedByCorrectPin()
        {
            ArrangeBankATMAndDebitCardTestSubjects();

            ActGrantAccessWithPIN(1234);

            Assert.AreEqual(true, isAccessGranted);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_AccessToAccountsIsNotGrantedByIncorrectPin()
        {
            ArrangeBankATMAndDebitCardTestSubjects();

            ActGrantAccessWithPIN(5555);

            Assert.AreEqual(false, isAccessGranted);
        }
        
    }
}
