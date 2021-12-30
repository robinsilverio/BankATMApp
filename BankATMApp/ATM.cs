namespace BankATMApp
{
    public class ATM
    {
        private int id;
        private string location;
        private string maintainedBy;

        public ATM(int paramId, string paramLocation, string paramMaintainedBy)
        {
            this.id = paramId;
            this.location = paramLocation;
            this.maintainedBy = paramMaintainedBy;
        }
    }
}