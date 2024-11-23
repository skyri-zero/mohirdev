namespace mohirdev.BankApp;

public class Account
{
    public string AccountNumber { get; private set; }
    private int Balance { get; set; }

    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("You cannot deposit less than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited {amount}$, Balance: {Balance}$");
    }

    public void Withdraw(int amount)
    {
        if (amount >= Balance)
        {
            Console.WriteLine("You cannot withdraw more than balance.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrew {amount}$, Balance: {Balance}$");
    }

    public int GetBalance() => Balance;
}