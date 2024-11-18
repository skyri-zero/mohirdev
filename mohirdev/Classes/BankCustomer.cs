namespace mohirdev.Classes;

public class BankCustomer
{
    public string Name { get; private set; }
    public Account Account { get; private set; }

    public BankCustomer (string name, Account account)
    {
        Name = name;
        Account = account;
    }
}