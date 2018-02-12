using System;

public class BankAccounts
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();

        bankAccount.ID = 1;
        bankAccount.Balance = 15;

        Console.WriteLine($"Account {bankAccount.ID}, balance {bankAccount.Balance}");
    }
}

