namespace BankATMApp
{
    public abstract class Account
    {
        private string type;
        public string OwnedBy { get; set; }
        public decimal Funds { get; set; } = 0;

        public Account(string paramType, string paramOwnedBy)
        {
            this.type = paramType;
            this.OwnedBy = paramOwnedBy;
        }

        public abstract void Credit(int paramAmount);

    }
}