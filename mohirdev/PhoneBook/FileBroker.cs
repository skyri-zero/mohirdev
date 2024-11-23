namespace mohirdev.PhoneBook;

public class FileBroker
{
    private readonly string _fileName = "contacts.txt";

    public void SaveContacts(List<string> contacts)
    {
        try
        {
            File.WriteAllLines(_fileName, contacts);
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to save contacts: {e.Message}");
        }
    }

    public List<string> ReadContacts()
    {
        try
        {
            if (File.Exists(_fileName))
                return new List<string>(File.ReadAllLines(_fileName));
            return new List<string>();
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to read contacts: {e.Message}");
        }
    }
}