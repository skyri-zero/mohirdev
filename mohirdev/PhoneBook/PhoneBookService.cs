namespace mohirdev.PhoneBook;

public class PhoneBookService
{
    LoggingBroker _logger = new();
    FileBroker _file = new();
    List<string> _contacts = new();

    public PhoneBookService(LoggingBroker logger, FileBroker file)
    {
        _logger = logger;
        _file = file;
        _contacts = file.ReadContacts();
    }

    public void AddContact(string? contact)
    {
        try
        {
            _contacts.Add(contact);
            _file.SaveContacts(_contacts);
            _logger.Log($"Added contact: {contact}");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }

    public void RemoveContact(string contact)
    {
        try
        {
            _contacts.Remove(contact);
            _file.SaveContacts(_contacts);
            _logger.Log($"Removed contact: {contact}");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }

    public void ShowContacts()
    {
        try
        {
            Console.WriteLine("\nContact List:");
            if (_contacts.Any())
                foreach (var contact in _contacts)
                    Console.WriteLine(contact);
            else
                Console.WriteLine("No contacts found");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }

    public void SearchContact(string contact)
    {
        try
        {
            var foundContacts = _contacts.Where(c => c.ToLower().Contains(contact.ToLower()));
            if (foundContacts.Any())
            {
                Console.WriteLine($"Found {foundContacts.Count()} contacts:");
                foreach (var foundContact in foundContacts)
                    Console.WriteLine(foundContact);
            }
            else
                _logger.Log($"No contacts found by name {contact}");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }

    public void EditContact(string oldContact, string newContact)
    {
        try
        {
            int index = _contacts.IndexOf(oldContact);
            if (index > -1)
            {
                _contacts[index] = newContact;
                _file.SaveContacts(_contacts);
                _logger.Log($"Edited contact from {oldContact} to {newContact}");
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }
}