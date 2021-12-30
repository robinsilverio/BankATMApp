namespace BankATMApp
{
    public class SavingAccount : Account
    {
        public SavingAccount(int paramAccountNumber, string ownedBy) : base(paramAccountNumber, "SAVING", ownedBy)
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