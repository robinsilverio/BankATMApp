namespace BankATMApp
{
    public class SavingAccount : Account
    {
        private int accountNumber;

        public SavingAccount(int paramAccountNumber, string ownedBy) : base("SAVING", ownedBy)
        {
            this.accountNumber = paramAccountNumber;
        }

        public override void Credit(int paramAmount)
        {
            base.Funds += paramAmount;
        }
    }
}