using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATMApp
{
    public class Transaction
    {
        private int transactionId;
        private DateTime transactionDate;
        private string type;
        private Account account;

        public Transaction(int paramId, string paramType, Account paramAccount)
        {
            this.transactionId = paramId;
            this.transactionDate = DateTime.Now;
            this.type = paramType;
            this.account = paramAccount;
        }
    }
}
