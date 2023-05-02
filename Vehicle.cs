// Making a Vehicle class
public class Vehicle
{
    // Creating Fields 
    public string Name {get; set;}
    public int PassengerNumber {get; set;}
    public string VehicleColor {get; set;}
    public bool HasEngine {get; set;}
    public double TotalMilage {get; set;}

    // Constructor 1
    public Vehicle(string name, int passengerNumber, string vehicleColor, bool hasEngine)
    {
        Name = name;
        PassengerNumber = passengerNumber;
        VehicleColor = vehicleColor;
        HasEngine = hasEngine;
        TotalMilage = 0;
    }

    // Constructor 2
      public Vehicle(string name, string vehicleColor)
    {
        Name = name;
        PassengerNumber = 4;
        VehicleColor = vehicleColor;
        HasEngine = true;
        TotalMilage = 0;
    }

    // adding instantiated vehicles into a List
    public List<Vehicle> VehicleList {get; set;}

    public void Listing()
    {
        foreach (Vehicle car in VehicleList)
        {
            Console.WriteLine(car);
            car.ShowInfo();
        }
    }

    // Creating Methods
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($" Number of passengers allowed in the car: {PassengerNumber}");
        Console.WriteLine($" The vehicle's color is {VehicleColor}");
        Console.WriteLine($"Does it even have an engine? {HasEngine}");
        Console.WriteLine($" Total traveled milage {TotalMilage}");
    }
    public void Travel(int DistanceTraveled)
    {
        TotalMilage += DistanceTraveled;
    }
}