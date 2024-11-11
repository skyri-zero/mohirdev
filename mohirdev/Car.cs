namespace mohirdev;

public class Car
{
    string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    decimal Speed { get; set; }

    public Car()
    {
        Model = "Chevrolet Malibu 2";
        Year = 2022;
        Price = 25_000;
        Speed = 220;
    }
    
    public Car(string model, int year, decimal price, decimal speed)
    {
        Model = model;
        Year = year;
        Price = price;
        Speed = speed;
    }

    public string GetCarInfo() =>
        $"Model: {Model}, Year: {Year}, Price: {Price}$, Speed: {Speed}";

    public void CalculateDepreciation(int years)
    {
        if (years < 0) Console.WriteLine("Years must be greater than or equal to 0");
        else
        {
            decimal currentPrice = Price * (decimal)Math.Pow(1 - 0.1, years);
            Console.WriteLine($"{Model}'s price after {years} years: {currentPrice}$");
        }
    }
    
    public void CalculateDepreciation()
    {
        if (DateTime.Now.Year - Year < 0) Console.WriteLine("Years must be greater than or equal to 0");
        else
        {
            decimal currentPrice = Price * (decimal)Math.Pow(1 - 0.1, DateTime.Now.Year - Year);
            Console.WriteLine($"{Model}'s current price: {currentPrice}$");
        }
    }

    public static void GetCarsInRange(List<Car> cars, decimal low, decimal high)
    {
        foreach (var car in cars)
            if (car.Price <= high && car.Price >= low)
                Console.WriteLine(car.GetCarInfo());
    }
}