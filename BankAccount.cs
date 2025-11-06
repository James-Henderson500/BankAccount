using System;
public class BankAccount
{
    private decimal balance;

    public BankAccount()
    {
        balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

        public decimal GetBalance()
        {
            return balance;
        }
}