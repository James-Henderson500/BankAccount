using System;

using BankAccountSystem;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.Deposit(100);
        Console.WriteLine("Balance after depositing £100: " + account.GetBalance());

        account.Withdraw(30);
        Console.WriteLine("Balance after withdrawing £30: " + account.GetBalance());

        account.Withdraw(70);
        Console.WriteLine("Balance after withdrawing £70: " + account.GetBalance());

        account.CalculateInterest();
        Console.WriteLine("Interest on balance: £" + account.GetBalance());

        account.Deposit(200);
        Console.WriteLine("Balance after depositing £200: " + account.GetBalance());

        account.ApplyCompoundInterestAnnually(6);
        Console.WriteLine();


        }
}