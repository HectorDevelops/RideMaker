// Instantiation number 1
Console.WriteLine("This is the first instance's info: ");
Vehicle MyVehicle = new Vehicle("Otis", 8, "Green", true);

// ShowInfo Method 
MyVehicle.ShowInfo();
Console.WriteLine("==================================");

// Instantiation number 2
Console.WriteLine("This is the second instance's info: ");
Vehicle MyOtherVehicle = new Vehicle("Jazz", "Green");

MyOtherVehicle.Travel(5);
MyOtherVehicle.ShowInfo();

Console.WriteLine("==================================");

// Instantiation number 3
Console.WriteLine("This is the third instance's info: ");
Vehicle MyThirdVehicle = new Vehicle("Marisela", "Pink");

MyThirdVehicle.Travel(0);
MyThirdVehicle.ShowInfo();

Console.WriteLine("==================================");

// Instantiation number 4
Console.WriteLine("This is the fourth instance's info: ");
Vehicle MyFourthVehicle = new Vehicle("Sonia", 2, "Purple", true);

MyFourthVehicle.Travel(100);
MyFourthVehicle.ShowInfo();

Console.WriteLine("==================================");
Console.WriteLine("\n");

// Creating a list of the current instances 
List<Vehicle> VehicleList = new List<Vehicle>();
VehicleList.Add(MyVehicle);
VehicleList.Add(MyOtherVehicle);
VehicleList.Add(MyThirdVehicle);
VehicleList.Add(MyFourthVehicle);

// Loop through the List and have each vehicle run its ShowInfo() method
foreach (Vehicle car in VehicleList)
{
    car.ShowInfo();
    Console.WriteLine("=========");
}


