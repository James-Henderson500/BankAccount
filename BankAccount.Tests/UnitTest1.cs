// using Xunit;

// namespace BankAccountSystem.Tests;
// using BankAccountSystem;
// public class UnitTest1
// {

//     [Fact]
//     public void CanCreateBankAccount()
//     {
//         // Arrange & Act
//         var account = new BankAccountSystem.BankAccount();

//         // Assert
//         Assert.NotNull(account);
//     }

//     [Fact]
//     public void InterestOnlyAppliesToPostiveBalances()
//     {
//         var account = new BankAccountSystem.BankAccount();
//         account.Deposit(1000);
//         decimal interest = account.CalculateInterest();
//         Assert.Equal(30, interest);

//         var emptyAccount = new BankAccountSystem.BankAccount();
//         decimal noInterest = emptyAccount.CalculateInterest();
//         Assert.Equal(0, noInterest);

//     }

//     [Fact]
//     public void InterestRateIsThreePercentByDefault()
//     {
//         // Arrange
//         var account = new BankAccountSystem.BankAccount();

//         // Act & Assert
//         Assert.Equal(0.03, account.InterestRate);
//     }

//     [Fact]
//     public void CanChangeInterestRate()
//     {
//         // Arrange
//         var account = new BankAccountSystem.BankAccount();

//         // Act
//         account.SetInterestRate(0.10);

//         // Assert
//         Assert.Equal(0.10, account.InterestRate);
//     }

//     [Fact]
//     public void InterestPaidAnnually()
//     {
//         // Arrange
//         var account = new BankAccountSystem.BankAccount();

//         account.SetInterestRate(0.10);
//         account.Deposit(10000);
//         int years_to_pay = 1;

//         // Act

//         account.PayInterest(years_to_pay);

//         // Assert

//         Assert.Equal(account.GetBalance(), 11000);
//     }

//     [Fact]
//     public void AnnualInterestCompoundsAnnually()
//     {
//         // Arrange
//         var account = new BankAccountSystem.BankAccount();

//         account.SetInterestRate(0.10);
//         account.Deposit(10000);
//         int years_to_pay = 2;

//         // Act

//         account.PayInterest(years_to_pay);

//         // Assert

//         Assert.Equal(account.GetBalance(), 12100);
//     }
    


// }
