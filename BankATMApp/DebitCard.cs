namespace BankATMApp
{
    public class DebitCard
    {
        private int cardId;
        private string ownedBy;
        private int registeredPIN;
        private List<Account> accounts;

        public string OwnedBy { get { return ownedBy; } set { ownedBy = value; } }

        public DebitCard(int cardId, string ownedBy, int paramPin)
        {
            this.cardId = cardId;
            this.ownedBy = ownedBy;
            this.registeredPIN = paramPin;
            this.accounts = new List<Account>
            {
                new SavingAccount(0001, this.ownedBy),
                new RegularAccount(0001, this.ownedBy)
            };
        }

        public List<Account> Access()
        {
            return this.accounts;
        }

        public bool IsAccessGranted(int paramPIN)
        {
            return this.registeredPIN == paramPIN;
        }
    }
}
