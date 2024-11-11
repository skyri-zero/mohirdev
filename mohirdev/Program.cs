using System.Data;
using mohirdev;

/*string[] taskList = {"Do the dishes", "Do the chores", "Deadline on 13th of October"};
int[] isMarked = {};
    
TaskManager manager = new TaskManager(ref taskList, ref isMarked);
manager.Start();*/

/*Book fiction = new Book();
Book custom = new Book("Harry Potter", "J. K. Rowling", 55);

custom.name = "Alchemist";
custom.Print();

fiction.ChangeName("Ikigai");
fiction.Print();*/


List<Student> students = new ()
{
    new Student("Skyri", "Zero", 3, Rating.A),
    new Student("John", "Smiths", 2, Rating.C),
    new Student("Emily", "Jones", 3, Rating.B),
    new Student("Emma", "Stone", 1, Rating.A),
    new Student("Andrew", "Garfield", 4, Rating.D),
    new Student("Vlad", "Yeltsin", 2, Rating.B),
    new Student("Iosif", "Stalin", 1, Rating.D)
};

Console.Write("Enter student's grade: ");
int mark = Convert.ToInt32(Console.ReadLine());

Student.GetStudentWithMark(students, mark);

List<Car> cars = new()
{
    new Car(),
    new Car("Tesla model X", 2021, 65_990, 249),
    new Car("Tesla Cybertruck", 2022, 79_990, 180),
    new Car("Porsche 911", 2015, 120_000, 279),
    new Car("Toyota Supra", 2010, 56_990, 269)
};

Console.WriteLine();
Console.Write("Enter lowest value for car's price: ");
decimal low = decimal.Parse(Console.ReadLine()!);
Console.Write("Enter highest value for car's price: ");
decimal high = decimal.Parse(Console.ReadLine()!);

Car.GetCarsInRange(cars, low, high);

List<Boxer> boxers = new()
{
    new Boxer("Muhammed", "Ali", 45, 95),
    new Boxer("Mike", "Tyson", 38, 81),
    new Boxer("Jane", "Austin", 33, 68),
    new Boxer("Fredrick", "Huston", 26, 78),
    new Boxer("Johnathan", "Blade", 22, 91),
    new Boxer("Sarah", "Stone", 19, 58)
};

Console.WriteLine();
Boxer.SortIntoCategories(boxers);