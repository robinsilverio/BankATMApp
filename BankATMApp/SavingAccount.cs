using BankATMApp.EnumClass;

namespace BankATMApp
{
    public class SavingAccount : Account
    {
        public SavingAccount(int paramAccountNumber, string ownedBy) : 
            base(paramAccountNumber, Enumerations.TypesOfAccounts.SAVING.ToString(), ownedBy)
        {
        }

        public override void Credit(decimal paramAmount)
        {
            base.Funds += paramAmount;
        }

        public override void Debit(decimal paramAmount)
        {
            base.Funds -= paramAmount;
        }
    }
}