using BankingLib;

namespace BankingLibUnitTests
{
    public class CardHolderUnitTests
    {
        [Fact]
        public void TestDeposit50()
        {
            // Arrange
            CardHolder testAccount = new(pin: 2222, cardHolderFname: "Test", cardHolderLname: "Test-Lname", balance: 10);
            double depositAmount = 50;
            double expected = 60;

            // Act
            double actual = testAccount.DepositFunds(testAccount.Balance, depositAmount);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWithdraw50()
        {
            // Arrange
            CardHolder testAccount = new(pin: 2222, cardHolderFname: "Test", cardHolderLname: "Test-Lname", balance: 90);
            double withdrawAmount = 50;
            double expected = 40;

            // Act
            double actual = testAccount.WithdrawFunds(testAccount.Balance, withdrawAmount);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}