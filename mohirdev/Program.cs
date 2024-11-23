using mohirdev.PhoneBook;

class Program
{
    public static void Main()
    {
        LoggingBroker logger = new LoggingBroker();
        FileBroker file = new FileBroker();
        PhoneBookService phoneBook = new PhoneBookService(logger, file);

        while (true)
        {
            Console.WriteLine("\nCONTACTS\n\n1 - Add\n2 - Remove\n3 - Edit\n4 - Search\n5 - Show All\nAny key - Exit");
            Console.Write("Choose action: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 0)
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter contact: ");
                        try
                        {
                            phoneBook.AddContact(Console.ReadLine()!);
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                        }
                        break;
                    case 2:
                        Console.Write("Enter contact: ");
                        try
                        {
                            phoneBook.RemoveContact(Console.ReadLine()!);
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                        }
                        break;
                    case 3:
                        Console.Write("Enter old contact and new contact: ");
                        try
                        {
                            phoneBook.EditContact(Console.ReadLine()!, Console.ReadLine()!);
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                        }
                        break;
                    case 4:
                        Console.Write("Enter name: ");
                        try
                        {
                            phoneBook.SearchContact(Console.ReadLine()!);
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                        }
                        break;
                    case 5:
                        phoneBook.ShowContacts();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            else
                break;
        }
    }
}