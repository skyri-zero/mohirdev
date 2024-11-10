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

Car malibu = new Car();
Car teslaX = new Car("Tesla model X", 2021, 65_990, 249);
Car offRoad = new Car("Tesla Cybertruck", 2022, 79_990, 180);

Console.WriteLine(malibu.GetCarInfo());
Console.WriteLine(teslaX.GetCarInfo());
Console.WriteLine(offRoad.GetCarInfo());

Console.WriteLine();

malibu.CalculateDepreciation(8);
teslaX.CalculateDepreciation(5);
offRoad.CalculateDepreciation();

