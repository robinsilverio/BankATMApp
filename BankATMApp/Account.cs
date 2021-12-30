namespace BankATMApp
{
    public abstract class Account
    {
        private int accountNumber;
        private string type;
        public string OwnedBy { get; set; }
        public decimal Funds { get; set; } = 0;

        public Account(int accountNumber, string paramType, string paramOwnedBy)
        {
            this.type = paramType;
            this.OwnedBy = paramOwnedBy;
            this.accountNumber = accountNumber;
        }

        public abstract void Credit(int paramAmount);
        public abstract void Debit(int paramAmount);
    }
}