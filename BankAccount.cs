using System;


namespace BankAccountSystem
{
    public class BankAccount
    {
        private decimal balance;
        private decimal InterestRate;

        public BankAccount()
        {
            balance = 0;
            InterestRate = 0.03m;
        }

        public decimal CalculateInterest()
        {
            if (balance > 0)
            return balance * InterestRate;
        }
        return 0;
    }
    public decimal CalculateCompoundInterest(int years)
    {
        if (balance > 0 && years > 0)
        {
            return balance * (decimal)(Math.Pow((double)(1 + InterestRate), years));
        }
        return 0;
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
                return balance * InterestRate;
            }
            return 0;
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
        public void ApplyInterest()
        {
            decimal interestAmount = CalculateInterest();

            if (interestAmount > 0)
            {
                balance += interestAmount;
                Console.WriteLine("Interest applied: £" + interestAmount);
            }
            else
            {
                Console.WriteLine("No interest to apply.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}