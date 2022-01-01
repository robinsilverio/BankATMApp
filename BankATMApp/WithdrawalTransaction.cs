using BankATMApp.EnumClass;

namespace BankATMApp
{
    public class WithdrawalTransaction : Transaction
    {
        public WithdrawalTransaction(int v1, Account v2) : 
            base(v1, Enumerations.TypesOfTransactions.WITHDRAW.ToString(), v2)
        {

        }
    }
}