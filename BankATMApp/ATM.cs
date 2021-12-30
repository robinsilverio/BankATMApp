namespace BankATMApp
{
    public class ATM
    {
        private int id;
        private string location;
        private Bank maintainedBy;

        public ATM(int paramId, string paramLocation, Bank paramMaintainedBy)
        {
            this.id = paramId;
            this.location = paramLocation;
            this.maintainedBy = paramMaintainedBy;
        }
        public DebitCard? InsertCard(string v)
        {
            return maintainedBy.ManagesDebitCard().Find(debitCard => debitCard.OwnedBy == v);
        }

        public List<Account> VerifyPIN(DebitCard paramDebitCard, int paramPIN)
        {
            return paramDebitCard.Access(paramPIN);
        }
    }
}