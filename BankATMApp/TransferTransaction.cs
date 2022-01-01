using BankATMApp.EnumClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATMApp
{
    public class TransferTransaction : Transaction
    {
        public TransferTransaction(int paramId, Account paramAccount) : 
            base(paramId, Enumerations.TypesOfTransactions.TRANSFER.ToString(), paramAccount)
        {

        }
    }
}
