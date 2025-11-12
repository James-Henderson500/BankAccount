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
        public decimal CompoundInterest(int years)
         {
        if (balance > 0)
        {
            decimal compounded = balance * (decimal)(Math.Pow((double)(1 + interestRate), years) - 1);
            Console.WriteLine($"Compounded Interest: £{compounded:F2}");
            return compounded;   
                
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