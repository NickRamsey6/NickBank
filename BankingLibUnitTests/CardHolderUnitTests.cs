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
    }
}