using System.Threading.Channels;

namespace mohirdev;

public class Tanlash1
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
public class Tanlash2
{
    public static void TaskOne()
    {
        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine()!);

        if (minutes >= 0)
        {
            Console.WriteLine($"{minutes} ==> {minutes / 60}:{minutes % 60}");
        }
        else
            Console.WriteLine("Enter valid number!!!");
    }

    public static void TaskTwo()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()!);

        if (age is > 0 and <= 12)
            Console.WriteLine("Child");
        else if(age is > 12 and <=19)
            Console.WriteLine("Teen");
        else if(age is > 19 and <=59)
            Console.WriteLine("Old");
        else if(age is > 59)
            Console.WriteLine("Elderly");
        else
            Console.WriteLine("Enter valid age!!!");
    }

    public static void TaskThree()
    {
        Console.Write($"Enter 1-st subject's score: ");
        int first = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter 2-st subject's score: ");
        int second = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter 3-st subject's score: ");
        int third = int.Parse(Console.ReadLine()!);

        if (first is > 100 or < 0 || second is > 100 or < 0 || third is > 100 or < 0)
            Console.WriteLine("Enter numbers between 0 and 100.");
        else
        {
            double avg = (first + second + third) / 3.0;
        
            Console.WriteLine($"Your average score is {(int)avg}, " + (avg is > 79 and <= 100
                ? "Great" 
                : avg is > 59 and <=79 
                    ? "Good"
                    : avg is > 39 and <=59
                        ? "Acceptable"
                        : avg <= 39
                            ? "Bad"
                            : "Enter valid scores!!!")
            );
        }
    }

    public static void TaskFour()
    {
        Random random = new Random();
        int chosenNumber = random.Next(1, 101);
        Console.Write("Enter any number between 1-100: ");
        while (true)
        {
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(usersNumber - chosenNumber > 10
                ? "A lot smaller"
                : chosenNumber - usersNumber > 10
                    ? "A lot bigger"
                    : usersNumber > chosenNumber
                        ? "Smaller"
                        : usersNumber < chosenNumber
                            ? "Bigger"
                            : usersNumber == chosenNumber
                                ? "You're right. Well done!"
                                : "Enter valid numbers"
            );
            if(usersNumber == chosenNumber)
                break;
        }
    }
}

public class Tanlash3
{
    public static void TaskOne()
    {
        Console.Write("Enter any word: ");
        string word = Console.ReadLine()!;
        int n = word.Length;

        bool isPolindrome = false;
        for (int i = 0; i < n; i++)
        {
            if (word[i] == word[n-1-i])
                isPolindrome = true;
            else
            {
                isPolindrome = false;
                break;
            }
        }

        if (isPolindrome)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not palindrome");
    }
    
    public static void TaskTwo()
    {
        Console.Write("Enter temperature in C: ");
        var temp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Type 1-for Kelvin, 2-Fahrenheit, any key for both:");
        int choice = Convert.ToInt32(Console.ReadLine());

        double fahrenheit = (temp * 9/5) + 32;
        double kelvin = temp + 273.15;
        switch (choice)
        {
            case 1:
                Console.WriteLine($"{temp} C = {kelvin} K");
                break;
            case 2:
                Console.WriteLine($"{temp} C = {fahrenheit} F");
                break;
            default:
                Console.WriteLine($"{temp} C = {kelvin} K = {fahrenheit} F");
                break;
        }
    }

    public static void TaskThree()
    {
        Console.Write("Enter numbers: ");

        string num = Console.ReadLine()!;
        int[] nums = num.Split(',').Select(int.Parse).ToArray();

        Console.WriteLine("Sorted ascending: " + string.Join(", ",  nums.OrderBy(n => n)));
        Console.WriteLine("Sorted descending: " + string.Join(", ",  nums.OrderByDescending(n => n)));
    }

    public static void TaskFour()
    {
        Console.Write("Enter any sentence: ");
        string sentence = Console.ReadLine()!;

        string countedChars = "";

        foreach (char c in sentence)
            if (!countedChars.Contains(c))
            {
                int count = 0;
                foreach (char ch in sentence)
                    if (ch == c) count++;
                
                countedChars += c;
                Console.WriteLine($"'{c}': {count} marta");
            }
    }
}