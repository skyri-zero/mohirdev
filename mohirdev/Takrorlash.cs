namespace mohirdev;

public class Takrorlash1
{
    public static void TaskOne()
    {
        int sum = 0;
        int i = 1;

        while (i <= 1000)
        {
            if (i % 2 == 1)
                sum += i;
            i++;
        }

        Console.WriteLine("The sum of odd numbers: " + sum);
    }

    public static void TaskTwo()
    {
        int[] arr = {23, 12, 43, 10, 5, 3, 9, 55, 32};
        int max = 0;
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= max)
                max = arr[i];
            if (arr[i] <= min)
                min = arr[i];
        }

        Console.WriteLine($"Max({max}) x Min({min}) = {max * min}");
    }

    public static void TaskThree()
    {
        Console.Write("Enter any positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        if (num > 0)
        {
            for (int i = 1; i <= num; i++)
                factorial *= i;
            Console.WriteLine($"Factorial of {num} is {factorial}");
        }
        else if (num < 0)
            Console.WriteLine("Enter valid number!!!");
        else
            Console.WriteLine("Factorial of 0 is " + factorial);
    }
}

public class Takrorlash2
{
    
}
