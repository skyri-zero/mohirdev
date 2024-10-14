namespace mohirdev;

public class Tanlash
{
    public static void TaskOne()
    {
        string keyWord = "cOmPuTeR";
        
        Console.Write($"The key word is \" {keyWord} \"\nEnter any number: ");
        int wordLength = int.Parse(Console.ReadLine());

        if (wordLength >= keyWord.Length)
            Console.WriteLine(keyWord.ToUpper());
        else
            Console.WriteLine(keyWord.ToLower());
    }

    public static void TaskTwo()
    {
        int x = 15;
        int y = 10;

        if (x > y)
            Console.WriteLine("x is greater than y");
        else if(x < y)
            Console.WriteLine("x is less than y");
        else if(x == y)
            Console.WriteLine("x is equal to y");
        else
            Console.WriteLine("x and y are not comparable");
    }

    public static void TaskThree()
    {
        Console.WriteLine("Enter week day in UZ: ");
        string? weekDayUz = Console.ReadLine();

        string weekDayEn = weekDayUz.ToLower() switch
        {
            "dushanba" => "Monday",
            "seshanba" => "Tuesday",
            "chorshanba" => "Wednesday",
            "payshanba" => "Thursday",
            "juma" => "Friday",
            "shanba" => "Saturday",
            "yakshanba" => "Sunday",
            _ => "There is no week day like this!!!"
        };

        Console.WriteLine($"{weekDayUz.ToUpper()} ---> {weekDayEn}");
    }
}