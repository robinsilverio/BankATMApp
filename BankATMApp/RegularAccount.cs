namespace BankATMApp
{
    public class RegularAccount : Account
    {
        private bool disallowedNegative = true;

        public RegularAccount(int paramAccountNumber, string ownedBy) : base(paramAccountNumber, "REGULAR", ownedBy)
        {
        }

        public override void Credit(int paramAmount)
        {
            base.Funds += paramAmount;
        }

        public override void Debit(int paramAmount)
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