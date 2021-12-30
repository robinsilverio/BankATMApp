namespace BankATMApp
{
    public class Bank
    {
        private int bankId;
        private string bankName;
        private string bankType;

        public string BankName { get { return bankName; } set { bankName = value; } }

        public Bank(int paramId, string paramName, string paramType)
        {
            bankId = paramId;
            bankName = paramName;
            bankType = paramType;
        }

        public List<Customer> ManagesCustomers()
        {
            return new List<Customer> {
                new Customer(0001, "Robin Medeiros Silverio", "Watercirkel 54", "17/12/1995", this),
                new Customer(0002, "Danny van Tol", "Teststraat 43", "02/04/85", this),
                new Customer(0003, "Sebastian Kurz", "Omikron 100", "11/19/90", this),
            };
        }

        public List<DebitCard> ManagesDebitCard()
        {
            return new List<DebitCard> {
                new DebitCard(0001, "Robin Medeiros Silvério", 0215),
                new DebitCard(0002, "Danny van Tol", 4124),
                new DebitCard(0003, "Sebastian Kurz", 2142),
            };
        }

        public List<ATM> MaintainsATM()
        {
            return new List<ATM> {
                new ATM(0001, "Amsterdam - Centraal Station", this),
                new ATM(0002, "Delft - De Markt", this),
                new ATM(0001, "Den Haag - Binnenhof", this),
            };
        }
    }
}
