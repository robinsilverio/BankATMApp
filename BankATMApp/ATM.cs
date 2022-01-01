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

        public void ProcessTransaction(int paramOption, decimal paramAmount)
        {
            if (paramOption == 'W' || paramOption == 'w')
            {
                this.obtainedDebitCard.ProcessDebitTransaction(paramAmount);
                this.transactions.Add(new WithdrawalTransaction(this.transactions.Count + 1, this.obtainedDebitCard.Accounts[1]));
            }
            else
            {
                this.obtainedDebitCard.ProcessCreditTransaction(paramAmount);
                this.transactions.Add(new TransferTransaction(this.transactions.Count + 1, this.obtainedDebitCard.Accounts[1]));
            }
        }
    }
}