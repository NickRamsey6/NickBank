
namespace BankingLib
{
    public class CardHolder(int pin, string cardHolderFname, string cardHolderLname, double balance)
    {
        public int Pin { get; set; } = pin;
        public string CardHolderFname { get; set; } = cardHolderFname;
        public string CardHolderLname { get; set; } = cardHolderLname;
        public double Balance { get; set; } = balance;

        public double DepositFunds(double balance, double depositAmount)
        {
            return balance + depositAmount;
        }

        public double WithdrawFunds(double balance, double withdrawAmount)
        {

            return balance - withdrawAmount;
        }
    }
}
