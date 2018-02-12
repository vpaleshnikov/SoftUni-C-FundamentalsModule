using System;

public class BankAccountMethods
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();

        bankAccount.Id = 1;
        bankAccount.Deposit(15);
        bankAccount.Withdraw(10);

        Console.WriteLine(bankAccount);
    }
}