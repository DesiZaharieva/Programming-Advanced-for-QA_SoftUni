using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _bankAccount = null!;

    //[SetUp]
    //public void Setup()
    //{
    //    this._bankAccount = new();
    //    _bankAccount = new();
    //}
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        //Arrange
        double input = 30.00;

        //Act
        BankAccount account = new BankAccount(input);

        //Assert
        Assert.AreEqual(input, account.Balance);

    }

        [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        //Arrange
        double initialBalance = 100.0;
        double depositAmount = 50.0;

        double expected = initialBalance + depositAmount;
        BankAccount account = new BankAccount(initialBalance);
        //Act
        account.Deposit(depositAmount);

        //Assert
        Assert.AreEqual(expected, account.Balance);


    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        double initialBalance = 100.0;
        double depositAmount = -50.0;
        BankAccount account = new BankAccount(initialBalance);



        //Act & Assert
        Assert.That(() => account.Deposit(depositAmount), Throws.ArgumentException);


    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawalAmount = 50.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act
        account.Withdraw(withdrawalAmount);

        // Assert
        double expectedBalance = initialBalance - withdrawalAmount;
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawalAmount = -50.0;
        BankAccount account = new BankAccount(initialBalance);

        //Act & Assert
        Assert.That(() => account.Withdraw(withdrawalAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawalAmount = 150.0;
        BankAccount account = new BankAccount(initialBalance);

        //Act & Assert
        Assert.That(() => account.Withdraw(withdrawalAmount), Throws.ArgumentException);
    }
}
