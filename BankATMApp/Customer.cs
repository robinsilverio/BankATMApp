namespace BankATMApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public Bank BelongsTo { get; set; }

        public Customer(int paramId, string paramName, string paramAddress, string paramDOB, Bank paramBank)
        {
            this.Id = paramId;
            this.Name = paramName;
            this.Address = paramAddress;
            this.DOB = paramDOB;
            this.BelongsTo = paramBank;
        }

        public List<DebitCard> Owns()
        {
            return BelongsTo.ManagesDebitCard().Where(debitCard => debitCard.OwnedBy == this.Name).ToList();
        }
    }
}