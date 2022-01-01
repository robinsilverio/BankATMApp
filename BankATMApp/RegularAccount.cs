using BankATMApp.EnumClass;

namespace BankATMApp
{
    public class RegularAccount : Account
    {
        private bool disallowedNegative = true;

        public RegularAccount(int paramAccountNumber, string ownedBy) : 
            base(paramAccountNumber, Enumerations.TypesOfAccounts.REGULAR.ToString(), ownedBy)
        {
        }

        public override void Credit(decimal paramAmount)
        {
            base.Funds += paramAmount;
        }

        public override void Debit(decimal paramAmount)
        {
            if (disallowedNegative && base.Funds <= 0 && paramAmount > base.Funds)
            {
                Console.WriteLine("Sorry, your funds cannot be in negative.");
            } else
            {
                base.Funds -= paramAmount;
            }
        }

    }
}