using Task_6_oop;


Car car1 = new Car(new DateOnly(2002, 7, 1), "Toyota", 25000, "Anything", "12465465", "Red", 40.2, "Automatic", 15, "4");
Console.WriteLine("Car Details:");
Console.WriteLine($"Year: {car1.Year}");
Console.WriteLine($"Type: {car1.Type}");
Console.WriteLine($"Price: {car1.Price}JD");
Console.WriteLine($"Model: {car1.Model}");
Console.WriteLine($"Pallet No: {car1.PalletNo}");
Console.WriteLine($"Color: {car1.Color}");
Console.WriteLine($"Temperature: {car1.Tempreture}C");
Console.WriteLine($"GearBox: {car1.GearBox}");
Console.WriteLine($"Weight: {car1.Weigh} kg");
Console.WriteLine($"Seats Number: {car1.SeatsNumber}");


Console.WriteLine($"Engine Status: {car1.Engine(car1.Tempreture)}");