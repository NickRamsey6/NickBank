
namespace BankingLib
{
    public class CardHolder(int pin, string cardHolderFname, string cardHolderLname, double balance)
    {
        public int Pin { get; set; } = pin;
        public string CardHolderFname { get; set; } = cardHolderFname;
        public string CardHolderLname { get; set; } = cardHolderLname;
        public double Balance { get; set; } = balance;

        public double DepositFunds(double depositAmount, double balance)
        {
            return depositAmount + balance;
        }

        public double WithdrawFunds(double withdrawAmount, double balance)
        {

            return balance - withdrawAmount;
        }
    }
}
