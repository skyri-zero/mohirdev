namespace mohirdev;

public class Book
{
    public string name = "Default";
    private string _author = "Citizens";
    private double _price = 9.99;

    public Book()
    {
        Console.WriteLine($"Book {name}, price: {_price}$, author: {_author}");
    }
    
    public Book(string tempName, string author, double price)
    {
        name = tempName;
        _author = author;
        _price = price;
        Console.WriteLine($"Book {name}, price: {_price}$, author: {_author}");
    }

    public void Print()
    {
        Console.WriteLine($"Book: {name}, price: {_price}$, author: {_author}");
    }

    public void ChangeName(string tempName)
    {
        Console.WriteLine($"Name of the book is changed\n{name} --> {tempName}");
        name = tempName;
    }
}