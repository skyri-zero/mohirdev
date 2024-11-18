namespace mohirdev.Classes;

public class Boxer
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    static public string? Surname { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    public Boxer(string name, string surname, int age, int weight)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Weight = weight;
    }

    public static void SortIntoCategories(List<Boxer> boxers)
    {
        Console.WriteLine("Light weight:");
        foreach (var boxer in boxers)
            if (boxer.Weight is >= 50 and < 76)
                boxer.GetBoxerInfo();
        
        Console.WriteLine("Mid weight:");
        foreach (var boxer in boxers)
            if (boxer.Weight is >= 76 and < 90)
                boxer.GetBoxerInfo();
        
        Console.WriteLine("Heavy weight:");
        foreach (var boxer in boxers)
            if (boxer.Weight >= 90)
                boxer.GetBoxerInfo();
    }

    void GetBoxerInfo()
    {
        Console.WriteLine($"Full name: {Name} {Surname}, Age: {Age}, Weight: {Weight}");
    }
}