namespace mohirdev.BankApp;

public class Bank
{
    private List<BankCustomer> _customers = new ();

    public BankCustomer OpenAccount(string name, string accountNumber)
    {
        Account newAccount = new Account(accountNumber);
        BankCustomer newCustomer = new BankCustomer(name, newAccount);
        _customers.Add(newCustomer);
        Console.WriteLine($"Account for {name} has been created, account number: {accountNumber}.");
        
        return newCustomer;
    }

    public void CloseAccount(string accountNumber)
    {
        var customer = _customers.Find(c => c.Account.AccountNumber == accountNumber);
        if (customer != null)
        {
            _customers.Remove(customer);
            Console.WriteLine($"Account for {accountNumber} has been closed.");
        }
        else
            Console.WriteLine($"Account for {accountNumber} does not exist.");
    }

    public void TransferFunds(string fromAccountNumber, string toAccountNumber, int amount)
    {
        var customerFrom = _customers.Find(c => c.Account.AccountNumber == fromAccountNumber);
        var customerTo = _customers.Find(c => c.Account.AccountNumber == toAccountNumber);
        if (customerFrom != null && customerTo != null)
        {
            if (customerFrom.Account.GetBalance() >= amount)
            {
                Console.WriteLine($"{amount}$ are being transferred from {fromAccountNumber} to {toAccountNumber}...\nSUCCESSFULLY !!!");
                
                Console.Write($"{customerFrom.Name} ");
                customerFrom.Account.Withdraw(amount);
                Console.Write($"{customerTo.Name} ");
                customerTo.Account.Deposit(amount);
            }
            else
                Console.WriteLine($"Account {fromAccountNumber} does not have enough funds to send.\nOperation Failed !!!");
        }
        else
            Console.WriteLine("Check account numbers for validness !\nOperation Failed !!!");
    }
}