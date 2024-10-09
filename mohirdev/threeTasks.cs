namespace mohirdev;

public class ThreeTasks {
    public static void TaskOne()
    {
        /*
        1. Doira yuzi va aylana uzunligini hisoblash
            Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
        */

        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        var S = Math.PI * Math.Pow(radius, 2);
        var L = 2 * Math.PI * radius;

        Console.WriteLine($"Length = {L}, Surface = {S}");

        Console.ReadLine();

        /*
        2. Valyuta konvertri
            Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.z
        */
        Console.WriteLine("-------------------------------------");

        Console.Write("\nEnter amount of JPY: ");
        double moneyAmount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Value of 1 JPY(89.38) in UZS: ");
        double currencyValue = Convert.ToDouble(Console.ReadLine());
        var inUzbekSum = moneyAmount * currencyValue;

        Console.WriteLine($"{moneyAmount} Japanese Yen equals to {inUzbekSum} Uzbek Sum");
        Console.Read();

        /*
        3. Yoshni hisoblash
            Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda ifodalang. Kabisa yilini hisobga olmang
        */

        Console.WriteLine("-------------------------------------\n");

        Console.Write("In what year were you born ? ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        int age = DateTime.Now.Year - birthYear;

        Console.WriteLine($"You are {age} years old or {age * 365} days old :)");
        Console.Read();
    }

    public static void TaskTwo()
    {
        /*
        Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
        */

        Console.Write("Enter first number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operation (=, -, /, *): ");
        char operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = firstNum + secondNum;
                break;
            case '-':
                result = firstNum - secondNum;
                break;
            case '/':
                if (secondNum == 0)
                    Console.WriteLine("Cannot divide by zero !!!");
                else
                    result = firstNum / secondNum;
                break;
            case '*':
                result = firstNum * secondNum;
                break;
            default:
                Console.WriteLine("Incorrect operation.");
                break;
        }
        if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
            Console.WriteLine($"Answer is: {result}");
        Console.Read();
        
        /*
        Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.
        */

        Console.WriteLine("-------------------------------------\n");
        
        Console.Write("Enter any positive integer N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The sum of numbers from 1 to {N} is: {(1 + N) / 2.0 * N}");
        Console.Read();
        
        /*
        Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.
        */
        
        Console.WriteLine("-------------------------------------\n");

        Console.Write("Enter any digit: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Yor digit is {(digit%2 ==1 ? "odd" : "even")}");
        Console.Read();
    }
    
    public static void TaskThree()
    {
        // 1-st task
        bool IsSimple(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        Console.Write("Enter any positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your number is {(IsSimple(num) ? "simple" : "not simple")}");
        
        // 2-nd task

        Console.Write("This numbers divisors are: ");
        for (int i = 2; i <= 10; i++)
        {
            if (num % i == 0)
            {
                Console.Write($"{i}, ");
            }
        }
        
        // 3-rd task

        Console.Write("\nInput number and degree with ENTER key: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int degree = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{number} ^ {degree} = {Math.Pow(number, degree)}");
        
        // 4-th task

        Console.WriteLine("\nEnter prices");
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum is {n1 + n2 + n3}");
        
        // 5-th task
        
        bool IsArmstrongNumber(int num)
        {
            string numStr = num.ToString();
            int power = numStr.Length;
            int sum = 0;

            foreach (char digit in numStr)
            {
                sum += (int)Math.Pow(int.Parse(digit.ToString()), power);
            }

            return sum == num;
        }

        Console.Write("Enter number: ");
        int armstrong = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{armstrong} is {(IsArmstrongNumber(armstrong) ? "Armstrong" : "not Armstrong")}");
        
        // 6-th task
        
        Console.Write("Enter Another number: ");
        int anotherNum = int.Parse(Console.ReadLine());

        int qualityDivisorsCount = CountQualityDivisors(anotherNum);
        Console.WriteLine($"Quality Numbers quantity: {qualityDivisorsCount}");

        static int CountQualityDivisors(int num)
        {
            int count = 0;

            for (int i = 1; i <= num / 2; i++)
                if (num % i == 0) count++;

            return count + 1; 
        }
    }
}