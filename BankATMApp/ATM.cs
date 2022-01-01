namespace BankATMApp
{
    public class ATM
    {
        private int id;
        private string location;
        private Bank maintainedBy;
        public DebitCard? obtainedDebitCard;
        public List<Transaction> transactions = new List<Transaction>();

        public ATM(int paramId, string paramLocation, Bank paramMaintainedBy)
        {
            this.id = paramId;
            this.location = paramLocation;
            this.maintainedBy = paramMaintainedBy;
        }
        public void InsertCard(string v)
        {
            this.obtainedDebitCard = maintainedBy.ManagesDebitCard().Find(debitCard => debitCard.OwnedBy == v);
        }

        public bool VerifyPIN(int paramPIN)
        {
            return this.obtainedDebitCard.VerifyPIN(paramPIN);
        }

        public void ProcessTransaction(char paramOption, decimal paramAmount)
        {
            transactionFunctions()[paramOption](paramAmount);
        }

        private Dictionary<char, Action<decimal>> transactionFunctions() => new Dictionary<char, Action<decimal>>()
        {
            {
                'W', (paramAmount) => {
                    this.obtainedDebitCard.ProcessDebitTransaction(paramAmount);
                    this.transactions.Add(new WithdrawalTransaction(this.transactions.Count + 1, this.obtainedDebitCard.Accounts[1]));
                }
            },
            {
                'T', (paramAmount) => {
                    this.obtainedDebitCard.ProcessCreditTransaction(paramAmount);
                    this.transactions.Add(new TransferTransaction(this.transactions.Count + 1, this.obtainedDebitCard.Accounts[1]));
                }
            }
        };

    }
}