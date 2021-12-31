namespace BankATMApp
{
    public class ATM
    {
        private int id;
        private string location;
        private Bank maintainedBy;
        public DebitCard? obtainedDebitCard;

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
            return this.obtainedDebitCard.Access(paramPIN);
        }

    }
}