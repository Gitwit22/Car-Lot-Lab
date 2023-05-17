using Car_Lot_Lab;
using System;

Console.WriteLine("Here's a list of cars available");

List<Car> cars = new List<Car>();
Car taurus = new Car("ford", "taurus", 2019, 22000);
Car lexus = new Car("lexus", "coupe", 2011, 50000);
Car infinity = new Car("infinity", "q45", 2006, 40000);

cars.Add(taurus);
cars.Add(lexus);
cars.Add(infinity);



UsedCar bronco = new UsedCar("ford", "bronco", 1999, 22000, 15000);
UsedCar pinto = new UsedCar("ford", "pinto", 2011, 50000, 200000);
UsedCar benz = new UsedCar("mercades", "benz", 2006, 40000, 250000);

cars.Add(bronco);
cars.Add(pinto);
cars.Add(benz);

for (int i = 0; i < cars.Count; i++)
{

    Console.WriteLine($"Car {i + 1}: {cars[i]}");
}



Console.WriteLine("Which car would you like to buy? Enter the index:");
int selectedIndex = Convert.ToInt32(Console.ReadLine());

if (selectedIndex >= 1 && selectedIndex <= cars.Count)
{
    Car selectedCar = cars[selectedIndex - 1];
    Console.WriteLine($"Selected Car: {selectedCar}");
    cars.RemoveAt(selectedIndex - 1);
}
else
{
    Console.WriteLine("Invalid selection");
}

Console.WriteLine("Remaining Cars:");


for (int i = 0; i < cars.Count; i++)
{

    Console.WriteLine($"Car {i + 1}: {cars[i]}");
}


Console.WriteLine("Thank you for purchasing a car!");

