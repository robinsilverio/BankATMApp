using BankATMApp.EnumClass;

namespace BankATMApp
{
    public class SavingAccount : Account
    {
        public SavingAccount(int paramAccountNumber, string ownedBy) : 
            base(paramAccountNumber, Enumerations.TypesOfAccounts.SAVING.ToString(), ownedBy)
        {
        }

        public override void Credit(int paramAmount)
        {
            base.Funds += paramAmount;
        }

        public override void Debit(int paramAmount)
        {
            base.Funds -= paramAmount;
        }
    }
}