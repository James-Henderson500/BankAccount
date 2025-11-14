using System;

namespace BankAccountSystem
{
    public class BankAccount
    {
        private decimal balance;
        private decimal interestRate;
        public BankAccount()
        {
            balance = 0;
            interestRate = 0.03m;
        }

        public decimal CalculateInterest()
        {
            if (balance > 0)
            {
                return balance * interestRate;
            }
            return 0;
        }
        public void ApplyCompoundInterestAnnually(int years)
        {
            if (balance > 0 && years > 0)
            {
                decimal originalBalance = balance;

                for (int i = 1; i <= years; i++)
                {
                    decimal interestAmount = balance * interestRate;
                    balance += interestAmount;
                    Console.WriteLine($"Year {i}: Interest = £{interestAmount:F2}, Balance = £{balance:F2}");
                }

                decimal totalInterest = balance - originalBalance;
                Console.WriteLine($"Total interest earned over {years} years: £{totalInterest:F2}");
                Console.WriteLine($"Final balance: £{balance:F2}");
            }
            else
            {
                Console.WriteLine("No interest applied. Check balance and years.");
            }
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
}