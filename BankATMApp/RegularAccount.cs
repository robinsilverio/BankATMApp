namespace BankATMApp
{
    public class RegularAccount : Account
    {
        private int accountNumber;

        public RegularAccount(int paramAccountNumber, string ownedBy) : base("REGULAR", ownedBy)
        {
            this.accountNumber = paramAccountNumber;
        }

        public override void Credit(int paramAmount)
        {
            base.Funds += paramAmount;
        }
    }
}