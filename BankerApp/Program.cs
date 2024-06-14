﻿using BankingLib;

List<CardHolder> cardHolders = new List<CardHolder>();
cardHolders.Add(new CardHolder(1111, "Nick", "Lname", 99.99));
cardHolders.Add(new CardHolder( 2222, "Bob", "Lname", 599.99));



Console.WriteLine("Welcome to Banking App!");
Console.WriteLine("Please Enter your PIN: ");
CardHolder currentAccount;

while (true)
{
    try
    {
        int pinInt = int.Parse(Console.ReadLine()!);
        currentAccount = cardHolders.FirstOrDefault(a => a.Pin == pinInt)!;
        if (currentAccount != null)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid pin. Try again.");
        }
    }
    catch
    {
        Console.WriteLine("Invalid pin. Try again.");
    }
}




Console.WriteLine($"Hello {currentAccount.CardHolderFname}!");
Console.WriteLine("How can we help you today?");

string[] menuOptions = { "View Balance", "Withdraw", "Deposit" };

for (int i = 0; i < menuOptions.Length; i++)
{
    Console.WriteLine($"{i + 1} {menuOptions[i]}");
}

string? menuSelection = Console.ReadLine();
switch (menuSelection)
{
    case "1":
        Console.Clear();
        Console.WriteLine($"Your current balance is ${currentAccount.Balance}");
        break;

    case "2":
        Console.Clear();
        Console.WriteLine("Please enter the amount you would like to withdraw:");
        string withdrawString = Console.ReadLine()!;
        double withdrawAmount = double.Parse(withdrawString);
        if (withdrawAmount > currentAccount.Balance)
        {
            throw new ArgumentException(
                $"You have insufficent funds to withdraw ${withdrawAmount}! Your current balance is {currentAccount.Balance}");
        }
        double newWithdrawnBalance = currentAccount.WithdrawFunds(currentAccount.Balance, withdrawAmount);
        Console.WriteLine($"Your new balance is {newWithdrawnBalance:C}");
        break;


    case "3":
        Console.Clear();
        Console.WriteLine("Please enter the amount you would like to deposit:");
        string depositString = Console.ReadLine()!;
        double depositAmount = double.Parse(depositString);
        double newDepositedBalance = currentAccount.DepositFunds(currentAccount.Balance, depositAmount);
        Console.WriteLine($"Your new balance is {newDepositedBalance:C}");
        break;


}
