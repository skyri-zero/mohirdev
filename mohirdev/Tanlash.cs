using System.Threading.Channels;

namespace mohirdev;

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