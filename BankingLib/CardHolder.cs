
namespace BankingLib
{
    // Use a class primary constructor to define the CardHolder class
    public class CardHolder(int pin, string cardHolderFname, string cardHolderLname, double balance)
    {
        // Set Class properties
        public int Pin { get; set; } = pin;
        public string CardHolderFname { get; set; } = cardHolderFname;
        public string CardHolderLname { get; set; } = cardHolderLname;
        public double Balance { get; set; } = balance;

        // Define a Deposit Class method
        public double DepositFunds(double balance, double depositAmount)
        {
            return balance + depositAmount;
        }

        // Define a Withdraw Class method
        public double WithdrawFunds(double balance, double withdrawAmount)
        {

            return balance - withdrawAmount;
        }
    }
}
