namespace BankATMApp
{
    public class DebitCard
    {
        private int cardId;
        private string ownedBy;
        private int registeredPIN;
        private bool hasAccess = false;
        private List<Account> accounts;

        public string OwnedBy { get { return ownedBy; } set { ownedBy = value; } }
        public List<Account> Accounts { get { return accounts; } }
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

        public bool VerifyPIN(int paramPIN)
        {
            this.hasAccess = this.registeredPIN == paramPIN;
            return hasAccess;
        }

        public void ProcessDebitTransaction(decimal paramAmount)
        {
           this.accounts[1].Debit(paramAmount);
        }

        public void ProcessCreditTransaction(decimal paramAmount)
        {
            this.accounts[1].Credit(paramAmount);
        }
    }
}
