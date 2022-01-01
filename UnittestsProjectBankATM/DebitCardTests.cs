using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankATMApp;

namespace UnittestsProjectBankATM
{
    [TestClass]
    public class DebitCardTests
    {
        [TestMethod]
        public void Should_ReturnTrue_WhenUserIsAuthorizedUsingPIN()
        {
            DebitCard testSubjectDebitCard = new DebitCard(0001, "Robin Medeiros Silvério", 1234);
            
            Assert.IsTrue(testSubjectDebitCard.VerifyPIN(1234));
        }

        [TestMethod]
        public void Should_ReturnFalse_WhenUserIsUnauthorizedUsingWrongPIN()
        {
            DebitCard testSubjectDebitCard = new DebitCard(0001, "Robin Medeiros Silvério", 0123);
            
            Assert.IsFalse(testSubjectDebitCard.VerifyPIN(1234));
        }
    }
}
