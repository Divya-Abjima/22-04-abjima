public class BankAccount
{
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        Balance -= amount;
    }
}
public class BankAccountTests
{
    private readonly BankAccount bankAccount;

    public BankAccountTests()
    {
        bankAccount = new BankAccount();
    }

    [Fact]
    public void Deposit_ShouldIncreaseBalance()
    {
        bankAccount.Deposit(100);

        Assert.Equal(100, bankAccount.Balance);
    }

    [Fact]
    public void Withdraw_ShouldDecreaseBalance()
    {
        bankAccount.Deposit(100);

        bankAccount.Withdraw(50);

        Assert.Equal(50, bankAccount.Balance);
    }

    [Fact]
    public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
    {
        bankAccount.Deposit(100);

        var exception = Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(150));

        Assert.Equal("Insufficient funds", exception.Message);
        Assert.Equal(100, bankAccount.Balance);
    }

    [Theory]
    [InlineData(100, 50, 50)]
    [InlineData(100, 100, 0)]
    [InlineData(100, 150, -50)]
    public void Withdraw_ShouldUpdateBalance(int initialBalance, int withdrawAmount, int expectedBalance)
    {
        bankAccount.Deposit(initialBalance);

        bankAccount.Withdraw(withdrawAmount);

        Assert.Equal(expectedBalance, bankAccount.Balance);
    }
}
